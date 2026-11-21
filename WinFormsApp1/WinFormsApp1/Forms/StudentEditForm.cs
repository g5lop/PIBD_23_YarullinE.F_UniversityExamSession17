using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Enums;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories.Interfaces;

namespace WinFormsApp1.Forms
{
    public partial class StudentEditForm : Form
    {
        private IStudentRepository? _repository;
        private IStudentGroupRepository? _groupRepository;

        public StudentEditForm() { InitializeComponent(); }

        public StudentEditForm(IStudentRepository repository, IStudentGroupRepository groupRepository) : this()
        {
            _repository = repository;
            _groupRepository = groupRepository;
            LoadGroups();
        }

        private void LoadGroups()
        {
            if (_groupRepository != null)
            {
                cmbGroup.DataSource = _groupRepository.GetAll().ToList();
                cmbGroup.DisplayMember = "GroupNumber";
                cmbGroup.ValueMember = "Id";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_repository == null || cmbGroup.SelectedValue == null)
            {
                MessageBox.Show("Сначала добавьте хотя бы одну группу в справочник!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                StudentStatus status = StudentStatus.None;
                if (chkMarried.Checked) status |= StudentStatus.Married;
                if (chkDorm.Checked) status |= StudentStatus.InDormitory;

                int groupId = (int)cmbGroup.SelectedValue;
                decimal avgScore = numAverageScore.Value;

                var student = Student.Create(0, txtFullName.Text.Trim(), groupId, status, avgScore);
                _repository.Add(student);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Системная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}