namespace WinFormsApp1.Forms
{
    partial class StudentEditForm
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
            txtFullName = new TextBox();
            cmbGroup = new ComboBox();
            chkMarried = new CheckBox();
            chkDorm = new CheckBox();
            numAverageScore = new NumericUpDown();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numAverageScore).BeginInit();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(39, 51);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 39);
            txtFullName.TabIndex = 0;
            // 
            // cmbGroup
            // 
            cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGroup.FormattingEnabled = true;
            cmbGroup.Location = new Point(858, 50);
            cmbGroup.Name = "cmbGroup";
            cmbGroup.Size = new Size(242, 40);
            cmbGroup.TabIndex = 1;
            // 
            // chkMarried
            // 
            chkMarried.AutoSize = true;
            chkMarried.Location = new Point(12, 126);
            chkMarried.Name = "chkMarried";
            chkMarried.Size = new Size(227, 36);
            chkMarried.TabIndex = 2;
            chkMarried.Text = "Женат/Замужем";
            chkMarried.UseVisualStyleBackColor = true;
            // 
            // chkDorm
            // 
            chkDorm.AutoSize = true;
            chkDorm.Location = new Point(12, 212);
            chkDorm.Name = "chkDorm";
            chkDorm.Size = new Size(275, 36);
            chkDorm.TabIndex = 3;
            chkDorm.Text = "Живет в общежитии";
            chkDorm.UseVisualStyleBackColor = true;
            // 
            // numAverageScore
            // 
            numAverageScore.DecimalPlaces = 1;
            numAverageScore.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numAverageScore.Location = new Point(612, 216);
            numAverageScore.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numAverageScore.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numAverageScore.Name = "numAverageScore";
            numAverageScore.Size = new Size(240, 39);
            numAverageScore.TabIndex = 4;
            numAverageScore.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // btnSave
            // 
            btnSave.Location = new Point(980, 236);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 5;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // StudentEditForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 651);
            Controls.Add(btnSave);
            Controls.Add(numAverageScore);
            Controls.Add(chkDorm);
            Controls.Add(chkMarried);
            Controls.Add(cmbGroup);
            Controls.Add(txtFullName);
            Name = "StudentEditForm";
            Text = "StudentEditForm";
            ((System.ComponentModel.ISupportInitialize)numAverageScore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private ComboBox cmbGroup;
        private CheckBox chkMarried;
        private CheckBox chkDorm;
        private NumericUpDown numAverageScore;
        private Button btnSave;
    }
}