using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBasePart
{
    static class Program
    {
        public static ApplicationContext NowUsingForm;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NowUsingForm = new ApplicationContext(new Form1());
            Application.Run(NowUsingForm);
        }
    }
}
