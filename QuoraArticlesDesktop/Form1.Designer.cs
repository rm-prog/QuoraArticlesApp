
namespace QuoraArticlesDesktop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.polish_articles_button = new System.Windows.Forms.Button();
            this.german_articles_button = new System.Windows.Forms.Button();
            this.english_articles_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(52, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quora Articles";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.polish_articles_button);
            this.panel1.Controls.Add(this.german_articles_button);
            this.panel1.Controls.Add(this.english_articles_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 62);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Delete Titles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // polish_articles_button
            // 
            this.polish_articles_button.Location = new System.Drawing.Point(574, 13);
            this.polish_articles_button.Name = "polish_articles_button";
            this.polish_articles_button.Size = new System.Drawing.Size(91, 36);
            this.polish_articles_button.TabIndex = 5;
            this.polish_articles_button.Text = "Polish Articles";
            this.polish_articles_button.UseVisualStyleBackColor = true;
            this.polish_articles_button.Click += new System.EventHandler(this.polish_articles_button_Click);
            // 
            // german_articles_button
            // 
            this.german_articles_button.Location = new System.Drawing.Point(477, 13);
            this.german_articles_button.Name = "german_articles_button";
            this.german_articles_button.Size = new System.Drawing.Size(91, 36);
            this.german_articles_button.TabIndex = 4;
            this.german_articles_button.Text = "German Articles";
            this.german_articles_button.UseVisualStyleBackColor = true;
            this.german_articles_button.Click += new System.EventHandler(this.german_articles_button_Click);
            // 
            // english_articles_button
            // 
            this.english_articles_button.Location = new System.Drawing.Point(380, 12);
            this.english_articles_button.Name = "english_articles_button";
            this.english_articles_button.Size = new System.Drawing.Size(91, 36);
            this.english_articles_button.TabIndex = 3;
            this.english_articles_button.Text = "English Articles";
            this.english_articles_button.UseVisualStyleBackColor = true;
            this.english_articles_button.Click += new System.EventHandler(this.english_articles_button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1044, 481);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1044, 543);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button polish_articles_button;
        private System.Windows.Forms.Button german_articles_button;
        private System.Windows.Forms.Button english_articles_button;
        private System.Windows.Forms.Button button1;
    }
}

