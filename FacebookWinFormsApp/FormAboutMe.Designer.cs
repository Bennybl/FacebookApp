
namespace BasicFacebookFeatures
{
    partial class FormAboutMe
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelEducation = new System.Windows.Forms.Label();
            this.labelRelationship = new System.Windows.Forms.Label();
            this.labelHometown = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.textBoxEducation = new System.Windows.Forms.TextBox();
            this.textBoxHometown = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxRelationship = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserName.Location = new System.Drawing.Point(26, 26);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(206, 42);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User Name";
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Location = new System.Drawing.Point(33, 85);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(187, 146);
            this.pictureBoxUser.TabIndex = 1;
            this.pictureBoxUser.TabStop = false;
            this.pictureBoxUser.Click += new System.EventHandler(this.pictureBoxUser_Click);
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(368, 79);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(60, 16);
            this.labelBirthday.TabIndex = 2;
            this.labelBirthday.Text = "Birthday:";
            // 
            // labelEducation
            // 
            this.labelEducation.AutoSize = true;
            this.labelEducation.Location = new System.Drawing.Point(357, 118);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(71, 16);
            this.labelEducation.TabIndex = 3;
            this.labelEducation.Text = "Education:";
            this.labelEducation.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelRelationship
            // 
            this.labelRelationship.AutoSize = true;
            this.labelRelationship.Location = new System.Drawing.Point(331, 229);
            this.labelRelationship.Name = "labelRelationship";
            this.labelRelationship.Size = new System.Drawing.Size(126, 16);
            this.labelRelationship.TabIndex = 4;
            this.labelRelationship.Text = "Relationship Status:";
            // 
            // labelHometown
            // 
            this.labelHometown.AutoSize = true;
            this.labelHometown.Location = new System.Drawing.Point(357, 155);
            this.labelHometown.Name = "labelHometown";
            this.labelHometown.Size = new System.Drawing.Size(75, 16);
            this.labelHometown.TabIndex = 5;
            this.labelHometown.Text = "Hometown:";
            this.labelHometown.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(376, 193);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 16);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Location = new System.Drawing.Point(488, 76);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.Size = new System.Drawing.Size(141, 22);
            this.textBoxBirthday.TabIndex = 7;
            // 
            // textBoxEducation
            // 
            this.textBoxEducation.Location = new System.Drawing.Point(488, 112);
            this.textBoxEducation.Name = "textBoxEducation";
            this.textBoxEducation.Size = new System.Drawing.Size(141, 22);
            this.textBoxEducation.TabIndex = 8;
            // 
            // textBoxHometown
            // 
            this.textBoxHometown.Location = new System.Drawing.Point(488, 149);
            this.textBoxHometown.Name = "textBoxHometown";
            this.textBoxHometown.Size = new System.Drawing.Size(141, 22);
            this.textBoxHometown.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(488, 187);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(141, 22);
            this.textBoxEmail.TabIndex = 10;
            // 
            // textBoxRelationship
            // 
            this.textBoxRelationship.Location = new System.Drawing.Point(488, 226);
            this.textBoxRelationship.Name = "textBoxRelationship";
            this.textBoxRelationship.Size = new System.Drawing.Size(141, 22);
            this.textBoxRelationship.TabIndex = 11;
            // 
            // FormAboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 330);
            this.Controls.Add(this.textBoxRelationship);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxHometown);
            this.Controls.Add(this.textBoxEducation);
            this.Controls.Add(this.textBoxBirthday);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelHometown);
            this.Controls.Add(this.labelRelationship);
            this.Controls.Add(this.labelEducation);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.labelUserName);
            this.Name = "FormAboutMe";
            this.Text = "FormAboutMe";
            this.Load += new System.EventHandler(this.FormAboutMe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelEducation;
        private System.Windows.Forms.Label labelRelationship;
        private System.Windows.Forms.Label labelHometown;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.TextBox textBoxEducation;
        private System.Windows.Forms.TextBox textBoxHometown;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxRelationship;
    }
}