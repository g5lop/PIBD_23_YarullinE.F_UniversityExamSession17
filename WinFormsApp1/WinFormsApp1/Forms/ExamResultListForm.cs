using System;
using System.Windows.Forms;
using Autofac;
using WinFormsApp1.Repositories.Interfaces;

namespace WinFormsApp1.Forms
{
    public partial class ExamResultListForm : Form
    {
        private IExamResultRepository? _repository;
        private IComponentContext? _container;

        public ExamResultListForm() { InitializeComponent(); }

        public ExamResultListForm(IExamResultRepository repository, IComponentContext container) : this()
        {
            _repository = repository;
            _container = container;
            LoadData();
        }

        private void LoadData()
        {
            if (_repository != null)
            {
                dataGridViewResults.DataSource = null;
                dataGridViewResults.DataSource = _repository.GetAllForDisplay().ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_container != null)
            {
                var form = _container.Resolve<ExamResultEditForm>();
                if (form.ShowDialog() == DialogResult.OK) LoadData();
            }
        }
    }
}