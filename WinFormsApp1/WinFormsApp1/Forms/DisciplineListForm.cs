using System;
using System.Linq;
using System.Windows.Forms;
using Autofac;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories.Interfaces;

namespace WinFormsApp1.Forms
{
    public partial class DisciplineListForm : Form
    {
        private IDisciplineRepository? _repository;
        private IComponentContext? _container;

        public DisciplineListForm()
        {
            InitializeComponent();
        }

        public DisciplineListForm(IDisciplineRepository repository, IComponentContext container) : this()
        {
            _repository = repository;
            _container = container;
            LoadData();
        }

        private void LoadData()
        {
            if (_repository != null)
            {
                dataGridViewDisciplines.DataSource = null;
                dataGridViewDisciplines.DataSource = _repository.GetAll().ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_container != null)
            {
                var form = _container.Resolve<DisciplineEditForm>();
                if (form.ShowDialog() == DialogResult.OK) LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_repository != null && dataGridViewDisciplines.CurrentRow?.DataBoundItem is Discipline selected)
            {
                _repository.Delete(selected.Id);
                LoadData();
            }
        }
    }
}