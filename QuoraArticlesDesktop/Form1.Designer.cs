
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
            this.last_loaded_label = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.fav_polish_articles_btn = new System.Windows.Forms.Button();
            this.fav_german_articles_btn = new System.Windows.Forms.Button();
            this.fav_english_articles_btn = new System.Windows.Forms.Button();
            this.polish_articles_button = new System.Windows.Forms.Button();
            this.german_articles_button = new System.Windows.Forms.Button();
            this.english_articles_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.loaded_from_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quora Artikeln";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.loaded_from_label);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.last_loaded_label);
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Controls.Add(this.fav_polish_articles_btn);
            this.panel1.Controls.Add(this.fav_german_articles_btn);
            this.panel1.Controls.Add(this.fav_english_articles_btn);
            this.panel1.Controls.Add(this.polish_articles_button);
            this.panel1.Controls.Add(this.german_articles_button);
            this.panel1.Controls.Add(this.english_articles_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 98);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(742, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 58);
            this.button1.TabIndex = 11;
            this.button1.Text = "Artikeln Laden";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // last_loaded_label
            // 
            this.last_loaded_label.AutoSize = true;
            this.last_loaded_label.Location = new System.Drawing.Point(739, 13);
            this.last_loaded_label.Name = "last_loaded_label";
            this.last_loaded_label.Size = new System.Drawing.Size(69, 13);
            this.last_loaded_label.TabIndex = 10;
            this.last_loaded_label.Text = "Last Loaded:";
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(868, 34);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(91, 38);
            this.clear_btn.TabIndex = 9;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // fav_polish_articles_btn
            // 
            this.fav_polish_articles_btn.BackColor = System.Drawing.Color.Blue;
            this.fav_polish_articles_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fav_polish_articles_btn.ForeColor = System.Drawing.Color.White;
            this.fav_polish_articles_btn.Location = new System.Drawing.Point(600, 59);
            this.fav_polish_articles_btn.Name = "fav_polish_articles_btn";
            this.fav_polish_articles_btn.Size = new System.Drawing.Size(103, 36);
            this.fav_polish_articles_btn.TabIndex = 8;
            this.fav_polish_articles_btn.Text = "LieblingspolnischeArtikeln";
            this.fav_polish_articles_btn.UseVisualStyleBackColor = false;
            this.fav_polish_articles_btn.Click += new System.EventHandler(this.fav_polish_articles_btn_Click);
            // 
            // fav_german_articles_btn
            // 
            this.fav_german_articles_btn.BackColor = System.Drawing.Color.Blue;
            this.fav_german_articles_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fav_german_articles_btn.ForeColor = System.Drawing.Color.White;
            this.fav_german_articles_btn.Location = new System.Drawing.Point(473, 59);
            this.fav_german_articles_btn.Name = "fav_german_articles_btn";
            this.fav_german_articles_btn.Size = new System.Drawing.Size(105, 36);
            this.fav_german_articles_btn.TabIndex = 7;
            this.fav_german_articles_btn.Text = "LieblingsdeutscheArtikeln";
            this.fav_german_articles_btn.UseVisualStyleBackColor = false;
            this.fav_german_articles_btn.Click += new System.EventHandler(this.fav_german_articles_btn_Click);
            // 
            // fav_english_articles_btn
            // 
            this.fav_english_articles_btn.BackColor = System.Drawing.Color.Blue;
            this.fav_english_articles_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fav_english_articles_btn.ForeColor = System.Drawing.Color.White;
            this.fav_english_articles_btn.Location = new System.Drawing.Point(337, 59);
            this.fav_english_articles_btn.Name = "fav_english_articles_btn";
            this.fav_english_articles_btn.Size = new System.Drawing.Size(104, 36);
            this.fav_english_articles_btn.TabIndex = 6;
            this.fav_english_articles_btn.Text = "LieblingsenglischeArtikeln";
            this.fav_english_articles_btn.UseVisualStyleBackColor = false;
            this.fav_english_articles_btn.Click += new System.EventHandler(this.fav_english_articles_btn_Click);
            // 
            // polish_articles_button
            // 
            this.polish_articles_button.Location = new System.Drawing.Point(612, 12);
            this.polish_articles_button.Name = "polish_articles_button";
            this.polish_articles_button.Size = new System.Drawing.Size(91, 36);
            this.polish_articles_button.TabIndex = 5;
            this.polish_articles_button.Text = "Polnische Artikeln";
            this.polish_articles_button.UseVisualStyleBackColor = true;
            this.polish_articles_button.Click += new System.EventHandler(this.polish_articles_button_Click);
            // 
            // german_articles_button
            // 
            this.german_articles_button.Location = new System.Drawing.Point(487, 12);
            this.german_articles_button.Name = "german_articles_button";
            this.german_articles_button.Size = new System.Drawing.Size(91, 36);
            this.german_articles_button.TabIndex = 4;
            this.german_articles_button.Text = "Deutsche Artikeln";
            this.german_articles_button.UseVisualStyleBackColor = true;
            this.german_articles_button.Click += new System.EventHandler(this.german_articles_button_Click);
            // 
            // english_articles_button
            // 
            this.english_articles_button.Location = new System.Drawing.Point(350, 12);
            this.english_articles_button.Name = "english_articles_button";
            this.english_articles_button.Size = new System.Drawing.Size(91, 36);
            this.english_articles_button.TabIndex = 3;
            this.english_articles_button.Text = "Englishe Artikeln";
            this.english_articles_button.UseVisualStyleBackColor = true;
            this.english_articles_button.Click += new System.EventHandler(this.english_articles_button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 98);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1044, 445);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // loaded_from_label
            // 
            this.loaded_from_label.AutoSize = true;
            this.loaded_from_label.Location = new System.Drawing.Point(876, 14);
            this.loaded_from_label.Name = "loaded_from_label";
            this.loaded_from_label.Size = new System.Drawing.Size(65, 13);
            this.loaded_from_label.TabIndex = 12;
            this.loaded_from_label.Text = "Geladen ab:";
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button fav_polish_articles_btn;
        private System.Windows.Forms.Button fav_german_articles_btn;
        private System.Windows.Forms.Button fav_english_articles_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label last_loaded_label;
        private System.Windows.Forms.Label loaded_from_label;
    }
}

