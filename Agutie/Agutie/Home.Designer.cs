
namespace Agutie
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subgradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parentToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parentToolStripMenuItem,
            this.parentToolStripMenuItem2,
            this.teacherPageToolStripMenuItem,
            this.subjectsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1208, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parentToolStripMenuItem
            // 
            this.parentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.subgradeToolStripMenuItem,
            this.parentToolStripMenuItem1,
            this.subjectToolStripMenuItem,
            this.loginToolStripMenuItem1});
            this.parentToolStripMenuItem.Name = "parentToolStripMenuItem";
            this.parentToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.parentToolStripMenuItem.Text = "Menu";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.studentToolStripMenuItem.Text = "Parent";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.teacherToolStripMenuItem.Text = "Student";
            this.teacherToolStripMenuItem.Click += new System.EventHandler(this.teacherToolStripMenuItem_Click);
            // 
            // subgradeToolStripMenuItem
            // 
            this.subgradeToolStripMenuItem.Name = "subgradeToolStripMenuItem";
            this.subgradeToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.subgradeToolStripMenuItem.Text = "Teacher";
            this.subgradeToolStripMenuItem.Click += new System.EventHandler(this.subgradeToolStripMenuItem_Click);
            // 
            // parentToolStripMenuItem1
            // 
            this.parentToolStripMenuItem1.Name = "parentToolStripMenuItem1";
            this.parentToolStripMenuItem1.Size = new System.Drawing.Size(145, 24);
            this.parentToolStripMenuItem1.Text = "subgrade";
            this.parentToolStripMenuItem1.Click += new System.EventHandler(this.parentToolStripMenuItem1_Click);
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.subjectToolStripMenuItem.Text = "Subject";
            this.subjectToolStripMenuItem.Click += new System.EventHandler(this.subjectToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(145, 24);
            this.loginToolStripMenuItem1.Text = "Login";
            // 
            // parentToolStripMenuItem2
            // 
            this.parentToolStripMenuItem2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.parentToolStripMenuItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentToolStripMenuItem2.Name = "parentToolStripMenuItem2";
            this.parentToolStripMenuItem2.Size = new System.Drawing.Size(109, 24);
            this.parentToolStripMenuItem2.Text = "Parent Page";
            this.parentToolStripMenuItem2.Click += new System.EventHandler(this.parentToolStripMenuItem2_Click);
            // 
            // teacherPageToolStripMenuItem
            // 
            this.teacherPageToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.teacherPageToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherPageToolStripMenuItem.Name = "teacherPageToolStripMenuItem";
            this.teacherPageToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.teacherPageToolStripMenuItem.Text = " SubGrade Page";
            this.teacherPageToolStripMenuItem.Click += new System.EventHandler(this.teacherPageToolStripMenuItem_Click);
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.subjectsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.subjectsToolStripMenuItem.Text = "Subjects";
            this.subjectsToolStripMenuItem.Click += new System.EventHandler(this.subjectsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 24);
            this.toolStripMenuItem1.Text = "Assign";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Agutie.Properties.Resources.ADDIAT1;
            this.ClientSize = new System.Drawing.Size(1208, 749);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subgradeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parentToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem teacherPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}