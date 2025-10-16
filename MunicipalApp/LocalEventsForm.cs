using System;
using System.Windows.Forms;

namespace MunicipalApp
{
    public partial class LocalEventsForm : Form
    {
        private EventManager eventManager = new EventManager();

        public LocalEventsForm()
        {
            InitializeComponent();
            LoadSampleEvents();
        }

        private void LocalEventsForm_Load(object sender, EventArgs e)
        {
            RefreshEventsList();
        }

        private void LoadSampleEvents()
        {
            // Sample events
            eventManager.AddEvent(new LocalEvent("Town Clean-Up", DateTime.Today.AddDays(2), "Community", "Community clean-up event."));
            eventManager.AddEvent(new LocalEvent("Road Maintenance", DateTime.Today.AddDays(5), "Safety", "Maintenance on Main Street."));
            eventManager.AddEvent(new LocalEvent("Safety Workshop", DateTime.Today.AddDays(3), "Education", "Free community workshop."));
            eventManager.AddEvent(new LocalEvent("Football Match", DateTime.Today.AddDays(7), "Sports", "Local football tournament."));

            // Add categories to ComboBox
            foreach (var category in eventManager.Categories)
            {
                if (!cmbCategoryFilter.Items.Contains(category))
                    cmbCategoryFilter.Items.Add(category);
            }
        }

        private void RefreshEventsList()
        {
            lstEvents.Items.Clear();
            foreach (var date in eventManager.EventsByDate.Keys)
            {
                foreach (var ev in eventManager.EventsByDate[date])
                {
                    lstEvents.Items.Add(ev.ToString());
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            lstEvents.Items.Clear();
            string selectedCategory = cmbCategoryFilter.SelectedItem.ToString();
            DateTime selectedDate = dtpDateFilter.Value.Date;

            var results = eventManager.Search(selectedCategory, selectedDate);
            if (results.Count == 0)
            {
                lstEvents.Items.Add("No events found.");
            }
            else
            {
                foreach (var ev in results)
                {
                    lstEvents.Items.Add(ev.ToString());
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
