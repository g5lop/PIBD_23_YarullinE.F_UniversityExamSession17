namespace WinFormsApp1.Forms
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            Directory = new ToolStripMenuItem();
            Faculties = new ToolStripMenuItem();
            дисциплиныToolStripMenuItem = new ToolStripMenuItem();
            Groups = new ToolStripMenuItem();
            Operations = new ToolStripMenuItem();
            Students = new ToolStripMenuItem();
            SessionResult = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Directory, Operations });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1288, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Directory
            // 
            Directory.DropDownItems.AddRange(new ToolStripItem[] { Faculties, дисциплиныToolStripMenuItem, Groups });
            Directory.Name = "Directory";
            Directory.Size = new Size(191, 36);
            Directory.Text = "Справочники ";
            // 
            // Faculties
            // 
            Faculties.Name = "Faculties";
            Faculties.Size = new Size(289, 44);
            Faculties.Text = "Факультеты";
            Faculties.Click += Faculties_Click;
            // 
            // дисциплиныToolStripMenuItem
            // 
            дисциплиныToolStripMenuItem.Name = "дисциплиныToolStripMenuItem";
            дисциплиныToolStripMenuItem.Size = new Size(289, 44);
            дисциплиныToolStripMenuItem.Text = "Дисциплины";
            // 
            // Groups
            // 
            Groups.Name = "Groups";
            Groups.Size = new Size(289, 44);
            Groups.Text = "Группы";
            // 
            // Operations
            // 
            Operations.DropDownItems.AddRange(new ToolStripItem[] { Students, SessionResult });
            Operations.Name = "Operations";
            Operations.Size = new Size(147, 36);
            Operations.Text = "Операции";
            // 
            // Students
            // 
            Students.Name = "Students";
            Students.Size = new Size(355, 44);
            Students.Text = "Студенты";
            Students.Click += Students_Click;
            // 
            // SessionResult
            // 
            SessionResult.Name = "SessionResult";
            SessionResult.Size = new Size(355, 44);
            SessionResult.Text = "Результаты Сессии";
            SessionResult.Click += SessionResult_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._8efc41d5a3d6f09cdffe682158ff7469;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1288, 821);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Directory;
        private ToolStripMenuItem Faculties;
        private ToolStripMenuItem дисциплиныToolStripMenuItem;
        private ToolStripMenuItem Groups;
        private ToolStripMenuItem Operations;
        private ToolStripMenuItem Students;
        private ToolStripMenuItem SessionResult;
    }
}