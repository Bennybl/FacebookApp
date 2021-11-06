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

namespace BasicFacebookFeatures
{
    public partial class FormEvent : Form
    {
        Event m_Event;
        public FormEvent(Event i_Event)
        {
            InitializeComponent();
            m_Event = i_Event;
            DateTime start = (DateTime) i_Event.StartTime;
            DateTime end = (DateTime)i_Event.EndTime;
            labelEventName.Text = i_Event.Name.ToString();
            labelTime.Text = $"{start.DayOfWeek} the {start.Day}/{start.Month}/{start.Year} From {start.Hour}:{start.Minute} to {end.Hour}:{end.Minute}";
            labelLocation.Text = $"Location:{i_Event.Venue.Name}, {i_Event.Place.Location.City}, {i_Event.Place.Location.Country}.";
            labelOwner.Text = i_Event.Owner == null ? "Owner Unavailable" : i_Event.Owner.Name;
            labelAttending.Text = $"Attending: {i_Event.AttendingCount}";
            retriveAttending();
            
        }

        private void retriveAttending()
        {
            try
            {
                foreach(User user in m_Event.AttendingUsers)
                {
                    listBoxAttending.Items.Add(user.Name);
                }
                ///pictureBoxEvent.LoadAsync(m_Event.PictureNormalURL);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cannot retrive attending list");
            }
        }

        private void Formevent_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
