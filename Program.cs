using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            EmbeddedAssembly.Load("DLLLOADER.MetroFramework.dll", "MetroFramework.dll");
            EmbeddedAssembly.Load("DLLLOADER.MetroFramework.Fonts.dll", "MetroFramework.Fonts.dll");
            EmbeddedAssembly.Load("DLLLOADER.MetroFramework.Design.dll", "MetroFramework.Design.dll");

            Application.Run(new Loader());

        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }

    }
}
