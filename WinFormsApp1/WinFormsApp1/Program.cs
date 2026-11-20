using Autofac;
using SessionAccountingApp.Forms; // Не забудь создать эту папку для форм!
using SessionAccountingApp.Infrastructure;
using System;
using System.Windows.Forms;

namespace SessionAccountingApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Собираем контейнер
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                // Получаем главную форму
                var mainForm = scope.Resolve<MainForm>();
                Application.Run(mainForm);
            }
        }
    }
}