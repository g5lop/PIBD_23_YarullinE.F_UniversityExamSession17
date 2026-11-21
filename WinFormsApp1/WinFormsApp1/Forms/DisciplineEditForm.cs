using System;
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories.Interfaces;

namespace WinFormsApp1.Forms
{
    public partial class DisciplineEditForm : Form
    {
        private IDisciplineRepository? _repository;

        public DisciplineEditForm() { InitializeComponent(); }

        public DisciplineEditForm(IDisciplineRepository repository) : this()
        {
            _repository = repository;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_repository == null) return;

            try
            {
                var discipline = Discipline.Create(0, txtName.Text.Trim(), txtTeacher.Text.Trim());
                _repository.Add(discipline);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Системная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}