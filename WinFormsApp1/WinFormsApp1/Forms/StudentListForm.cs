using System;
using System.Linq;
using System.Windows.Forms;
using Autofac;
using WinFormsApp1.Repositories.Interfaces;

namespace WinFormsApp1.Forms
{
    public partial class StudentListForm : Form
    {
        private IStudentRepository? _repository;
        private IComponentContext? _container;

        public StudentListForm() { InitializeComponent(); }

        public StudentListForm(IStudentRepository repository, IComponentContext container) : this()
        {
            _repository = repository;
            _container = container;
            LoadData();
        }

        private void LoadData()
        {
            if (_repository != null)
            {
                dataGridViewStudents.DataSource = null;
                dataGridViewStudents.DataSource = _repository.GetAll().ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_container != null)
            {
                var form = _container.Resolve<StudentEditForm>();
                if (form.ShowDialog() == DialogResult.OK) LoadData();
            }
        }
    }
}