using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormPage : Form
    {
        Page m_Page;
        public FormPage(Page i_Page)
        {
            InitializeComponent();
            m_Page = i_Page;
            if(m_Page.PictureNormalURL != null)
            {
                pictureBoxPage.LoadAsync(m_Page.PictureNormalURL);
            }
            labelPageName.Text = m_Page.Name.ToString();
            string category = m_Page.Category == null ? "Unavailable" : m_Page.Category;
            labelCategory.Text = $"Category: {category}";
            string description = m_Page.Description == null ? "Unavailable" : m_Page.Description;
            labelDescription.Text = $"Description: {description}";
            string likes = m_Page.LikesCount == null ? "Unavaliable" : m_Page.LikesCount.ToString();
            labelLikes.Text = $"Likes: {likes}";
            addPosts();
        }


        private void FormPage_Load(object sender, EventArgs e)
        {

        }

        private void addPosts()
        {
            foreach(Post post in m_Page.Posts)
            {
                listBoxPosts.Items.Add(post);
            }
        }
    }
}
