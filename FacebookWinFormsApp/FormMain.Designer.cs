﻿namespace BasicFacebookFeatures
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            this.checkBoxFriends = new System.Windows.Forms.CheckBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.labelFetchAlbums = new System.Windows.Forms.Label();
            this.checkBoxAlbums = new System.Windows.Forms.CheckBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.labelFetchPosts = new System.Windows.Forms.Label();
            this.checkBoxPosts = new System.Windows.Forms.CheckBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.pictureBoxLogoFacebook = new System.Windows.Forms.PictureBox();
            this.buttonTrivia = new System.Windows.Forms.Button();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoFacebook)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(18, 18);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 52);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogout.Location = new System.Drawing.Point(18, 72);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 50);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(32, 131);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(254, 248);
            this.pictureBoxProfile.TabIndex = 53;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileName.Location = new System.Drawing.Point(331, 28);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(73, 29);
            this.labelProfileName.TabIndex = 54;
            this.labelProfileName.Text = "label1";
            this.labelProfileName.Visible = false;
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriends.Location = new System.Drawing.Point(32, 459);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(201, 32);
            this.labelFriends.TabIndex = 55;
            this.labelFriends.Text = "Fetch Friends";
            // 
            // checkBoxFriends
            // 
            this.checkBoxFriends.AutoSize = true;
            this.checkBoxFriends.Location = new System.Drawing.Point(38, 505);
            this.checkBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxFriends.Name = "checkBoxFriends";
            this.checkBoxFriends.Size = new System.Drawing.Size(124, 24);
            this.checkBoxFriends.TabIndex = 56;
            this.checkBoxFriends.Text = "show friends";
            this.checkBoxFriends.UseVisualStyleBackColor = true;
            this.checkBoxFriends.Visible = false;
            this.checkBoxFriends.CheckedChanged += new System.EventHandler(this.checkBoxFriends_CheckedChanged);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(38, 549);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(257, 324);
            this.listBoxFriends.TabIndex = 57;
            this.listBoxFriends.Click += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.Location = new System.Drawing.Point(315, 549);
            this.pictureBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(192, 320);
            this.pictureBoxFriends.TabIndex = 58;
            this.pictureBoxFriends.TabStop = false;
            // 
            // labelFetchAlbums
            // 
            this.labelFetchAlbums.AutoSize = true;
            this.labelFetchAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFetchAlbums.Location = new System.Drawing.Point(660, 459);
            this.labelFetchAlbums.Name = "labelFetchAlbums";
            this.labelFetchAlbums.Size = new System.Drawing.Size(200, 32);
            this.labelFetchAlbums.TabIndex = 59;
            this.labelFetchAlbums.Text = "Fetch Albums";
            // 
            // checkBoxAlbums
            // 
            this.checkBoxAlbums.AutoSize = true;
            this.checkBoxAlbums.Location = new System.Drawing.Point(666, 505);
            this.checkBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAlbums.Name = "checkBoxAlbums";
            this.checkBoxAlbums.Size = new System.Drawing.Size(127, 24);
            this.checkBoxAlbums.TabIndex = 60;
            this.checkBoxAlbums.Text = "show albums";
            this.checkBoxAlbums.UseVisualStyleBackColor = true;
            this.checkBoxAlbums.Visible = false;
            this.checkBoxAlbums.CheckedChanged += new System.EventHandler(this.checkBoxAlbums_CheckedChanged);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 20;
            this.listBoxAlbums.Location = new System.Drawing.Point(666, 545);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(258, 324);
            this.listBoxAlbums.TabIndex = 61;
            this.listBoxAlbums.Click += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.Location = new System.Drawing.Point(957, 545);
            this.pictureBoxAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(207, 324);
            this.pictureBoxAlbum.TabIndex = 62;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // labelFetchPosts
            // 
            this.labelFetchPosts.AutoSize = true;
            this.labelFetchPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFetchPosts.Location = new System.Drawing.Point(309, 134);
            this.labelFetchPosts.Name = "labelFetchPosts";
            this.labelFetchPosts.Size = new System.Drawing.Size(175, 32);
            this.labelFetchPosts.TabIndex = 63;
            this.labelFetchPosts.Text = "Fetch Posts";
            // 
            // checkBoxPosts
            // 
            this.checkBoxPosts.AutoSize = true;
            this.checkBoxPosts.Location = new System.Drawing.Point(315, 169);
            this.checkBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxPosts.Name = "checkBoxPosts";
            this.checkBoxPosts.Size = new System.Drawing.Size(115, 24);
            this.checkBoxPosts.TabIndex = 64;
            this.checkBoxPosts.Text = "show posts";
            this.checkBoxPosts.UseVisualStyleBackColor = true;
            this.checkBoxPosts.Visible = false;
            this.checkBoxPosts.CheckedChanged += new System.EventHandler(this.checkBoxShowPosts_CheckedChanged);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(315, 195);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(372, 184);
            this.listBoxPosts.TabIndex = 65;
            // 
            // pictureBoxLogoFacebook
            // 
            this.pictureBoxLogoFacebook.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoFacebook.Image")));
            this.pictureBoxLogoFacebook.Location = new System.Drawing.Point(1106, 18);
            this.pictureBoxLogoFacebook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogoFacebook.Name = "pictureBoxLogoFacebook";
            this.pictureBoxLogoFacebook.Size = new System.Drawing.Size(133, 126);
            this.pictureBoxLogoFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoFacebook.TabIndex = 66;
            this.pictureBoxLogoFacebook.TabStop = false;
            // 
            // buttonTrivia
            // 
            this.buttonTrivia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTrivia.BackgroundImage")));
            this.buttonTrivia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTrivia.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonTrivia.Location = new System.Drawing.Point(857, 32);
            this.buttonTrivia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTrivia.Name = "buttonTrivia";
            this.buttonTrivia.Size = new System.Drawing.Size(197, 228);
            this.buttonTrivia.TabIndex = 67;
            this.buttonTrivia.UseVisualStyleBackColor = true;
            this.buttonTrivia.Click += new System.EventHandler(this.buttonTrivia_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxRememberMe.ForeColor = System.Drawing.Color.Red;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(336, 60);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(177, 29);
            this.checkBoxRememberMe.TabIndex = 68;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1263, 1011);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.buttonTrivia);
            this.Controls.Add(this.pictureBoxLogoFacebook);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.checkBoxPosts);
            this.Controls.Add(this.labelFetchPosts);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.checkBoxAlbums);
            this.Controls.Add(this.labelFetchAlbums);
            this.Controls.Add(this.pictureBoxFriends);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.checkBoxFriends);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.labelProfileName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoFacebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.CheckBox checkBoxFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.Label labelFetchAlbums;
        private System.Windows.Forms.CheckBox checkBoxAlbums;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.Label labelFetchPosts;
        private System.Windows.Forms.CheckBox checkBoxPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.PictureBox pictureBoxLogoFacebook;
        private System.Windows.Forms.Button buttonTrivia;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
    }
}

