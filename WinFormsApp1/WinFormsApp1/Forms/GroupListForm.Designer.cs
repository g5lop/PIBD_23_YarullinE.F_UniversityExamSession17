namespace WinFormsApp1.Forms
{
    partial class GroupListForm
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
            dataGridViewGroups = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroups).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewGroups
            // 
            dataGridViewGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGroups.Location = new Point(12, 12);
            dataGridViewGroups.Name = "dataGridViewGroups";
            dataGridViewGroups.RowHeadersWidth = 82;
            dataGridViewGroups.Size = new Size(480, 300);
            dataGridViewGroups.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(877, 66);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Создать";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(877, 183);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // GroupListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 651);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewGroups);
            Name = "GroupListForm";
            Text = "GroupListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroups).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewGroups;
        private Button btnAdd;
        private Button btnDelete;
    }
}