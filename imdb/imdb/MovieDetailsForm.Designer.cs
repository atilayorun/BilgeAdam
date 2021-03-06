﻿namespace imdb
{
    partial class MovieDetailsForm
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
            this.imgMovie = new System.Windows.Forms.PictureBox();
            this.lblMovieLable = new System.Windows.Forms.Label();
            this.lbDirectors = new System.Windows.Forms.ListBox();
            this.lbStars = new System.Windows.Forms.ListBox();
            this.lbWriters = new System.Windows.Forms.ListBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.Directors = new System.Windows.Forms.Label();
            this.Stars = new System.Windows.Forms.Label();
            this.Writers = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.btnSave2Db = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMovie
            // 
            this.imgMovie.Location = new System.Drawing.Point(570, 12);
            this.imgMovie.Name = "imgMovie";
            this.imgMovie.Size = new System.Drawing.Size(203, 188);
            this.imgMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMovie.TabIndex = 0;
            this.imgMovie.TabStop = false;
            this.imgMovie.Click += new System.EventHandler(this.imgMovie_Click);
            // 
            // lblMovieLable
            // 
            this.lblMovieLable.AutoSize = true;
            this.lblMovieLable.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieLable.Location = new System.Drawing.Point(45, 40);
            this.lblMovieLable.Name = "lblMovieLable";
            this.lblMovieLable.Size = new System.Drawing.Size(120, 20);
            this.lblMovieLable.TabIndex = 1;
            this.lblMovieLable.Text = "lblMovieLable";
            this.lblMovieLable.Click += new System.EventHandler(this.lblMovieLable_Click);
            // 
            // lbDirectors
            // 
            this.lbDirectors.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbDirectors.FormattingEnabled = true;
            this.lbDirectors.Location = new System.Drawing.Point(22, 238);
            this.lbDirectors.Name = "lbDirectors";
            this.lbDirectors.Size = new System.Drawing.Size(199, 147);
            this.lbDirectors.TabIndex = 2;
            this.lbDirectors.SelectedIndexChanged += new System.EventHandler(this.lbDirectors_SelectedIndexChanged);
            // 
            // lbStars
            // 
            this.lbStars.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbStars.FormattingEnabled = true;
            this.lbStars.Location = new System.Drawing.Point(304, 238);
            this.lbStars.Name = "lbStars";
            this.lbStars.Size = new System.Drawing.Size(199, 147);
            this.lbStars.TabIndex = 3;
            // 
            // lbWriters
            // 
            this.lbWriters.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbWriters.FormattingEnabled = true;
            this.lbWriters.Location = new System.Drawing.Point(570, 238);
            this.lbWriters.Name = "lbWriters";
            this.lbWriters.Size = new System.Drawing.Size(199, 147);
            this.lbWriters.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(26, 74);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(481, 126);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.Text = "";
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // Directors
            // 
            this.Directors.AutoSize = true;
            this.Directors.Location = new System.Drawing.Point(19, 222);
            this.Directors.Name = "Directors";
            this.Directors.Size = new System.Drawing.Size(50, 13);
            this.Directors.TabIndex = 6;
            this.Directors.Text = "Directors";
            // 
            // Stars
            // 
            this.Stars.AutoSize = true;
            this.Stars.Location = new System.Drawing.Point(301, 222);
            this.Stars.Name = "Stars";
            this.Stars.Size = new System.Drawing.Size(32, 13);
            this.Stars.TabIndex = 7;
            this.Stars.Text = "Stars";
            // 
            // Writers
            // 
            this.Writers.AutoSize = true;
            this.Writers.Location = new System.Drawing.Point(567, 222);
            this.Writers.Name = "Writers";
            this.Writers.Size = new System.Drawing.Size(42, 13);
            this.Writers.TabIndex = 8;
            this.Writers.Text = "Writers";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblRank.Location = new System.Drawing.Point(198, 37);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(72, 24);
            this.lblRank.TabIndex = 9;
            this.lblRank.Text = "lblRank";
            this.lblRank.Click += new System.EventHandler(this.lblRank_Click);
            // 
            // btnSave2Db
            // 
            this.btnSave2Db.Location = new System.Drawing.Point(661, 415);
            this.btnSave2Db.Name = "btnSave2Db";
            this.btnSave2Db.Size = new System.Drawing.Size(127, 23);
            this.btnSave2Db.TabIndex = 10;
            this.btnSave2Db.Text = "Save";
            this.btnSave2Db.UseVisualStyleBackColor = true;
            this.btnSave2Db.Click += new System.EventHandler(this.btnSave2Db_Click);
            // 
            // MovieDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.btnSave2Db);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.Writers);
            this.Controls.Add(this.Stars);
            this.Controls.Add(this.Directors);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbWriters);
            this.Controls.Add(this.lbStars);
            this.Controls.Add(this.lbDirectors);
            this.Controls.Add(this.lblMovieLable);
            this.Controls.Add(this.imgMovie);
            this.Name = "MovieDetailsForm";
            this.Text = "MovieDetailsForm";
            this.Load += new System.EventHandler(this.MovieDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMovie;
        private System.Windows.Forms.Label lblMovieLable;
        private System.Windows.Forms.ListBox lbDirectors;
        private System.Windows.Forms.ListBox lbStars;
        private System.Windows.Forms.ListBox lbWriters;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label Directors;
        private System.Windows.Forms.Label Stars;
        private System.Windows.Forms.Label Writers;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Button btnSave2Db;
    }
}