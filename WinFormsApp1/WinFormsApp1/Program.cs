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
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var mainForm = scope.Resolve<MainForm>();
                Application.Run(mainForm);
            }
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ShowError(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ShowError(e.ExceptionObject as Exception);
        }

        private static void ShowError(Exception? ex)
        {
            string errorMsg = ex?.Message ?? "Неизвестная ошибка";

            MessageBox.Show(
                $"Произошла непредвиденная ошибка:\n\n{errorMsg}\n\nПриложение будет закрыто.",
                "Критическая ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            Application.Exit();
        }
    }
}