namespace WinFormsApp1.Forms
{
    partial class FacultyListForm
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
            dataGridViewFaculties = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFaculties).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFaculties
            // 
            dataGridViewFaculties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFaculties.Location = new Point(12, 12);
            dataGridViewFaculties.Name = "dataGridViewFaculties";
            dataGridViewFaculties.RowHeadersWidth = 82;
            dataGridViewFaculties.Size = new Size(480, 300);
            dataGridViewFaculties.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(749, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(749, 196);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FacultyListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 615);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewFaculties);
            Name = "FacultyListForm";
            Text = "FacultyListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFaculties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewFaculties;
        private Button btnAdd;
        private Button btnDelete;
    }
}