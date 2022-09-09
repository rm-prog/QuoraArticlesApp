# Collect quora articles received by email with gmail API
# Store them somewhere (JSON file?)
import os.path

from google.auth.transport.requests import Request
from google.oauth2.credentials import Credentials
from google_auth_oauthlib.flow import InstalledAppFlow
from googleapiclient.discovery import build
from googleapiclient.errors import HttpError
import base64
import re
from bs4 import BeautifulSoup
import json
import sys

# If modifying these scopes, delete the file token.json.
SCOPES = ['https://www.googleapis.com/auth/gmail.readonly']

# functions to extract questions with corresponding links based on the language

def get_german_questions (msg_part):

    msg_data = msg_part["parts"][0]["body"]["data"].replace("-","+").replace("_","/")

    decoded_data = base64.b64decode(msg_data)

    soup = BeautifulSoup(decoded_data , "lxml")
    body = str(soup.body()).replace('\r', '')

    questions = re.findall("Frage:(.*)?", body)
    links = re.findall(r'(https?://de.quora.com/qemail/\S+)', body)

    del links[-1]
    del links[-1]

    return tuple(zip(questions, links))

def get_polish_questions (msg_part):
    
    msg_data = msg_part["parts"][0]["body"]["data"].replace("-","+").replace("_","/")

    decoded_data = base64.b64decode(msg_data)

    soup = BeautifulSoup(decoded_data , "lxml")
    body = str(soup.body()).replace('\r', '')

    questions = re.findall("Pytanie:(.*)?", body)
    links = re.findall(r'(https?://pl.quora.com/qemail/\S+)', body)

    del links[-1]
    del links[-1]

    return tuple(zip(questions, links))

def get_english_questions (msg_part):
    
    msg_data = msg_part["parts"][0]["body"]["data"].replace("-","+").replace("_","/")

    decoded_data = base64.b64decode(msg_data)

    soup = BeautifulSoup(decoded_data , "lxml")
    body = str(soup.body()).replace('\r', '')

    questions = re.findall("Question:(.*)?", body)
    links = re.findall(r'(https?://www.quora.com/qemail/\S+)', body)

    del links[-1]

    return tuple(zip(questions, links))


# Main Function
# @param after_date_email: date after which will search for emails


def main(after_date_of_email):
    # Authentication
    """Shows basic usage of the Gmail API.
    Lists the user's Gmail labels.
    """
    creds = None
    # The file token.json stores the user's access and refresh tokens, and is
    # created automatically when the authorization flow completes for the first
    # time.
    if os.path.exists('../quora_articles_hidden_files/token.json'):
        creds = Credentials.from_authorized_user_file('../quora_articles_hidden_files/token.json', SCOPES)
    # If there are no (valid) credentials available, let the user log in.
    if not creds or not creds.valid:
        if creds and creds.expired and creds.refresh_token:
            creds.refresh(Request())
        else:
            flow = InstalledAppFlow.from_client_secrets_file(
                '../quora_articles_hidden_files/credentials.json', SCOPES)
            creds = flow.run_local_server(port=0)
        # Save the credentials for the next run
        with open('../quora_articles_hidden_files/token.json', 'w') as token:
            token.write(creds.to_json())

    # !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    # !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    # /////////////////////////// IMPORTANT PART ///////////////////////////////// 
    try:
        # Call the Gmail API
        service = build('gmail', 'v1', credentials=creds)

        # Get emails with subject Quora Digest after a certain date

        search_results = service.users().messages().list(userId="rminollari@gmail.com", q=f"Quora Digest, after:{after_date_of_email}").execute()
        messages = search_results["messages"]

        german_questions = []
        polish_questions = []
        english_questions = []

        for message in messages:
            # Get the message
            msg = service.users().messages().get(userId="rminollari@gmail.com", id=message["id"]).execute()
            msg_part = msg["payload"]
            # Check the language and call the function to extract the questions
            # and links according to the language
            if msg_part["headers"][15]["value"] == "Quora Digest <german-personalized-digest@quora.com>":
                german_questions.append(get_german_questions(msg_part))
            elif msg_part["headers"][15]["value"] == "Quora Digest <polish-personalized-digest@quora.com>":
                polish_questions.append(get_polish_questions(msg_part))
            elif msg_part["headers"][15]["value"] == "Quora Digest <english-personalized-digest@quora.com>":
                english_questions.append(get_english_questions(msg_part))

        # Store them in json file
        with open('../quora_articles_hidden_files/questions_links.json', 'r+', encoding='utf_8_sig') as f:
            data = json.load(f)
            data['english_question'].append(english_questions)
            data['german_question'].append(german_questions)
            data['polish_question'].append(polish_questions)
            f.seek(0)        # <--- should reset file position to the beginning.
            json.dump(data, f, indent=4)
            f.truncate()     # remove remaining part

    except HttpError as error:
        # TODO(developer) - Handle errors from gmail API.
        print(f'An error occurred: {error}')


if __name__ == '__main__':
    after_date = sys.argv[1]
    main(after_date)