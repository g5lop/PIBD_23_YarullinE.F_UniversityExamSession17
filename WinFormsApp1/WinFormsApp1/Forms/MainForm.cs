using System;
using System.Windows.Forms;
using Autofac;

namespace WinFormsApp1.Forms
{
    public partial class MainForm : Form
    {
        private IComponentContext? _container;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(IComponentContext container) : this()
        {
            _container = container;
        }

        // Обработчик для Факультетов
        private void Faculties_Click(object sender, EventArgs e)
        {
            if (_container != null)
            {
                var form = _container.Resolve<FacultyListForm>();
                form.ShowDialog();
            }
        }

        // Обработчик для Дисциплин
        private void Disciplines_Click(object sender, EventArgs e)
        {
            if (_container != null)
            {
                var form = _container.Resolve<DisciplineListForm>();
                form.ShowDialog();
            }
        }

        // Обработчик для Групп
        private void Groups_Click(object sender, EventArgs e)
        {
            if (_container != null)
            {
                var form = _container.Resolve<GroupListForm>();
                form.ShowDialog();
            }

        }

        private void Students_Click(object sender, EventArgs e)
        {
            if (_container != null)
            {
                var form = _container.Resolve<StudentListForm>();
                form.ShowDialog();
            }
        }

        private void SessionResult_Click(object sender, EventArgs e)
        {
            if (_container != null)
            {
                var form = _container.Resolve<ExamResultListForm>();
                form.ShowDialog();
            }
        }
    }
}