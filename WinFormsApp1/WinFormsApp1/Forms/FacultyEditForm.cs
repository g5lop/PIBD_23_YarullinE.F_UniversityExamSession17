using System;
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories.Interfaces;

namespace WinFormsApp1.Forms
{
    public partial class FacultyEditForm : Form
    {
        private IFacultyRepository? _repository;

        public FacultyEditForm()
        {
            InitializeComponent();
        }

        public FacultyEditForm(IFacultyRepository repository) : this()
        {
            _repository = repository;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_repository == null) return;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите название факультета!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var faculty = Faculty.Create(0, txtName.Text.Trim());
                _repository.Add(faculty);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}