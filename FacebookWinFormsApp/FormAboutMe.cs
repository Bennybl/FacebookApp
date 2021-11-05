using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormAboutMe : Form
    {
        User m_LoggedInUser;
        public FormAboutMe(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            textBoxBirthday.Text = m_LoggedInUser.Birthday == null ? "Data Unavailable" : m_LoggedInUser.Birthday;
            textBoxEducation.Text = m_LoggedInUser.Educations == null ? "Data Unavailable" : m_LoggedInUser.Educations[0].School.Name;
            textBoxEmail.Text = m_LoggedInUser.Email == null ? "Data Unavailable" : m_LoggedInUser.Email;
            textBoxRelationship.Text = m_LoggedInUser.RelationshipStatus == null ? "Data Unavailable" : m_LoggedInUser.RelationshipStatus.ToString();
            textBoxHometown.Text = m_LoggedInUser.Hometown == null ? "Data Unavavileable" : m_LoggedInUser.Hometown.Name;
            labelUserName.Text = m_LoggedInUser.Name;
            pictureBoxUser.LoadAsync(m_LoggedInUser.PictureNormalURL);
        }

        private void FormAboutMe_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxUser_Click(object sender, EventArgs e)
        {

        }
    }
}
