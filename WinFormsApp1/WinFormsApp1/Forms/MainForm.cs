using System;
using System.Windows.Forms;
using Autofac;

namespace WinFormsApp1.Forms
{
    public partial class MainForm : Form
    {
        // Поле для хранения контейнера
        private readonly IComponentContext _container;

        public MainForm()
        {
            InitializeComponent();
        }

        // 2. КОНСТРУКТОР С ЗАВИСИМОСТЯМИ (Для запуска через Autofac)
        public MainForm(IComponentContext container) : this() // : this() вызывает пустой конструктор выше
        {
            _container = container;
        }

        // Обработчик клика по меню "Факультеты"
        private void Faculties_Click(object sender, EventArgs e)
        {
            // Пока просто проверим, что связь работает
            MessageBox.Show("Меню 'Факультеты' нажато!");

            // Когда создадим форму факультетов, раскомментируем эти строки:
            // var form = _container.Resolve<FacultyListForm>();
            // form.ShowDialog();
        }
    }
}