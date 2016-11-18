using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Application.Run(new FormPrincipal(null));
            
            FormLogin formlogin = new FormLogin();
            Application.Run(formlogin);
            if (formlogin.DialogResult == DialogResult.OK) {
                Application.Run(new FormPrincipal(formlogin.usuario));
            }
        }
    }
}
