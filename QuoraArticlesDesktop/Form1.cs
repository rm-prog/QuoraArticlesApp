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

        public Form1()
        {
            InitializeComponent();
        }

        // When article link is clicked, it sends you to the url
        private void ClickedLink(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e, string link)
        {
            System.Diagnostics.Process.Start(link);
        }

        private void AddToFavorites(object sender, EventArgs e, int index, string link, string language)
        {
            string json = File.ReadAllText(@"C:\Users\Rikardo\Documents\programming\python\quora_articles_hidden_files\questions_links.json");
            dynamic question_links = JsonConvert.DeserializeObject(json);
            question_links[$"favorite_{language}_question"].Add(question_links[$"{language}_question"][index]);
            question_links[$"{language}_question"][index].Remove();
            string output = JsonConvert.SerializeObject(question_links, Formatting.Indented);
            File.WriteAllText(@"C:\Users\Rikardo\Documents\programming\python\quora_articles_hidden_files\questions_links.json", output);
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
            };
            // Add Event Handler that will add article to favorite articles
            int index = articlePanelIndex;
            AddToFavoritesBtn.Click += new EventHandler((sender, e) => AddToFavorites(sender, e, index, link, language));
            ArticlePanel.Controls.Add(AddToFavoritesBtn);
            AddToFavoritesBtn.Location = new Point(11, 160);
            articlePanelIndex++;
            // Add ArticlePanel
            flowLayoutPanel1.Controls.Add(ArticlePanel);
        }

        private void english_articles_button_Click(object sender, EventArgs e)
        {
            // Read JSON files with Articles and Links
            // Display English Articles in Flow Layout Panel
            using (StreamReader r = new StreamReader(@"C:\Users\Rikardo\Documents\programming\python\quora_articles_hidden_files\questions_links.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var article in array["english_question"])
                {
                    createArticlePanel(Convert.ToString(article[0]), Convert.ToString(article[1]), "english");
                }
            }
        }

        private void german_articles_button_Click(object sender, EventArgs e)
        {
            // Read JSON files with Articles and Links
            // Display German Articles in Flow Layout Panel
            using (StreamReader r = new StreamReader(@"C:\Users\Rikardo\Documents\programming\python\quora_articles_hidden_files\questions_links.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var article in array["german_question"])
                {
                    createArticlePanel(Convert.ToString(article[0]), Convert.ToString(article[1]), "german");
                }
            }
        }

        private void polish_articles_button_Click(object sender, EventArgs e)
        {
            // Read JSON files with Articles and Links
            // Display German Articles in Flow Layout Panel
            using (StreamReader r = new StreamReader(@"C:\Users\Rikardo\Documents\programming\python\quora_articles_hidden_files\questions_links.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var article in array["polish_question"])
                {
                    createArticlePanel(Convert.ToString(article[0]), Convert.ToString(article[1]), "polish");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
