using System;
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories.Interfaces;

namespace WinFormsApp1.Forms
{
    public partial class GroupEditForm : Form
    {
        private IStudentGroupRepository? _repository;

        public GroupEditForm()
        {
            InitializeComponent();
        }

        public GroupEditForm(IStudentGroupRepository repository) : this()
        {
            _repository = repository;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_repository == null) return;

            if (string.IsNullOrWhiteSpace(txtGroupNumber.Text))
            {
                MessageBox.Show("Введите номер группы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var group = StudentGroup.Create(0, txtGroupNumber.Text.Trim());
                _repository.Add(group);
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