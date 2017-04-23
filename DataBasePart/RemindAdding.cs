using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresenterLibrary.Views;
using DataBasePart.Common;

namespace DataBasePart
{
    public partial class RemindAdding : Form, IRemindAddingView
    {
        private readonly ComboReadonlyDictionary BeforeDictionary = new ComboReadonlyDictionary(0);
        private readonly ComboReadonlyDictionary AfterDictionary = new ComboReadonlyDictionary(1);

        private const string MaskFormat = "MM.dd hh:mm";

        public RemindAdding()
        {
            InitializeComponent();
            RemindBeforeCombo.DataSource = new BindingSource(BeforeDictionary,null);
            RemindBeforeCombo.DisplayMember = "Key";
            RemindBeforeCombo.ValueMember = "Value";
            RemindAfterCombo.DataSource = new BindingSource(AfterDictionary, null);
            RemindAfterCombo.DisplayMember = "Key";
            RemindAfterCombo.ValueMember = "Value";
            AddRemindButton.Click += (sender, args) => Invoke(AddRemind);
            DeleteRemindButton.Click += (sender, args) => Invoke<int>(DeleteRemind, RemindListBox.SelectedIndex);
            
        }
        #region IRemindAddingView Realization
        #region Parameters
        public RemindRadioValues HowToRemind
        {
            get
            {
                if (RemindInTimeRadio.Checked)
                    return RemindRadioValues.RemindInTime;
                else if (RemindBeforeRadio.Checked)
                    return RemindRadioValues.RemindBefore;
                else if (RemindAfterRadio.Checked)
                    return RemindRadioValues.RemindAfter;
                else return RemindRadioValues.Err;
            }

            set
            {
                
                switch(value)
                {
                    case RemindRadioValues.RemindInTime:RemindInTimeRadio.Checked = true; break;
                    case RemindRadioValues.RemindBefore:RemindBeforeRadio.Checked = true; break;
                    case RemindRadioValues.RemindAfter:RemindAfterRadio.Checked = true; break;
                }
            }
        }

        public TimeSpan? RemindAfterBefore
        {
            get
            {
                switch(HowToRemind)
                {
                    case RemindRadioValues.RemindInTime: return null;
                    case RemindRadioValues.RemindAfter:return (TimeSpan)RemindAfterCombo.SelectedValue;
                    case RemindRadioValues.RemindBefore:return ((TimeSpan)RemindBeforeCombo.SelectedValue).Negate();
                    default: return new TimeSpan();
                }
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime RemindUntil
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int SelectedValue
        {
            get { return TimersListView.SelectedIndices[0]; }
        }
        #endregion


        #region Events
        public event EventHandler AddRemind;
        public event EventHandler Back;
        public event Action<int> DeleteRemind;
        #endregion

        #region Functions
        public void AdditemToReminders(DateTime InDT)
        {
            RemindListBox.Items.Add(InDT.ToString(MaskFormat));
        }

        public void RemoveSelectedItem_From_RemindersList(int SelectedIndex)
        {
            RemindListBox.Items.RemoveAt(SelectedIndex);
        }

        public void FirstPanelInitialization(int WhichOne, string[] ComboElementsIn=null)
        {
            
            switch (WhichOne)
            {
                case 0:
                    panel1.Visible = true;
                    ComboEventNames.Items.Clear();
                    ComboEventNames.Items.AddRange(ComboElementsIn);
                    break;
            }
        }
        #endregion
        #endregion

        private void Invoke(Action action)
        {
            action?.Invoke();
        }

        private void Invoke<TArg>(Action<TArg> action, TArg arg)
        {
            action?.Invoke(arg);
        }
    }
}
