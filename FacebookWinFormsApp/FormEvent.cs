using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormEvent : Form
    {
        private Event m_Event;

        public FormEvent(Event i_Event)
        {
            InitializeComponent();
            m_Event = i_Event;
            if(m_Event.PictureNormalURL != null)
            {
                pictureBoxEvent.LoadAsync(m_Event.PictureNormalURL);
            }
            DateTime start = (DateTime)m_Event.StartTime;
            DateTime end = (DateTime)m_Event.EndTime;
            labelEventName.Text = m_Event.Name.ToString();
            labelTime.Text = $"{start.DayOfWeek} the {start.Day}/{start.Month}/{start.Year} From {start.Hour}:{start.Minute} to {end.Hour}:{end.Minute}";
            labelLocation.Text = $"Location:{m_Event.Venue.Name}, {m_Event.Place.Location.City}, {m_Event.Place.Location.Country}.";
            labelOwner.Text = m_Event.Owner == null ? "Owner Unavailable" : m_Event.Owner.Name;
            labelAttending.Text = $"Attending: {m_Event.AttendingCount}";
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
            }

            catch(Exception)
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
