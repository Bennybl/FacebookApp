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
        }

        private void FormPage_Load(object sender, EventArgs e)
        {

        }
    }
}
