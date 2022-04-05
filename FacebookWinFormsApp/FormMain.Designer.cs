namespace BasicFacebookFeatures
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label imageSquareLabel;
            System.Windows.Forms.Label uRLLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
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
            this.buttonFindYourMatch = new System.Windows.Forms.Button();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxLikedPages = new System.Windows.Forms.PictureBox();
            this.checkBoxLikedPages = new System.Windows.Forms.CheckBox();
            this.labelFetchLikedPages = new System.Windows.Forms.Label();
            this.panelPosts = new System.Windows.Forms.Panel();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelLikedPages = new System.Windows.Forms.Panel();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.imageSquarePictureBox = new System.Windows.Forms.PictureBox();
            this.uRLLinkLabel = new System.Windows.Forms.LinkLabel();
            this.cityLabel1 = new System.Windows.Forms.Label();
            this.countryLabel1 = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            imageSquareLabel = new System.Windows.Forms.Label();
            uRLLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.panelLikedPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSquarePictureBox)).BeginInit();
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
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 131);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(278, 288);
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
            this.labelFriends.Location = new System.Drawing.Point(14, 466);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(201, 32);
            this.labelFriends.TabIndex = 55;
            this.labelFriends.Text = "Fetch Friends";
            // 
            // checkBoxFriends
            // 
            this.checkBoxFriends.AutoSize = true;
            this.checkBoxFriends.Location = new System.Drawing.Point(18, 505);
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
            this.listBoxFriends.Location = new System.Drawing.Point(18, 545);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(257, 324);
            this.listBoxFriends.TabIndex = 57;
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.Location = new System.Drawing.Point(286, 545);
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
            this.labelFetchAlbums.Location = new System.Drawing.Point(523, 466);
            this.labelFetchAlbums.Name = "labelFetchAlbums";
            this.labelFetchAlbums.Size = new System.Drawing.Size(200, 32);
            this.labelFetchAlbums.TabIndex = 59;
            this.labelFetchAlbums.Text = "Fetch Albums";
            // 
            // checkBoxAlbums
            // 
            this.checkBoxAlbums.AutoSize = true;
            this.checkBoxAlbums.Location = new System.Drawing.Point(529, 505);
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
            this.listBoxAlbums.Location = new System.Drawing.Point(529, 545);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(258, 324);
            this.listBoxAlbums.TabIndex = 61;
            this.listBoxAlbums.Click += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.Location = new System.Drawing.Point(800, 545);
            this.pictureBoxAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(235, 324);
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
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // pictureBoxLogoFacebook
            // 
            this.pictureBoxLogoFacebook.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoFacebook.Image")));
            this.pictureBoxLogoFacebook.Location = new System.Drawing.Point(1241, 11);
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
            this.buttonTrivia.Location = new System.Drawing.Point(1177, 151);
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
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(177, 29);
            this.checkBoxRememberMe.TabIndex = 68;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // buttonFindYourMatch
            // 
            this.buttonFindYourMatch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFindYourMatch.BackgroundImage")));
            this.buttonFindYourMatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFindYourMatch.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindYourMatch.Location = new System.Drawing.Point(1168, 399);
            this.buttonFindYourMatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFindYourMatch.Name = "buttonFindYourMatch";
            this.buttonFindYourMatch.Size = new System.Drawing.Size(206, 228);
            this.buttonFindYourMatch.TabIndex = 69;
            this.buttonFindYourMatch.Text = "Find Your Match";
            this.buttonFindYourMatch.UseVisualStyleBackColor = true;
            this.buttonFindYourMatch.Click += new System.EventHandler(this.buttonFindYourMatch_Click);
            // 
            // listBoxComments
            // 
            this.listBoxComments.DisplayMember = "Name";
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 20;
            this.listBoxComments.Location = new System.Drawing.Point(566, 13);
            this.listBoxComments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(290, 104);
            this.listBoxComments.TabIndex = 70;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.DataSource = this.pageBindingSource;
            this.listBoxLikedPages.DisplayMember = "Name";
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 20;
            this.listBoxLikedPages.Location = new System.Drawing.Point(746, 195);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(224, 184);
            this.listBoxLikedPages.TabIndex = 71;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // pictureBoxLikedPages
            // 
            this.pictureBoxLikedPages.BackColor = System.Drawing.Color.White;
            this.pictureBoxLikedPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLikedPages.Location = new System.Drawing.Point(929, -8);
            this.pictureBoxLikedPages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxLikedPages.Name = "pictureBoxLikedPages";
            this.pictureBoxLikedPages.Size = new System.Drawing.Size(146, 152);
            this.pictureBoxLikedPages.TabIndex = 73;
            this.pictureBoxLikedPages.TabStop = false;
            // 
            // checkBoxLikedPages
            // 
            this.checkBoxLikedPages.AutoSize = true;
            this.checkBoxLikedPages.Location = new System.Drawing.Point(746, 169);
            this.checkBoxLikedPages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxLikedPages.Name = "checkBoxLikedPages";
            this.checkBoxLikedPages.Size = new System.Drawing.Size(156, 24);
            this.checkBoxLikedPages.TabIndex = 74;
            this.checkBoxLikedPages.Text = "show liked pages";
            this.checkBoxLikedPages.UseVisualStyleBackColor = true;
            this.checkBoxLikedPages.CheckedChanged += new System.EventHandler(this.checkBoxLikedPages_CheckedChanged);
            // 
            // labelFetchLikedPages
            // 
            this.labelFetchLikedPages.AutoSize = true;
            this.labelFetchLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFetchLikedPages.Location = new System.Drawing.Point(740, 134);
            this.labelFetchLikedPages.Name = "labelFetchLikedPages";
            this.labelFetchLikedPages.Size = new System.Drawing.Size(267, 32);
            this.labelFetchLikedPages.TabIndex = 75;
            this.labelFetchLikedPages.Text = "Fetch Liked Pages";
            // 
            // panelPosts
            // 
            this.panelPosts.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelPosts.Location = new System.Drawing.Point(417, 270);
            this.panelPosts.Name = "panelPosts";
            this.panelPosts.Size = new System.Drawing.Size(239, 123);
            this.panelPosts.TabIndex = 78;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // panelLikedPages
            // 
            this.panelLikedPages.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelLikedPages.Controls.Add(cityLabel);
            this.panelLikedPages.Controls.Add(this.cityLabel1);
            this.panelLikedPages.Controls.Add(countryLabel);
            this.panelLikedPages.Controls.Add(this.countryLabel1);
            this.panelLikedPages.Controls.Add(descriptionLabel);
            this.panelLikedPages.Controls.Add(this.descriptionLabel1);
            this.panelLikedPages.Controls.Add(imageSquareLabel);
            this.panelLikedPages.Controls.Add(this.imageSquarePictureBox);
            this.panelLikedPages.Controls.Add(uRLLabel);
            this.panelLikedPages.Controls.Add(this.uRLLinkLabel);
            this.panelLikedPages.Location = new System.Drawing.Point(800, 283);
            this.panelLikedPages.Name = "panelLikedPages";
            this.panelLikedPages.Size = new System.Drawing.Size(355, 320);
            this.panelLikedPages.TabIndex = 79;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(25, 33);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.descriptionLabel1.Location = new System.Drawing.Point(156, 33);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(178, 23);
            this.descriptionLabel1.TabIndex = 1;
            this.descriptionLabel1.Text = "label1";
            // 
            // imageSquareLabel
            // 
            imageSquareLabel.AutoSize = true;
            imageSquareLabel.Location = new System.Drawing.Point(25, 100);
            imageSquareLabel.Name = "imageSquareLabel";
            imageSquareLabel.Size = new System.Drawing.Size(114, 20);
            imageSquareLabel.TabIndex = 2;
            imageSquareLabel.Text = "Image Square:";
            // 
            // imageSquarePictureBox
            // 
            this.imageSquarePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageSquare", true));
            this.imageSquarePictureBox.Location = new System.Drawing.Point(160, 59);
            this.imageSquarePictureBox.Name = "imageSquarePictureBox";
            this.imageSquarePictureBox.Size = new System.Drawing.Size(134, 121);
            this.imageSquarePictureBox.TabIndex = 3;
            this.imageSquarePictureBox.TabStop = false;
            // 
            // uRLLabel
            // 
            uRLLabel.AutoSize = true;
            uRLLabel.Location = new System.Drawing.Point(25, 195);
            uRLLabel.Name = "uRLLabel";
            uRLLabel.Size = new System.Drawing.Size(46, 20);
            uRLLabel.TabIndex = 4;
            uRLLabel.Text = "URL:";
            // 
            // uRLLinkLabel
            // 
            this.uRLLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "URL", true));
            this.uRLLinkLabel.Location = new System.Drawing.Point(67, 195);
            this.uRLLinkLabel.Name = "uRLLinkLabel";
            this.uRLLinkLabel.Size = new System.Drawing.Size(285, 23);
            this.uRLLinkLabel.TabIndex = 5;
            this.uRLLinkLabel.TabStop = true;
            this.uRLLinkLabel.Text = "linkLabel1";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(25, 240);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(39, 20);
            cityLabel.TabIndex = 6;
            cityLabel.Text = "City:";
            // 
            // cityLabel1
            // 
            this.cityLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Location.City", true));
            this.cityLabel1.Location = new System.Drawing.Point(156, 237);
            this.cityLabel1.Name = "cityLabel1";
            this.cityLabel1.Size = new System.Drawing.Size(100, 23);
            this.cityLabel1.TabIndex = 7;
            this.cityLabel1.Text = "label1";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(25, 283);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(68, 20);
            countryLabel.TabIndex = 8;
            countryLabel.Text = "Country:";
            // 
            // countryLabel1
            // 
            this.countryLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Location.Country", true));
            this.countryLabel1.Location = new System.Drawing.Point(160, 280);
            this.countryLabel1.Name = "countryLabel1";
            this.countryLabel1.Size = new System.Drawing.Size(100, 23);
            this.countryLabel1.TabIndex = 9;
            this.countryLabel1.Text = "label1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1386, 1011);
            this.Controls.Add(this.panelLikedPages);
            this.Controls.Add(this.panelPosts);
            this.Controls.Add(this.labelFetchLikedPages);
            this.Controls.Add(this.checkBoxLikedPages);
            this.Controls.Add(this.pictureBoxLikedPages);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.buttonFindYourMatch);
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
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.panelLikedPages.ResumeLayout(false);
            this.panelLikedPages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSquarePictureBox)).EndInit();
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
        private System.Windows.Forms.Button buttonFindYourMatch;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.PictureBox pictureBoxLikedPages;
        private System.Windows.Forms.CheckBox checkBoxLikedPages;
        private System.Windows.Forms.Label labelFetchLikedPages;
        private System.Windows.Forms.Panel panelPosts;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.Panel panelLikedPages;
        private System.Windows.Forms.Label cityLabel1;
        private System.Windows.Forms.Label countryLabel1;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.PictureBox imageSquarePictureBox;
        private System.Windows.Forms.LinkLabel uRLLinkLabel;
    }
}