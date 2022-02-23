using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTeamFresh
{
    public delegate void LangugeChange();

    internal static class Program
    {
        public static MainClas mc; 

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            mc  = new MainClas();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Vievces.WeighingsForm());
        }
    }
}
