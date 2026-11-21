namespace WinFormsApp1.Forms
{
    partial class ExamResultEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbStudent = new ComboBox();
            cmbDiscipline = new ComboBox();
            cmbGrade = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(27, 26);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(242, 40);
            cmbStudent.TabIndex = 0;
            // 
            // cmbDiscipline
            // 
            cmbDiscipline.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiscipline.FormattingEnabled = true;
            cmbDiscipline.Location = new Point(461, 26);
            cmbDiscipline.Name = "cmbDiscipline";
            cmbDiscipline.Size = new Size(242, 40);
            cmbDiscipline.TabIndex = 1;
            // 
            // cmbGrade
            // 
            cmbGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrade.FormattingEnabled = true;
            cmbGrade.Location = new Point(873, 26);
            cmbGrade.Name = "cmbGrade";
            cmbGrade.Size = new Size(242, 40);
            cmbGrade.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(726, 389);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 3;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ExamResultEditForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 723);
            Controls.Add(btnSave);
            Controls.Add(cmbGrade);
            Controls.Add(cmbDiscipline);
            Controls.Add(cmbStudent);
            Name = "ExamResultEditForm";
            Text = "ExamResultEditForm";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbStudent;
        private ComboBox cmbDiscipline;
        private ComboBox cmbGrade;
        private Button btnSave;
    }
}