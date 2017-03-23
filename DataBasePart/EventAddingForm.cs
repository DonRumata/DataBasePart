using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DataBasePart
{
    public interface IEventAddingView
    {
        string NameBox { get; }
        int Which_type_of_remind { get; set; }
        DateTime EventTimeHap { get; set; }
        List<ListViewItem> ListViewItemsList { set; }

        event EventHandler RadioButtonChange;
        event EventHandler AddTimeClick;
        event EventHandler<IEnumerable<int>> RemoveTimeClick;
        event EventHandler SaveAndQuitClick;
        event EventHandler BackClick;
        event EventHandler AddReminderClick;
    }

    public partial class EventAddingForm : Form,IEventAddingView
    {
        public const string MaskFormat = "dd:hh:mm";
        private bool FirstOneChecked;

        #region IEventAddingView
        #region Parameters
        public string NameBox
        {
            get { return EventNameBox.Text; }
        }
        public int Which_type_of_remind
        {
            get { return Which_type_of_remind; }
            set { Which_type_of_remind = value; }
        }
        public DateTime EventTimeHap
        {
            get { return EventTimeHap; }
            private set
            {
                EventTimeHap = value;
            }
        }
        #endregion

        #region EventHandlers
        public event EventHandler AddTimeClick;
        public event EventHandler<IEnumerable<int>> RemoveTimeClick;
        public event EventHandler SaveAndQuitClick;
        #endregion


        public EventAddingForm()
        {
            InitializeComponent();
        }

        private void AddTimeButton_Click(object sender, EventArgs e)
        {
            DateTime EventTime;
            if (FirstOneChecked)
            {
                TimeSpan Addable;
                if (TimeSpan.TryParseExact(BeforeEventMask.Text, MaskFormat, CultureInfo.CurrentUICulture, out Addable))
                {
                    TimeListView.Items.Add(new ListViewItem(new string[] { DateTime.Now.Add(Addable).ToString(MaskFormat), RadioCheckedInToTextValue() }));
                }
                    
                else
                    EventTime = new DateTime(0, 0, 0);
            }
            else
            {
                TimeListView.Items.Add(new ListViewItem(new string[] { DateTimeHappens.Value.ToString(MaskFormat), RadioCheckedInToTextValue() }));
            }
            EventTimeHap = EventTime;
            AddTimeClick(this, EventArgs.Empty);
        }

        private void RemoveTimeButton_Click(object sender, EventArgs e)
        {
            //TODO
            RemoveTimeClick(this, TimeListView.SelectedIndices.Cast<int>());
            foreach (ListViewItem T in TimeListView.SelectedItems)
            {
                TimeListView.Items.Remove(T);
            }
        }

        private void SaveAndQuit_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.Close();
        }
        #endregion

        private void ClearForm()
        {
            EventNameBox.Text = "";

        }

        private string RadioCheckedInToTextValue()
        {
            switch(Which_type_of_remind)
            {
                case 1: return "Без повторений";
                case 2: return "Ежедневно";
                case 3: return "Еженедельно";
                case 4: return "Ежемесячно";
            }
            return "";
        }

        private void RadioButtonChange(object sender, EventArgs e)
        {

        }
    }
}
