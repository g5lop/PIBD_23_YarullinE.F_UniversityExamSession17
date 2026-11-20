namespace WinFormsApp1.Forms
{
    partial class ExamResultListForm
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
            dataGridViewResults = new DataGridView();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Location = new Point(91, 52);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.RowHeadersWidth = 82;
            dataGridViewResults.Size = new Size(480, 300);
            dataGridViewResults.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(871, 102);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(264, 47);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить оценку";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ExamResultListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 725);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewResults);
            Name = "ExamResultListForm";
            Text = "ExamResultListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewResults;
        private Button btnAdd;
    }
}