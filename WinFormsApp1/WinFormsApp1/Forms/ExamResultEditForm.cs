using System;
using System.Windows.Forms;
using WinFormsApp1.Enums;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories.Interfaces;

namespace WinFormsApp1.Forms
{
    public partial class ExamResultEditForm : Form
    {
        private IExamResultRepository? _repository;
        private IStudentRepository? _studentRepo;
        private IDisciplineRepository? _disciplineRepo;

        public ExamResultEditForm() { InitializeComponent(); }

        public ExamResultEditForm(IExamResultRepository repository, IStudentRepository studentRepo, IDisciplineRepository disciplineRepo) : this()
        {
            _repository = repository;
            _studentRepo = studentRepo;
            _disciplineRepo = disciplineRepo;

            LoadData();
        }

        private void LoadData()
        {
            // Загружаем студентов
            cmbStudent.DataSource = _studentRepo?.GetAll().ToList();
            cmbStudent.DisplayMember = "FullName";
            cmbStudent.ValueMember = "Id";

            // Загружаем дисциплины
            cmbDiscipline.DataSource = _disciplineRepo?.GetAll().ToList();
            cmbDiscipline.DisplayMember = "Name";
            cmbDiscipline.ValueMember = "Id";

            // Загружаем оценки из Enum
            cmbGrade.DataSource = Enum.GetValues(typeof(Grade));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_repository == null || cmbStudent.SelectedValue == null || cmbDiscipline.SelectedValue == null)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int studentId = (int)cmbStudent.SelectedValue;
                int disciplineId = (int)cmbDiscipline.SelectedValue;
                Grade grade = (Grade)cmbGrade.SelectedItem!;

                var result = ExamResult.Create(0, studentId, disciplineId, grade);
                _repository.Add(result);

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