
namespace BasicFacebookFeatures
{
    partial class FormEvent
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
            this.labelEventName = new System.Windows.Forms.Label();
            this.labelAttending = new System.Windows.Forms.Label();
            this.listBoxAttending = new System.Windows.Forms.ListBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEventName.Location = new System.Drawing.Point(22, 34);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(208, 39);
            this.labelEventName.TabIndex = 0;
            this.labelEventName.Text = "Event Name";
            // 
            // labelAttending
            // 
            this.labelAttending.AutoSize = true;
            this.labelAttending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAttending.Location = new System.Drawing.Point(26, 302);
            this.labelAttending.Name = "labelAttending";
            this.labelAttending.Size = new System.Drawing.Size(117, 20);
            this.labelAttending.TabIndex = 1;
            this.labelAttending.Text = "AttendingLabel";
            this.labelAttending.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxAttending
            // 
            this.listBoxAttending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxAttending.FormattingEnabled = true;
            this.listBoxAttending.ItemHeight = 20;
            this.listBoxAttending.Location = new System.Drawing.Point(29, 340);
            this.listBoxAttending.Name = "listBoxAttending";
            this.listBoxAttending.Size = new System.Drawing.Size(201, 84);
            this.listBoxAttending.TabIndex = 3;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTime.Location = new System.Drawing.Point(26, 196);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(82, 20);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "TimeLabel";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLocation.Location = new System.Drawing.Point(25, 231);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(109, 20);
            this.labelLocation.TabIndex = 5;
            this.labelLocation.Text = "LocationLabel";
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelOwner.Location = new System.Drawing.Point(26, 266);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(94, 20);
            this.labelOwner.TabIndex = 7;
            this.labelOwner.Text = "OwnerLabel";
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Location = new System.Drawing.Point(29, 76);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(161, 117);
            this.pictureBoxEvent.TabIndex = 8;
            this.pictureBoxEvent.TabStop = false;
            // 
            // FormEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 479);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.listBoxAttending);
            this.Controls.Add(this.labelAttending);
            this.Controls.Add(this.labelEventName);
            this.Name = "FormEvent";
            this.Text = "Formevent";
            this.Load += new System.EventHandler(this.Formevent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.Label labelAttending;
        private System.Windows.Forms.ListBox listBoxAttending;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
    }
}