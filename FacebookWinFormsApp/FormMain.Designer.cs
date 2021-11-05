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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHomePage = new System.Windows.Forms.TabPage();
            this.pictureBoxAlbums = new System.Windows.Forms.PictureBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.pictureBoxEvents = new System.Windows.Forms.PictureBox();
            this.pictureBoxGroups = new System.Windows.Forms.PictureBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.pictureBoxPages = new System.Windows.Forms.PictureBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.buttonFetchPages = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.pictureBoxFriendsProfile = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.labelPostsStatus = new System.Windows.Forms.Label();
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.tabNewsFeed = new System.Windows.Forms.TabPage();
            this.labelNewsFeed = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.listBoxNewsFeed = new System.Windows.Forms.ListBox();
            this.tabFeature1 = new System.Windows.Forms.TabPage();
            this.tabFeature2 = new System.Windows.Forms.TabPage();
            this.buttonAboutMe = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendsProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabNewsFeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHomePage);
            this.tabControl.Controls.Add(this.tabNewsFeed);
            this.tabControl.Controls.Add(this.tabFeature1);
            this.tabControl.Controls.Add(this.tabFeature2);
            this.tabControl.Location = new System.Drawing.Point(3, 1);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(895, 806);
            this.tabControl.TabIndex = 0;
            // 
            // tabHomePage
            // 
            this.tabHomePage.BackColor = System.Drawing.Color.Gainsboro;
            this.tabHomePage.Controls.Add(this.buttonSettings);
            this.tabHomePage.Controls.Add(this.buttonAboutMe);
            this.tabHomePage.Controls.Add(this.pictureBoxAlbums);
            this.tabHomePage.Controls.Add(this.listBoxAlbums);
            this.tabHomePage.Controls.Add(this.buttonFetchAlbums);
            this.tabHomePage.Controls.Add(this.pictureBoxEvents);
            this.tabHomePage.Controls.Add(this.pictureBoxGroups);
            this.tabHomePage.Controls.Add(this.listBoxGroups);
            this.tabHomePage.Controls.Add(this.buttonFetchGroups);
            this.tabHomePage.Controls.Add(this.pictureBoxPages);
            this.tabHomePage.Controls.Add(this.listBoxPages);
            this.tabHomePage.Controls.Add(this.buttonFetchPages);
            this.tabHomePage.Controls.Add(this.listBoxEvents);
            this.tabHomePage.Controls.Add(this.buttonFetchEvents);
            this.tabHomePage.Controls.Add(this.pictureBoxFriendsProfile);
            this.tabHomePage.Controls.Add(this.listBoxFriends);
            this.tabHomePage.Controls.Add(this.buttonFetchFriends);
            this.tabHomePage.Controls.Add(this.buttonPostStatus);
            this.tabHomePage.Controls.Add(this.labelPostsStatus);
            this.tabHomePage.Controls.Add(this.textBoxPostStatus);
            this.tabHomePage.Controls.Add(this.buttonFetchPosts);
            this.tabHomePage.Controls.Add(this.listBoxPosts);
            this.tabHomePage.Controls.Add(this.pictureBoxProfile);
            this.tabHomePage.Controls.Add(this.buttonLogout);
            this.tabHomePage.Controls.Add(this.buttonLogin);
            this.tabHomePage.Location = new System.Drawing.Point(4, 25);
            this.tabHomePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHomePage.Name = "tabHomePage";
            this.tabHomePage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHomePage.Size = new System.Drawing.Size(887, 777);
            this.tabHomePage.TabIndex = 0;
            this.tabHomePage.Text = "Home Page";
            this.tabHomePage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBoxAlbums
            // 
            this.pictureBoxAlbums.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxAlbums.Location = new System.Drawing.Point(124, 487);
            this.pictureBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAlbums.Name = "pictureBoxAlbums";
            this.pictureBoxAlbums.Size = new System.Drawing.Size(99, 84);
            this.pictureBoxAlbums.TabIndex = 96;
            this.pictureBoxAlbums.TabStop = false;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(14, 423);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(209, 148);
            this.listBoxAlbums.TabIndex = 95;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Enabled = false;
            this.buttonFetchAlbums.Location = new System.Drawing.Point(14, 396);
            this.buttonFetchAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(211, 23);
            this.buttonFetchAlbums.TabIndex = 94;
            this.buttonFetchAlbums.Text = "Fetch Albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // pictureBoxEvents
            // 
            this.pictureBoxEvents.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxEvents.Location = new System.Drawing.Point(342, 287);
            this.pictureBoxEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEvents.Name = "pictureBoxEvents";
            this.pictureBoxEvents.Size = new System.Drawing.Size(99, 84);
            this.pictureBoxEvents.TabIndex = 93;
            this.pictureBoxEvents.TabStop = false;
            // 
            // pictureBoxGroups
            // 
            this.pictureBoxGroups.Location = new System.Drawing.Point(557, 287);
            this.pictureBoxGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxGroups.Name = "pictureBoxGroups";
            this.pictureBoxGroups.Size = new System.Drawing.Size(100, 84);
            this.pictureBoxGroups.TabIndex = 92;
            this.pictureBoxGroups.TabStop = false;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(448, 223);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(209, 148);
            this.listBoxGroups.TabIndex = 91;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.Enabled = false;
            this.buttonFetchGroups.Location = new System.Drawing.Point(448, 195);
            this.buttonFetchGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(211, 23);
            this.buttonFetchGroups.TabIndex = 90;
            this.buttonFetchGroups.Text = "Fetch Groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = true;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // pictureBoxPages
            // 
            this.pictureBoxPages.Location = new System.Drawing.Point(771, 287);
            this.pictureBoxPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPages.Name = "pictureBoxPages";
            this.pictureBoxPages.Size = new System.Drawing.Size(100, 84);
            this.pictureBoxPages.TabIndex = 89;
            this.pictureBoxPages.TabStop = false;
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 16;
            this.listBoxPages.Location = new System.Drawing.Point(664, 223);
            this.listBoxPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(207, 148);
            this.listBoxPages.TabIndex = 88;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // buttonFetchPages
            // 
            this.buttonFetchPages.Enabled = false;
            this.buttonFetchPages.Location = new System.Drawing.Point(664, 195);
            this.buttonFetchPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchPages.Name = "buttonFetchPages";
            this.buttonFetchPages.Size = new System.Drawing.Size(206, 23);
            this.buttonFetchPages.TabIndex = 87;
            this.buttonFetchPages.Text = "Fetch Liked Pages";
            this.buttonFetchPages.UseVisualStyleBackColor = true;
            this.buttonFetchPages.Click += new System.EventHandler(this.buttonFetchPages_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(232, 223);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(209, 148);
            this.listBoxEvents.TabIndex = 86;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.Enabled = false;
            this.buttonFetchEvents.Location = new System.Drawing.Point(232, 195);
            this.buttonFetchEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(211, 23);
            this.buttonFetchEvents.TabIndex = 85;
            this.buttonFetchEvents.Text = "Fetch Events";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // pictureBoxFriendsProfile
            // 
            this.pictureBoxFriendsProfile.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxFriendsProfile.Location = new System.Drawing.Point(126, 287);
            this.pictureBoxFriendsProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFriendsProfile.Name = "pictureBoxFriendsProfile";
            this.pictureBoxFriendsProfile.Size = new System.Drawing.Size(99, 84);
            this.pictureBoxFriendsProfile.TabIndex = 76;
            this.pictureBoxFriendsProfile.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(16, 223);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(209, 148);
            this.listBoxFriends.TabIndex = 84;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Enabled = false;
            this.buttonFetchFriends.Location = new System.Drawing.Point(16, 195);
            this.buttonFetchFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(211, 23);
            this.buttonFetchFriends.TabIndex = 83;
            this.buttonFetchFriends.Text = "Fetch Friends List";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Enabled = false;
            this.buttonPostStatus.Location = new System.Drawing.Point(796, 42);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonPostStatus.TabIndex = 82;
            this.buttonPostStatus.Text = "Post!!";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // labelPostsStatus
            // 
            this.labelPostsStatus.AutoSize = true;
            this.labelPostsStatus.Location = new System.Drawing.Point(469, 16);
            this.labelPostsStatus.Name = "labelPostsStatus";
            this.labelPostsStatus.Size = new System.Drawing.Size(78, 16);
            this.labelPostsStatus.TabIndex = 81;
            this.labelPostsStatus.Text = "Post Status:";
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(587, 13);
            this.textBoxPostStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(284, 22);
            this.textBoxPostStatus.TabIndex = 80;
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Enabled = false;
            this.buttonFetchPosts.Location = new System.Drawing.Point(291, 42);
            this.buttonFetchPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(101, 23);
            this.buttonFetchPosts.TabIndex = 79;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(291, 71);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(582, 116);
            this.listBoxPosts.TabIndex = 78;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(69, 76);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(154, 111);
            this.pictureBoxProfile.TabIndex = 75;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(147, 10);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(123, 28);
            this.buttonLogout.TabIndex = 74;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(16, 10);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(123, 28);
            this.buttonLogin.TabIndex = 73;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // tabNewsFeed
            // 
            this.tabNewsFeed.Controls.Add(this.labelNewsFeed);
            this.tabNewsFeed.Controls.Add(this.buttonRefresh);
            this.tabNewsFeed.Controls.Add(this.listBoxNewsFeed);
            this.tabNewsFeed.Location = new System.Drawing.Point(4, 25);
            this.tabNewsFeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNewsFeed.Name = "tabNewsFeed";
            this.tabNewsFeed.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNewsFeed.Size = new System.Drawing.Size(887, 777);
            this.tabNewsFeed.TabIndex = 1;
            this.tabNewsFeed.Text = "News Feed";
            this.tabNewsFeed.UseVisualStyleBackColor = true;
            this.tabNewsFeed.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // labelNewsFeed
            // 
            this.labelNewsFeed.AutoSize = true;
            this.labelNewsFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNewsFeed.Location = new System.Drawing.Point(66, 23);
            this.labelNewsFeed.Name = "labelNewsFeed";
            this.labelNewsFeed.Size = new System.Drawing.Size(178, 37);
            this.labelNewsFeed.TabIndex = 3;
            this.labelNewsFeed.Text = "News Feed";
            this.labelNewsFeed.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Enabled = false;
            this.buttonRefresh.Location = new System.Drawing.Point(317, 31);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 29);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Load";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // listBoxNewsFeed
            // 
            this.listBoxNewsFeed.FormattingEnabled = true;
            this.listBoxNewsFeed.ItemHeight = 16;
            this.listBoxNewsFeed.Location = new System.Drawing.Point(73, 74);
            this.listBoxNewsFeed.Name = "listBoxNewsFeed";
            this.listBoxNewsFeed.Size = new System.Drawing.Size(720, 404);
            this.listBoxNewsFeed.TabIndex = 0;
            // 
            // tabFeature1
            // 
            this.tabFeature1.Location = new System.Drawing.Point(4, 25);
            this.tabFeature1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFeature1.Name = "tabFeature1";
            this.tabFeature1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFeature1.Size = new System.Drawing.Size(887, 777);
            this.tabFeature1.TabIndex = 2;
            this.tabFeature1.Text = "Feature 1";
            this.tabFeature1.UseVisualStyleBackColor = true;
            // 
            // tabFeature2
            // 
            this.tabFeature2.Location = new System.Drawing.Point(4, 25);
            this.tabFeature2.Name = "tabFeature2";
            this.tabFeature2.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeature2.Size = new System.Drawing.Size(887, 777);
            this.tabFeature2.TabIndex = 3;
            this.tabFeature2.Text = "Feature 2";
            this.tabFeature2.UseVisualStyleBackColor = true;
            // 
            // buttonAboutMe
            // 
            this.buttonAboutMe.Enabled = false;
            this.buttonAboutMe.Location = new System.Drawing.Point(757, 535);
            this.buttonAboutMe.Name = "buttonAboutMe";
            this.buttonAboutMe.Size = new System.Drawing.Size(113, 36);
            this.buttonAboutMe.TabIndex = 97;
            this.buttonAboutMe.Text = "About Me!";
            this.buttonAboutMe.UseVisualStyleBackColor = true;
            this.buttonAboutMe.Click += new System.EventHandler(this.buttonAboutMe_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(16, 42);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(254, 28);
            this.buttonSettings.TabIndex = 98;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 615);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook App";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl.ResumeLayout(false);
            this.tabHomePage.ResumeLayout(false);
            this.tabHomePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendsProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabNewsFeed.ResumeLayout(false);
            this.tabNewsFeed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHomePage;
        private System.Windows.Forms.PictureBox pictureBoxEvents;
        private System.Windows.Forms.PictureBox pictureBoxGroups;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.PictureBox pictureBoxPages;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.Button buttonFetchPages;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.PictureBox pictureBoxFriendsProfile;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.Label labelPostsStatus;
        private System.Windows.Forms.TextBox textBoxPostStatus;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TabPage tabNewsFeed;
        private System.Windows.Forms.TabPage tabFeature1;
        private System.Windows.Forms.ListBox listBoxNewsFeed;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelNewsFeed;
        private System.Windows.Forms.TabPage tabFeature2;
        private System.Windows.Forms.PictureBox pictureBoxAlbums;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.Button buttonAboutMe;
        private System.Windows.Forms.Button buttonSettings;
    }
}

