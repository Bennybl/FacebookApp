
namespace BasicFacebookFeatures
{
    partial class FormPage
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
            if(disposing && (components != null))
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
            this.labelPageName = new System.Windows.Forms.Label();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelLikes = new System.Windows.Forms.Label();
            this.labelPosts = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPageName
            // 
            this.labelPageName.AutoSize = true;
            this.labelPageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPageName.Location = new System.Drawing.Point(25, 32);
            this.labelPageName.Name = "labelPageName";
            this.labelPageName.Size = new System.Drawing.Size(199, 39);
            this.labelPageName.TabIndex = 1;
            this.labelPageName.Text = "Page Name";
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.Location = new System.Drawing.Point(32, 74);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(161, 117);
            this.pictureBoxPage.TabIndex = 9;
            this.pictureBoxPage.TabStop = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescription.Location = new System.Drawing.Point(38, 234);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(93, 20);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCategory.Location = new System.Drawing.Point(38, 203);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(77, 20);
            this.labelCategory.TabIndex = 11;
            this.labelCategory.Text = "Category:";
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikes.Location = new System.Drawing.Point(38, 266);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(50, 20);
            this.labelLikes.TabIndex = 12;
            this.labelLikes.Text = "Likes:";
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPosts.Location = new System.Drawing.Point(38, 297);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(53, 20);
            this.labelPosts.TabIndex = 13;
            this.labelPosts.Text = "Posts:";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(32, 320);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(245, 84);
            this.listBoxPosts.TabIndex = 14;
            // 
            // FormPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 425);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.labelLikes);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.pictureBoxPage);
            this.Controls.Add(this.labelPageName);
            this.Name = "FormPage";
            this.Text = "FormPage";
            this.Load += new System.EventHandler(this.FormPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPageName;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
    }
}