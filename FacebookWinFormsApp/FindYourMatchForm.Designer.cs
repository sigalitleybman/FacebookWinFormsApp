namespace BasicFacebookFeatures
{
    partial class FindYourMatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindYourMatchForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonCheckAnswers = new System.Windows.Forms.Button();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelPreferences = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.checkedListBoxGender = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxAge = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxArea = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Teal;
            this.labelTitle.Location = new System.Drawing.Point(256, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(260, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Find Your Match";
            // 
            // buttonCheckAnswers
            // 
            this.buttonCheckAnswers.BackColor = System.Drawing.Color.MistyRose;
            this.buttonCheckAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckAnswers.ForeColor = System.Drawing.Color.Red;
            this.buttonCheckAnswers.Location = new System.Drawing.Point(326, 390);
            this.buttonCheckAnswers.Name = "buttonCheckAnswers";
            this.buttonCheckAnswers.Size = new System.Drawing.Size(129, 50);
            this.buttonCheckAnswers.TabIndex = 12;
            this.buttonCheckAnswers.Text = "CHECK";
            this.buttonCheckAnswers.UseVisualStyleBackColor = false;
            this.buttonCheckAnswers.Click += new System.EventHandler(this.buttonCheckAnswers_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(73, 164);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(83, 25);
            this.labelGender.TabIndex = 13;
            this.labelGender.Text = "Gender";
            // 
            // labelPreferences
            // 
            this.labelPreferences.AutoSize = true;
            this.labelPreferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreferences.Location = new System.Drawing.Point(238, 81);
            this.labelPreferences.Name = "labelPreferences";
            this.labelPreferences.Size = new System.Drawing.Size(288, 25);
            this.labelPreferences.TabIndex = 14;
            this.labelPreferences.Text = "What Are Your Preferences?";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(376, 164);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(51, 25);
            this.labelAge.TabIndex = 15;
            this.labelAge.Text = "Age";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(675, 164);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(58, 25);
            this.labelArea.TabIndex = 16;
            this.labelArea.Text = "Area";
            // 
            // checkedListBoxGender
            // 
            this.checkedListBoxGender.FormattingEnabled = true;
            this.checkedListBoxGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.checkedListBoxGender.Location = new System.Drawing.Point(66, 202);
            this.checkedListBoxGender.Name = "checkedListBoxGender";
            this.checkedListBoxGender.Size = new System.Drawing.Size(120, 55);
            this.checkedListBoxGender.TabIndex = 25;
            this.checkedListBoxGender.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxGender_SelectedIndexChanged);
            // 
            // checkedListBoxAge
            // 
            this.checkedListBoxAge.FormattingEnabled = true;
            this.checkedListBoxAge.Items.AddRange(new object[] {
            "20 - 29",
            "30 - 39",
            "40 - 49"});
            this.checkedListBoxAge.Location = new System.Drawing.Point(345, 202);
            this.checkedListBoxAge.Name = "checkedListBoxAge";
            this.checkedListBoxAge.Size = new System.Drawing.Size(120, 72);
            this.checkedListBoxAge.TabIndex = 26;
            this.checkedListBoxAge.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxAge_SelectedIndexChanged_1);
            // 
            // checkedListBoxArea
            // 
            this.checkedListBoxArea.FormattingEnabled = true;
            this.checkedListBoxArea.Items.AddRange(new object[] {
            "North",
            "Center",
            "South"});
            this.checkedListBoxArea.Location = new System.Drawing.Point(640, 202);
            this.checkedListBoxArea.Name = "checkedListBoxArea";
            this.checkedListBoxArea.Size = new System.Drawing.Size(120, 72);
            this.checkedListBoxArea.TabIndex = 27;
            this.checkedListBoxArea.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxArea_SelectedIndexChanged_1);
            // 
            // FindYourMatchForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 464);
            this.Controls.Add(this.checkedListBoxArea);
            this.Controls.Add(this.checkedListBoxAge);
            this.Controls.Add(this.checkedListBoxGender);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelPreferences);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.buttonCheckAnswers);
            this.Controls.Add(this.labelTitle);
            this.Name = "FindYourMatchForm";
            this.Text = "Find Your Match";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonCheckAnswers;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelPreferences;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.CheckedListBox checkedListBoxGender;
        private System.Windows.Forms.CheckedListBox checkedListBoxAge;
        private System.Windows.Forms.CheckedListBox checkedListBoxArea;
    }
}