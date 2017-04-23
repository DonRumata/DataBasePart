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
using PresenterLibrary.Views;

namespace DataBasePart
{
    public partial class EventAddingForm : Form,IAddingEventView
    {
        public const string CMaskFormat = "dd:hh:mm";
        public const string CMaskDurationFormat = "hh:mm";

        private readonly ApplicationContext _context;
        private bool FirstOneChecked = false;

        #region IEventAddingView
        #region Parameters
        public string Namebox
        {
            get { return EventNameBox.Text; }
            set { EventNameBox.Text = value; }
        }

        public EventRepeatRadioValues WhichTypeOfRemind
        {
            get
            {
                if (RadioWithoutRepeat.Checked)
                    return EventRepeatRadioValues.WithoutRepeat;
                else if (RadioEveryday.Checked)
                    return EventRepeatRadioValues.EverydayRepeat;
                else if (RadioEveryweek.Checked)
                    return EventRepeatRadioValues.EveryweekRepeat;
                else if (RadioEverymonth.Checked)
                    return EventRepeatRadioValues.EverymonthRepeat;
                else
                    return EventRepeatRadioValues.Err;
            }
            set
            {
                switch(value)
                {
                    case EventRepeatRadioValues.WithoutRepeat: RadioWithoutRepeat.Checked = true; break;
                    case EventRepeatRadioValues.EverydayRepeat:RadioEveryday.Checked = true;break;
                    case EventRepeatRadioValues.EveryweekRepeat:RadioEveryweek.Checked = true;break;
                    case EventRepeatRadioValues.EverymonthRepeat:RadioEverymonth.Checked = true;break;
                }
            }
        }

        public DateTime EventHappen
        {
            get
            {
                if (FirstOneChecked)
                    return DateTime.Now.Add(TimeSpan.ParseExact(BeforeEventMask.Text, MaskFormat, CultureInfo.CurrentUICulture));
                else
                    return new DateTime(DateTimeHappens.Value.Year,
                        DateTimeHappens.Value.Month,
                        DateTimeHappens.Value.Day,
                        DateTimeHappensT.Value.Hour,
                        DateTimeHappensT.Value.Minute,
                        DateTimeHappensT.Value.Second);
            }
            set { }
        }
        public DateTime? EventDuration
        {
            get { return DateTime.ParseExact(EventDurationMask.Text, MaskDurationFormat, CultureInfo.CurrentUICulture, DateTimeStyles.None); }
            set
            {
                if (value.HasValue)
                    EventDurationMask.Text = value.Value.ToString(CMaskDurationFormat);
                else
                    EventDurationMask.Text = null;
            }
        }

        public ListView.ListViewItemCollection ListViewItems
        {
            get { return TimeListView.Items; }
            set
            {
                TimeListView.Items.Clear();
                TimeListView.Items.AddRange(value);
            }
        }

        public string MaskFormat
        {
            get { return CMaskFormat; }
        }
        public string MaskDurationFormat
        {
            get { return CMaskDurationFormat; }
        }
        #endregion

        #region Events
        public event EventHandler AddItemToViewStruct;
        public event Action<IEnumerable<int>> RemoveRangeFromViewStruct;
        public event EventHandler SaveAndQuit;
        public event EventHandler SaveAndAddRemind;
        #endregion

        /*Конструктор, инициализирует компоненты и связывает соыбтия с интерфейсом*/
        public EventAddingForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            AddTimeButton.Click += (setnder, args) => Invoke(AddItemToViewStruct);
            RemoveTimeButton.Click += (sender,args) => Invoke(RemoveRangeFromViewStruct, TimeListView.SelectedIndices.Cast<int>());
            SaveAndQuitButton.Click += (sender, args) => Invoke(SaveAndQuit);
        }

        /*Метод, добавляет значение в TimeListView список*/
        public void AdditemToView(ListViewItem InItem)
        {
            TimeListView.Items.Add(InItem);
        }

        /*Метод, удаляет выделенные пользователем значения из TimeListView списка*/
        public void RemoveSelectedItemsFromView()
        {
            foreach (ListViewItem IT in TimeListView.SelectedItems)
            {
                TimeListView.Items.Remove(IT);
            }
            if (TimeListView.Items.Count == 0)
                Remove_Button_Enabler(false);
        }
        #endregion

        /*Обработчик события, меняет включение/отключение элементов формы при переключении "осталось до события", "событие произойдет в"*/
        private void RadioButtonChange(object sender, EventArgs e)
        {
            switch((sender as RadioButton).TabIndex)
            {
                case 1:
                    BeforeEventMask.Enabled = true;
                    DateTimeHappens.Enabled = false;
                    DateTimeHappensT.Enabled = false;
                    FirstOneChecked = true;
                    break;
                case 4:
                    BeforeEventMask.Enabled = false;
                    DateTimeHappens.Enabled = true;
                    DateTimeHappensT.Enabled = true;
                    FirstOneChecked = false;
                    break;
            }
        }

        private void EventDurationCheckBoxChange(object sender, EventArgs e)
        {
            EventDurationMask.Enabled = !EventDurationMask.Enabled;
        }

        private void Invoke(Action action)
        {
            action?.Invoke();
        }

        private void Invoke<TArg>(Action<TArg> action, TArg arg)
        {
            action?.Invoke(arg);
        }

        public new void Show()
        {
            base.ShowDialog();
        }

        public void Remove_Button_Enabler(bool value)
        {
            RemoveTimeButton.Enabled = true;
        }
    }
}
