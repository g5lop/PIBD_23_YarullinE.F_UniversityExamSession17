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

        private void Faculties_Click(object sender, EventArgs e)
        {
            if (_container != null)
            {
                var form = _container.Resolve<FacultyListForm>();
                form.ShowDialog();
            }
        }
    }
}