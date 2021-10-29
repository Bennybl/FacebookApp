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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.labelPostsStatus = new System.Windows.Forms.Label();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.listBoxFetchFriends = new System.Windows.Forms.ListBox();
            this.pictureBoxFriendsProfile = new System.Windows.Forms.PictureBox();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.listBoxFetchEvents = new System.Windows.Forms.ListBox();
            this.pictureBoxEvents = new System.Windows.Forms.PictureBox();
            this.pictureBoxGroups = new System.Windows.Forms.PictureBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.pictureBoxPages = new System.Windows.Forms.PictureBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.buttonPages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendsProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPages)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(16, 15);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(123, 28);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(147, 15);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(123, 28);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 101);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(16, 51);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(254, 28);
            this.buttonSettings.TabIndex = 54;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(290, 70);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(581, 116);
            this.listBoxPosts.TabIndex = 55;
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(290, 41);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(101, 23);
            this.buttonFetchPosts.TabIndex = 56;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(587, 12);
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(284, 22);
            this.textBoxPostStatus.TabIndex = 57;
            // 
            // labelPostsStatus
            // 
            this.labelPostsStatus.AutoSize = true;
            this.labelPostsStatus.Location = new System.Drawing.Point(506, 15);
            this.labelPostsStatus.Name = "labelPostsStatus";
            this.labelPostsStatus.Size = new System.Drawing.Size(78, 16);
            this.labelPostsStatus.TabIndex = 58;
            this.labelPostsStatus.Text = "Post Status:";
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(796, 41);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonPostStatus.TabIndex = 59;
            this.buttonPostStatus.Text = "Post!!";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Location = new System.Drawing.Point(16, 194);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(210, 23);
            this.buttonFetchFriends.TabIndex = 60;
            this.buttonFetchFriends.Text = "Fetch Friends List";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            // 
            // listBoxFetchFriends
            // 
            this.listBoxFetchFriends.FormattingEnabled = true;
            this.listBoxFetchFriends.ItemHeight = 16;
            this.listBoxFetchFriends.Location = new System.Drawing.Point(16, 223);
            this.listBoxFetchFriends.Name = "listBoxFetchFriends";
            this.listBoxFetchFriends.Size = new System.Drawing.Size(210, 148);
            this.listBoxFetchFriends.TabIndex = 61;
            // 
            // pictureBoxFriendsProfile
            // 
            this.pictureBoxFriendsProfile.Location = new System.Drawing.Point(126, 302);
            this.pictureBoxFriendsProfile.Name = "pictureBoxFriendsProfile";
            this.pictureBoxFriendsProfile.Size = new System.Drawing.Size(100, 69);
            this.pictureBoxFriendsProfile.TabIndex = 62;
            this.pictureBoxFriendsProfile.TabStop = false;
            // 
            // buttonEvents
            // 
            this.buttonEvents.Location = new System.Drawing.Point(232, 194);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(210, 23);
            this.buttonEvents.TabIndex = 63;
            this.buttonEvents.Text = "Fetch Events";
            this.buttonEvents.UseVisualStyleBackColor = true;
            // 
            // listBoxFetchEvents
            // 
            this.listBoxFetchEvents.FormattingEnabled = true;
            this.listBoxFetchEvents.ItemHeight = 16;
            this.listBoxFetchEvents.Location = new System.Drawing.Point(232, 223);
            this.listBoxFetchEvents.Name = "listBoxFetchEvents";
            this.listBoxFetchEvents.Size = new System.Drawing.Size(210, 148);
            this.listBoxFetchEvents.TabIndex = 64;
            // 
            // pictureBoxEvents
            // 
            this.pictureBoxEvents.Location = new System.Drawing.Point(342, 302);
            this.pictureBoxEvents.Name = "pictureBoxEvents";
            this.pictureBoxEvents.Size = new System.Drawing.Size(100, 69);
            this.pictureBoxEvents.TabIndex = 65;
            this.pictureBoxEvents.TabStop = false;
            // 
            // pictureBoxGroups
            // 
            this.pictureBoxGroups.Location = new System.Drawing.Point(558, 302);
            this.pictureBoxGroups.Name = "pictureBoxGroups";
            this.pictureBoxGroups.Size = new System.Drawing.Size(100, 69);
            this.pictureBoxGroups.TabIndex = 71;
            this.pictureBoxGroups.TabStop = false;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(448, 223);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(210, 148);
            this.listBoxGroups.TabIndex = 70;
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.Location = new System.Drawing.Point(448, 194);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(210, 23);
            this.buttonFetchGroups.TabIndex = 69;
            this.buttonFetchGroups.Text = "Fetch Groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPages
            // 
            this.pictureBoxPages.Location = new System.Drawing.Point(771, 302);
            this.pictureBoxPages.Name = "pictureBoxPages";
            this.pictureBoxPages.Size = new System.Drawing.Size(100, 69);
            this.pictureBoxPages.TabIndex = 68;
            this.pictureBoxPages.TabStop = false;
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 16;
            this.listBoxPages.Location = new System.Drawing.Point(664, 223);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(207, 148);
            this.listBoxPages.TabIndex = 67;
            // 
            // buttonPages
            // 
            this.buttonPages.Location = new System.Drawing.Point(664, 194);
            this.buttonPages.Name = "buttonPages";
            this.buttonPages.Size = new System.Drawing.Size(207, 23);
            this.buttonPages.TabIndex = 66;
            this.buttonPages.Text = "Fetch Liked Pages";
            this.buttonPages.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 809);
            this.Controls.Add(this.pictureBoxGroups);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.buttonFetchGroups);
            this.Controls.Add(this.pictureBoxPages);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.buttonPages);
            this.Controls.Add(this.pictureBoxEvents);
            this.Controls.Add(this.listBoxFetchEvents);
            this.Controls.Add(this.buttonEvents);
            this.Controls.Add(this.pictureBoxFriendsProfile);
            this.Controls.Add(this.listBoxFetchFriends);
            this.Controls.Add(this.buttonFetchFriends);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.labelPostsStatus);
            this.Controls.Add(this.textBoxPostStatus);
            this.Controls.Add(this.buttonFetchPosts);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendsProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.TextBox textBoxPostStatus;
        private System.Windows.Forms.Label labelPostsStatus;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.ListBox listBoxFetchFriends;
        private System.Windows.Forms.PictureBox pictureBoxFriendsProfile;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.ListBox listBoxFetchEvents;
        private System.Windows.Forms.PictureBox pictureBoxEvents;
        private System.Windows.Forms.PictureBox pictureBoxGroups;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.PictureBox pictureBoxPages;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.Button buttonPages;
    }
}

