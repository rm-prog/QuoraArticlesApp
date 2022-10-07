using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace QuoraArticlesDesktop
{
    public partial class Form1 : Form
    {

        private int articlePanelIndex = 0;
        private List<int> favoriteEnglishIndexes = new List<int>();
        private List<int> favoriteGermanIndexes = new List<int>();
        private List<int> favoritePolishIndexes = new List<int>();

        private List<int> readEnglishIndexes = new List<int>();
        private List<int> readGermanIndexes = new List<int>();
        private List<int> readPolishIndexes = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        // When article link is clicked, it sends you to the url
        private void ClickedLink(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e, string link) => System.Diagnostics.Process.Start(link);

        // Add Article to list of favorite Articles
        private void AddToFavorites(object sender, EventArgs e, int index, string language, Panel panel)
        {
            if (language == "english") favoriteEnglishIndexes.Add(index);
            else if (language == "german") favoriteGermanIndexes.Add(index);
            else if (language == "polish") favoritePolishIndexes.Add(index);

            // Remove ArticlePanel from display
            panel.Dispose();
        }

        // Add FavoriteArticle to list of already read Articles
        private void AddToRead(object sender, EventArgs e, int index, string language, Panel panel)
        {
            if (language == "english") readEnglishIndexes.Add(index);
            else if (language == "german") readGermanIndexes.Add(index);
            else if (language == "polish") readPolishIndexes.Add(index);

            // Remove FavoriteArticlefromDisplay
            panel.Dispose();
        }

        private void DeleteArticle(object sender, EventArgs e, Panel panel)
        {
            // Remove ArticlePanel from display
            panel.Dispose();
        }

        // create new ArticlePanel
        private void createArticlePanel(string question, string link, string language)
        {
            // Create new Panel with the ArticleQuestion and Link
            Panel ArticlePanel = new Panel
            {
                Size = new Size(282, 204),
                BackColor = Color.White
            };

            // Create new Label with the Question
            Label Question = new Label
            {
                Text = question,
                Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold),
                AutoSize = true,
                MaximumSize = new Size(270, 0)
            };
            // Add QuestionLabel to the ArticlePanel
            ArticlePanel.Controls.Add(Question);
            Question.Location = new Point(7, 11);

            // Create new LinkLabel with Link to the article
            LinkLabel Link = new LinkLabel
            {
                AutoSize = true,
                MaximumSize = new Size(270, 13),
                Text = link
            };
            // Add EventHandler to go to the link when Link is clicked
            Link.LinkClicked += new LinkLabelLinkClickedEventHandler((sender, e) => ClickedLink(sender, e, link));
            // Add Link to the ArticlePanel
            ArticlePanel.Controls.Add(Link);
            Link.Location = new Point(4, 135);

            // Create AddToFavorites button
            Button AddToFavoritesBtn = new Button
            {
                Size = new Size(135, 30),
                Font = new Font("Microsoft YaHei", 9, FontStyle.Regular),
                Text = "Add to Favorites",
                BackColor = Color.GreenYellow,
                FlatStyle = FlatStyle.Flat
            };
            // Add Event Handler that will add article to favorite articles
            int index = articlePanelIndex;
            // Add AddToFavoritesBtn to the ArticlePanel
            AddToFavoritesBtn.Click += new EventHandler((sender, e) => AddToFavorites(sender, e, index, language, ArticlePanel));
            ArticlePanel.Controls.Add(AddToFavoritesBtn);
            AddToFavoritesBtn.Location = new Point(11, 160);

            // Create DeleteArticle Button
            Button DeleteButton = new Button
            {
                Size = new Size(70, 30),
                Font = new Font("Microsoft YaHei", 9, FontStyle.Regular),
                Text = "Delete",
                BackColor = Color.Red,
                FlatStyle = FlatStyle.Flat
            };
            // Add Event Handler that will delete article
            DeleteButton.Click += new EventHandler((sender, e) => DeleteArticle(sender, e, ArticlePanel));
            // Add DeleteButton to the ArticlePanel
            ArticlePanel.Controls.Add(DeleteButton);
            DeleteButton.Location = new Point(180, 160);
            articlePanelIndex++;
            // Add ArticlePanel
            flowLayoutPanel1.Controls.Add(ArticlePanel);
        }

        // create new FavoriteArticlePanel
        private void createFavoriteArticlePanel(string question, string link, string language)
        {
            // Create new Panel with the ArticleQuestion and Link
            Panel FavoriteArticlePanel = new Panel
            {
                Size = new Size(282, 204),
                BackColor = Color.FloralWhite
            };

            // Create new Label with the Question
            Label Question = new Label
            {
                Text = question,
                Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold),
                AutoSize = true,
                MaximumSize = new Size(270, 0)
            };
            // Add QuestionLabel to the ArticlePanel
            FavoriteArticlePanel.Controls.Add(Question);
            Question.Location = new Point(7, 11);

            // Create new LinkLabel with Link to the article
            LinkLabel Link = new LinkLabel
            {
                AutoSize = true,
                MaximumSize = new Size(270, 13),
                Text = link
            };
            // Add EventHandler to go to the link when Link is clicked
            Link.LinkClicked += new LinkLabelLinkClickedEventHandler((sender, e) => ClickedLink(sender, e, link));
            // Add Link to the ArticlePanel
            FavoriteArticlePanel.Controls.Add(Link);
            Link.Location = new Point(4, 135);
            // Create AddToRead button
            Button AddToReadBtn = new Button
            {
                Size = new Size(135, 30),
                Font = new Font("Microsoft YaHei", 9, FontStyle.Regular),
                Text = "Add to Read",
                BackColor = Color.GreenYellow,
                FlatStyle = FlatStyle.Flat
            };
            // Add Event Handler that will add article to read articles
            int index = articlePanelIndex;
            // Add AddToReadBtn to the FavoriteArticlePanel
            AddToReadBtn.Click += new EventHandler((sender, e) => AddToRead(sender, e, index, language, FavoriteArticlePanel));
            FavoriteArticlePanel.Controls.Add(AddToReadBtn);
            AddToReadBtn.Location = new Point(11, 160);
            articlePanelIndex++;
            // Add FavoriteArticlePanel
            flowLayoutPanel1.Controls.Add(FavoriteArticlePanel);
        }

        private void displayArticles(string category, string language, bool favoriteArticles)
        {
            // Read JSON files with Articles and Links
            // Display articles from category in Flow Layout Panel
            using (StreamReader r = new StreamReader(@"C:\Users\Rikardo\Documents\programming\python\quora_articles_hidden_files\questions_links.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                if (!favoriteArticles)
                {
                    foreach (var article in array[category])
                    {
                        createArticlePanel(Convert.ToString(article[0]), Convert.ToString(article[1]), language);
                    }
                    return;
                }
                foreach (var article in array[category])
                {
                    createFavoriteArticlePanel(Convert.ToString(article[0]), Convert.ToString(article[1]), language);
                }
            }
        }

        // Display english articles
        private void english_articles_button_Click(object sender, EventArgs e)
        {
            // Read JSON files with Articles and Links
            // Display English Articles in Flow Layout Panel
            displayArticles("english_question", "english", false);
        }

        // Display german articles
        private void german_articles_button_Click(object sender, EventArgs e)
        {
            // Read JSON files with Articles and Links
            // Display German Articles in Flow Layout Panel
            displayArticles("german_question", "german", false);
        }

        // Display polish articles
        private void polish_articles_button_Click(object sender, EventArgs e)
        {
            // Read JSON files with Articles and Links
            // Display German Articles in Flow Layout Panel
            displayArticles("polish_question", "polish", false);
        }

        // Clear flowLayoutPanel from all articles
        // When its favorite articles, then add read Articles to read_articles JSON file
        // Else add favorite articles to favorite_articles array in JSON file
        // And remove the rest from JSON file
        private void clear_btn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            articlePanelIndex = 0;
            favoriteEnglishIndexes = favoriteEnglishIndexes.OrderByDescending(x => x).ToList();
            favoriteGermanIndexes = favoriteGermanIndexes.OrderByDescending(x => x).ToList();
            favoritePolishIndexes = favoritePolishIndexes.OrderByDescending(x => x).ToList();

            // Read data from JSON file
            string json = File.ReadAllText(@"C:\Users\Rikardo\Documents\programming\python\quora_articles_hidden_files\questions_links.json");
            // Convert the JSON data to another data type (array, list, whatever)
            dynamic question_links = JsonConvert.DeserializeObject(json);


            // Add Favorite articles in descending order based on index in JSON array to respective arrays
            foreach (int index in favoriteEnglishIndexes)
            {
                // Add the article position at @param index in JSON array to favorite articles and remove it from the first array
                question_links[$"favorite_english_question"].Add(question_links[$"english_question"][index]);
                question_links[$"english_question"][index].Remove();
            }
            foreach (int index in favoriteGermanIndexes)
            {
                // Add the article position at @param index in JSON array to favorite articles and remove it from the first array
                question_links[$"favorite_german_question"].Add(question_links[$"german_question"][index]);
                question_links[$"german_question"][index].Remove();
            }
            foreach (int index in favoritePolishIndexes)
            {
                // Add the article position at @param index in JSON array to favorite articles and remove it from the first array
                question_links[$"favorite_polish_question"].Add(question_links[$"polish_question"][index]);
                question_links[$"polish_question"][index].Remove();
            }


            // Save the changes to the JSON file
            string output = JsonConvert.SerializeObject(question_links, Formatting.Indented);
            File.WriteAllText(@"C:\Users\Rikardo\Documents\programming\python\quora_articles_hidden_files\questions_links.json", output);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Read JSON files with Articles and Links
            // Get last_loaded_date and display it
            using (StreamReader r = new StreamReader(@"C:\Users\Rikardo\Documents\programming\python\quora_articles_hidden_files\questions_links.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                last_loaded_label.Text = $"Letzt geladen: {array["last_loaded"]}";
                loaded_from_label.Text = $"Geladen ab: {array["loaded_from"]}";
            }
        }

        // Display favorite english articles
        private void fav_english_articles_btn_Click(object sender, EventArgs e)
        {
            // Read JSON files with Articles and Links
            // Display English Favorite Articles in Flow Layout Panel
            displayArticles("favorite_english_question", "english", true);
        }

        // Display favorite german articles
        private void fav_german_articles_btn_Click(object sender, EventArgs e)
        {
            // Read JSON files with Articles and Links
            // Display German Favorite Articles in Flow Layout Panel
            displayArticles("favorite_german_question", "german", true);
        }

        // Display favorite polish articles
        private void fav_polish_articles_btn_Click(object sender, EventArgs e)
        {
            // Read JSON files with Articles and Links
            // Display Polish Favorite Articles in Flow Layout Panel
            displayArticles("favorite_polish_question", "polish", true);
        }
    }
}
