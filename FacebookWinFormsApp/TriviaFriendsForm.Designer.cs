﻿
namespace BasicFacebookFeatures
{
    partial class TriviaFriendsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriviaFriendsForm));
            this.pictureBoxTriviaLogo = new System.Windows.Forms.PictureBox();
            this.labelChooseFriend = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelDescriptionQuestion = new System.Windows.Forms.Label();
            this.radioButtonFirstAnswer = new System.Windows.Forms.RadioButton();
            this.radioButtonSecondAnswer = new System.Windows.Forms.RadioButton();
            this.radioButtonThirdAnswer = new System.Windows.Forms.RadioButton();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.pictureBoxNextQuestion = new System.Windows.Forms.PictureBox();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.listBoxFriend = new System.Windows.Forms.ListBox();
            this.checkBoxChangeFriend = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriviaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNextQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTriviaLogo
            // 
            this.pictureBoxTriviaLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTriviaLogo.Image")));
            this.pictureBoxTriviaLogo.Location = new System.Drawing.Point(291, 12);
            this.pictureBoxTriviaLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxTriviaLogo.Name = "pictureBoxTriviaLogo";
            this.pictureBoxTriviaLogo.Size = new System.Drawing.Size(386, 88);
            this.pictureBoxTriviaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTriviaLogo.TabIndex = 0;
            this.pictureBoxTriviaLogo.TabStop = false;
            // 
            // labelChooseFriend
            // 
            this.labelChooseFriend.AutoSize = true;
            this.labelChooseFriend.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChooseFriend.ForeColor = System.Drawing.Color.Purple;
            this.labelChooseFriend.Location = new System.Drawing.Point(39, 156);
            this.labelChooseFriend.Name = "labelChooseFriend";
            this.labelChooseFriend.Size = new System.Drawing.Size(199, 28);
            this.labelChooseFriend.TabIndex = 1;
            this.labelChooseFriend.Text = "Choose Friend";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelQuestion.ForeColor = System.Drawing.Color.Purple;
            this.labelQuestion.Location = new System.Drawing.Point(349, 156);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(131, 28);
            this.labelQuestion.TabIndex = 4;
            this.labelQuestion.Text = "Question";
            // 
            // labelDescriptionQuestion
            // 
            this.labelDescriptionQuestion.AutoSize = true;
            this.labelDescriptionQuestion.Location = new System.Drawing.Point(350, 195);
            this.labelDescriptionQuestion.Name = "labelDescriptionQuestion";
            this.labelDescriptionQuestion.Size = new System.Drawing.Size(51, 20);
            this.labelDescriptionQuestion.TabIndex = 5;
            this.labelDescriptionQuestion.Text = "label1";
            this.labelDescriptionQuestion.Visible = false;
            // 
            // radioButtonFirstAnswer
            // 
            this.radioButtonFirstAnswer.AutoSize = true;
            this.radioButtonFirstAnswer.Location = new System.Drawing.Point(354, 249);
            this.radioButtonFirstAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFirstAnswer.Name = "radioButtonFirstAnswer";
            this.radioButtonFirstAnswer.Size = new System.Drawing.Size(21, 20);
            this.radioButtonFirstAnswer.TabIndex = 6;
            this.radioButtonFirstAnswer.TabStop = true;
            this.radioButtonFirstAnswer.UseVisualStyleBackColor = true;
            // 
            // radioButtonSecondAnswer
            // 
            this.radioButtonSecondAnswer.AutoSize = true;
            this.radioButtonSecondAnswer.Location = new System.Drawing.Point(354, 311);
            this.radioButtonSecondAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonSecondAnswer.Name = "radioButtonSecondAnswer";
            this.radioButtonSecondAnswer.Size = new System.Drawing.Size(21, 20);
            this.radioButtonSecondAnswer.TabIndex = 7;
            this.radioButtonSecondAnswer.TabStop = true;
            this.radioButtonSecondAnswer.UseVisualStyleBackColor = true;
            // 
            // radioButtonThirdAnswer
            // 
            this.radioButtonThirdAnswer.AutoSize = true;
            this.radioButtonThirdAnswer.Location = new System.Drawing.Point(354, 364);
            this.radioButtonThirdAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonThirdAnswer.Name = "radioButtonThirdAnswer";
            this.radioButtonThirdAnswer.Size = new System.Drawing.Size(21, 20);
            this.radioButtonThirdAnswer.TabIndex = 8;
            this.radioButtonThirdAnswer.TabStop = true;
            this.radioButtonThirdAnswer.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSubmit.Location = new System.Drawing.Point(354, 422);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(111, 42);
            this.buttonSubmit.TabIndex = 9;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.CheckIfTheAnswerIsCorrect);
            // 
            // pictureBoxNextQuestion
            // 
            this.pictureBoxNextQuestion.Enabled = false;
            this.pictureBoxNextQuestion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNextQuestion.Image")));
            this.pictureBoxNextQuestion.Location = new System.Drawing.Point(611, 374);
            this.pictureBoxNextQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxNextQuestion.Name = "pictureBoxNextQuestion";
            this.pictureBoxNextQuestion.Size = new System.Drawing.Size(392, 236);
            this.pictureBoxNextQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNextQuestion.TabIndex = 10;
            this.pictureBoxNextQuestion.TabStop = false;
            this.pictureBoxNextQuestion.Visible = false;
            this.pictureBoxNextQuestion.Click += new System.EventHandler(this.pictureBoxNextQuestion_Click);
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFeedback.ForeColor = System.Drawing.Color.Red;
            this.labelFeedback.Location = new System.Drawing.Point(755, 270);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(70, 25);
            this.labelFeedback.TabIndex = 12;
            this.labelFeedback.Text = "label1";
            this.labelFeedback.Visible = false;
            // 
            // listBoxFriend
            // 
            this.listBoxFriend.FormattingEnabled = true;
            this.listBoxFriend.ItemHeight = 20;
            this.listBoxFriend.Location = new System.Drawing.Point(28, 206);
            this.listBoxFriend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxFriend.Name = "listBoxFriend";
            this.listBoxFriend.Size = new System.Drawing.Size(262, 264);
            this.listBoxFriend.TabIndex = 13;
            this.listBoxFriend.Click += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // checkBoxChangeFriend
            // 
            this.checkBoxChangeFriend.AutoSize = true;
            this.checkBoxChangeFriend.Enabled = false;
            this.checkBoxChangeFriend.Location = new System.Drawing.Point(47, 532);
            this.checkBoxChangeFriend.Name = "checkBoxChangeFriend";
            this.checkBoxChangeFriend.Size = new System.Drawing.Size(212, 24);
            this.checkBoxChangeFriend.TabIndex = 14;
            this.checkBoxChangeFriend.Text = "Change to another friend";
            this.checkBoxChangeFriend.UseVisualStyleBackColor = true;
            this.checkBoxChangeFriend.CheckedChanged += new System.EventHandler(this.checkBoxChangeFriend_CheckedChanged);
            // 
            // TriviaFriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1034, 652);
            this.Controls.Add(this.checkBoxChangeFriend);
            this.Controls.Add(this.listBoxFriend);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.pictureBoxNextQuestion);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.radioButtonThirdAnswer);
            this.Controls.Add(this.radioButtonSecondAnswer);
            this.Controls.Add(this.radioButtonFirstAnswer);
            this.Controls.Add(this.labelDescriptionQuestion);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelChooseFriend);
            this.Controls.Add(this.pictureBoxTriviaLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TriviaFriendsForm";
            this.Text = "Trivia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriviaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNextQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTriviaLogo;
        private System.Windows.Forms.Label labelChooseFriend;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelDescriptionQuestion;
        private System.Windows.Forms.RadioButton radioButtonFirstAnswer;
        private System.Windows.Forms.RadioButton radioButtonSecondAnswer;
        private System.Windows.Forms.RadioButton radioButtonThirdAnswer;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.PictureBox pictureBoxNextQuestion;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.ListBox listBoxFriend;
        private System.Windows.Forms.CheckBox checkBoxChangeFriend;
    }
}