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

namespace DataBasePart
{


    public partial class MainBaseInterfaceForm : Form,IMainView
    {
        private readonly ApplicationContext _context;
        public MainBaseInterfaceForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            EventAddMenuStrip.Click += (sender, args) => Invoke(AddEventClick);
            RemindAddMenuStrip.Click += (sender, args) => Invoke(AddRemindClick);
        }
        #region Params
        public object MainViewDataGridSet
        {
            set
            {
                MainViewGrid.DataSource = value;
            }
        }

        public object EventViewDataGridSet
        {
            set
            {
                EventViewGrid.DataSource = value;
            }
        }

        public object OtherViewGridSet
        {
            set
            {
                
            }
        }
        #endregion

        #region Events
        public event EventHandler AddEventClick;
        public event EventHandler AddRemindClick;
        #endregion

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void MainBaseInterfaceForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archeageDataBaseDataSet.EventBase". При необходимости она может быть перемещена или удалена.
            //this.eventBaseTableAdapter.Fill(this.archeageDataBaseDataSet.EventBase);
        }

        private void Invoke(Action action)
        {
            action?.Invoke();
        }
    }
}
