import os.path

from google.auth.transport.requests import Request
from google.oauth2.credentials import Credentials
from google_auth_oauthlib.flow import InstalledAppFlow
from googleapiclient.discovery import build
from googleapiclient.errors import HttpError
import base64
import re
from bs4 import BeautifulSoup

# If modifying these scopes, delete the file token.json.
SCOPES = ['https://www.googleapis.com/auth/gmail.readonly']

def main():
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

        search_results = service.users().messages().list(userId="rminollari@gmail.com", q=f"Quora Digest", maxResults=1).execute()
        messages = search_results["messages"]

        for message in messages:
            msg = service.users().messages().get(userId="rminollari@gmail.com", id=message["id"]).execute()
            msg_part = msg["payload"]
            for header in msg_part["headers"]:
                print(header)

    except HttpError as error:
        # TODO(developer) - Handle errors from gmail API.
        print(f'An error occurred: {error}')



if __name__ == '__main__':
    main()