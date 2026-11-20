namespace WinFormsApp1.Forms
{
    partial class GroupEditForm
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
            txtGroupNumber = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtGroupNumber
            // 
            txtGroupNumber.Location = new Point(111, 50);
            txtGroupNumber.Name = "txtGroupNumber";
            txtGroupNumber.Size = new Size(200, 39);
            txtGroupNumber.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(778, 72);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 1;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // GroupEditForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 603);
            Controls.Add(btnSave);
            Controls.Add(txtGroupNumber);
            Name = "GroupEditForm";
            Text = "GroupEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGroupNumber;
        private Button btnSave;
    }
}