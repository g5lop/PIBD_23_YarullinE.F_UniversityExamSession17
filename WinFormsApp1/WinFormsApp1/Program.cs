using System;
using System.Windows.Forms;
using Autofac;
using WinFormsApp1.Forms;
using WinFormsApp1.Infrastructure;

namespace WinFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var mainForm = scope.Resolve<MainForm>();
                Application.Run(mainForm);
            }
        }
    }
}