namespace DtmDatabase
{
    partial class form_posts
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_thumbnail = new System.Windows.Forms.PictureBox();
            this.button_thumbnail = new System.Windows.Forms.Button();
            this.radioButton_video = new System.Windows.Forms.RadioButton();
            this.radioButton_picture = new System.Windows.Forms.RadioButton();
            this.Content = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.ImagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button_newPost = new System.Windows.Forms.Button();
            this.button_deletePost = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(180, 394);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox_thumbnail);
            this.panel1.Controls.Add(this.button_thumbnail);
            this.panel1.Controls.Add(this.radioButton_video);
            this.panel1.Controls.Add(this.radioButton_picture);
            this.panel1.Controls.Add(this.Content);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.ImagePanel);
            this.panel1.Location = new System.Drawing.Point(198, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 393);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox_thumbnail
            // 
            this.pictureBox_thumbnail.Location = new System.Drawing.Point(338, 4);
            this.pictureBox_thumbnail.Name = "pictureBox_thumbnail";
            this.pictureBox_thumbnail.Size = new System.Drawing.Size(80, 74);
            this.pictureBox_thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_thumbnail.TabIndex = 6;
            this.pictureBox_thumbnail.TabStop = false;
            this.pictureBox_thumbnail.Click += new System.EventHandler(this.Picture_Click);
            // 
            // button_thumbnail
            // 
            this.button_thumbnail.Location = new System.Drawing.Point(338, 4);
            this.button_thumbnail.Name = "button_thumbnail";
            this.button_thumbnail.Size = new System.Drawing.Size(80, 74);
            this.button_thumbnail.TabIndex = 5;
            this.button_thumbnail.Text = "Thumbnail";
            this.button_thumbnail.UseVisualStyleBackColor = true;
            this.button_thumbnail.Click += new System.EventHandler(this.button_thumbnail_Click);
            // 
            // radioButton_video
            // 
            this.radioButton_video.AutoSize = true;
            this.radioButton_video.Location = new System.Drawing.Point(4, 28);
            this.radioButton_video.Name = "radioButton_video";
            this.radioButton_video.Size = new System.Drawing.Size(79, 17);
            this.radioButton_video.TabIndex = 4;
            this.radioButton_video.TabStop = true;
            this.radioButton_video.Text = "Chứa video";
            this.radioButton_video.UseVisualStyleBackColor = true;
            this.radioButton_video.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_picture
            // 
            this.radioButton_picture.AutoSize = true;
            this.radioButton_picture.Location = new System.Drawing.Point(4, 4);
            this.radioButton_picture.Name = "radioButton_picture";
            this.radioButton_picture.Size = new System.Drawing.Size(71, 17);
            this.radioButton_picture.TabIndex = 3;
            this.radioButton_picture.TabStop = true;
            this.radioButton_picture.Text = "Chứa ảnh";
            this.radioButton_picture.UseVisualStyleBackColor = true;
            this.radioButton_picture.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(338, 84);
            this.Content.Multiline = true;
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(274, 304);
            this.Content.TabIndex = 2;
            this.Content.TextChanged += new System.EventHandler(this.Content_TextChanged);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(424, 58);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(188, 20);
            this.Title.TabIndex = 1;
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // ImagePanel
            // 
            this.ImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePanel.Location = new System.Drawing.Point(4, 51);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(328, 337);
            this.ImagePanel.TabIndex = 0;
            // 
            // button_newPost
            // 
            this.button_newPost.Location = new System.Drawing.Point(12, 417);
            this.button_newPost.Name = "button_newPost";
            this.button_newPost.Size = new System.Drawing.Size(75, 23);
            this.button_newPost.TabIndex = 2;
            this.button_newPost.Text = "Thêm bài";
            this.button_newPost.UseVisualStyleBackColor = true;
            this.button_newPost.Click += new System.EventHandler(this.button_newPost_Click);
            // 
            // button_deletePost
            // 
            this.button_deletePost.Location = new System.Drawing.Point(94, 417);
            this.button_deletePost.Name = "button_deletePost";
            this.button_deletePost.Size = new System.Drawing.Size(75, 23);
            this.button_deletePost.TabIndex = 3;
            this.button_deletePost.Text = "Xóa bài";
            this.button_deletePost.UseVisualStyleBackColor = true;
            this.button_deletePost.Click += new System.EventHandler(this.button_deletePost_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(740, 417);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // form_posts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 452);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.button_deletePost);
            this.Controls.Add(this.button_newPost);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_posts";
            this.Text = "form_posts";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_thumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Content;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.FlowLayoutPanel ImagePanel;
        private System.Windows.Forms.Button button_newPost;
        private System.Windows.Forms.Button button_deletePost;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.RadioButton radioButton_video;
        private System.Windows.Forms.RadioButton radioButton_picture;
        private System.Windows.Forms.Button button_thumbnail;
        private System.Windows.Forms.PictureBox pictureBox_thumbnail;
    }
}