using System;
using System.Linq;
using System.Windows.Forms;
using Autofac;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories.Interfaces;

namespace WinFormsApp1.Forms
{
    public partial class FacultyListForm : Form
    {
        private IFacultyRepository? _repository;
        private IComponentContext? _container;

        public FacultyListForm()
        {
            InitializeComponent();
        }

        public FacultyListForm(IFacultyRepository repository, IComponentContext container) : this()
        {
            _repository = repository;
            _container = container;
            LoadData();
        }

        private void LoadData()
        {
            if (_repository != null)
            {
                dataGridViewFaculties.DataSource = null;
                dataGridViewFaculties.DataSource = _repository.GetAll().ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_container != null)
            {
                var form = _container.Resolve<FacultyEditForm>();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_repository != null && dataGridViewFaculties.CurrentRow?.DataBoundItem is Faculty selected)
            {
                _repository.Delete(selected.Id);
                LoadData();
            }
        }
    }
}