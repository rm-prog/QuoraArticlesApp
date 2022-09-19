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
        public Form1()
        {
            InitializeComponent();
        }

        // When article link is clicked, it sends you to the url
        private void ClickedLink(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e, string link)
        {
            System.Diagnostics.Process.Start(link);
        }

        // create new ArticlePanel
        public void createArticlePanel(string question, string link)
        {
            // Create new Panel with the ArticleQuestion and Link
            Panel ArticlePanel = new Panel();
            ArticlePanel.Size = new Size(282, 175);
            ArticlePanel.BackColor = Color.White;
            // Create new Label with the Question
            Label Question = new Label();
            Question.Text = question;
            Question.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            Question.AutoSize = true;
            Question.MaximumSize = new Size(270, 0);
            // Add QuestionLabel to the ArticlePanel
            ArticlePanel.Controls.Add(Question);
            Question.Location = new Point(7, 11);
            // Create new LinkLabel with Link to the article
            LinkLabel Link = new LinkLabel();
            Link.AutoSize = true;
            Link.MaximumSize = new Size(270, 13);
            Link.Text = link;
            // Add EventHandler to go to the link when Link is clicked
            Link.LinkClicked += new LinkLabelLinkClickedEventHandler((sender, e) => ClickedLink(sender, e, link));
            // Add Link to the ArticlePanel
            ArticlePanel.Controls.Add(Link);
            Link.Location = new Point(4, 135);
            // Add ArticlePanel
            flowLayoutPanel1.Controls.Add(ArticlePanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createArticlePanel("Question from Quora", "https://www.quora.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader(@"C:\Users\Rikardo\Documents\programming\python\quora_articles_hidden_files\questions_links.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach(var article in array["english_question"])
                {
                    createArticlePanel(Convert.ToString(article[0]), Convert.ToString(article[1]));
                }
            }
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
                    createArticlePanel(Convert.ToString(article[0]), Convert.ToString(article[1]));
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
                    createArticlePanel(Convert.ToString(article[0]), Convert.ToString(article[1]));
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
                    createArticlePanel(Convert.ToString(article[0]), Convert.ToString(article[1]));
                }
            }
        }
    }
}
