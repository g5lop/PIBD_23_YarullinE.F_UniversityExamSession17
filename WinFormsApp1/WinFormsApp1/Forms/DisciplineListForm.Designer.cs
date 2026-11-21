namespace WinFormsApp1.Forms
{
    partial class DisciplineListForm
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
            dataGridViewDisciplines = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDisciplines).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDisciplines
            // 
            dataGridViewDisciplines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDisciplines.Location = new Point(130, 56);
            dataGridViewDisciplines.Name = "dataGridViewDisciplines";
            dataGridViewDisciplines.RowHeadersWidth = 82;
            dataGridViewDisciplines.Size = new Size(480, 300);
            dataGridViewDisciplines.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(864, 92);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Создать";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(864, 211);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // DisciplineListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 605);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewDisciplines);
            Name = "DisciplineListForm";
            Text = "DisciplineListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDisciplines).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDisciplines;
        private Button btnAdd;
        private Button btnDelete;
    }
}