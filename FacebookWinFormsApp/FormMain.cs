using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        User m_LoggedInUser;
        LoginResult m_LoginResult;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            m_LoginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own) - Replaced
                    "169144092019421", 
                    /// requested permissions:
					"email",
                    "public_profile",
                    "user_likes"
                    /// add any relevant permissions
                    );

            if(!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
		}

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = "Name";

            try
            {
                foreach(Group group in m_LoggedInUser.Groups)
                {
                    listBoxGroups.Items.Add(group);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("The logged-in users has no groups.");
            }
        }

        private void buttonPages_Click(object sender, EventArgs e)
        {
            listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = "Name";
            try
            {
                foreach(Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxPages.Items.Add(page);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(listBoxPages.Items.Count == 0)
            {
                MessageBox.Show("The logged-in user has no liked pages");
            }
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxPages.SelectedItem as Page;
                pictureBoxPages.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        private void pictureBoxPages_Click(object sender, EventArgs e)
        {
 
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxGroups.SelectedItems.Count == 1)
            {
                Group selectedGroup = listBoxGroups.SelectedItem as Group;
                pictureBoxGroups.LoadAsync(selectedGroup.PictureNormalURL);
            }
        }
    }
}
