
namespace Agutie
{
    partial class TeachLog
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "LOGIN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.t1);
            this.groupBox1.Controls.Add(this.t2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 201);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TeacherLoginForm";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(70, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 35);
            this.button6.TabIndex = 14;
            this.button6.Text = "EXIT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(177, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 35);
            this.button4.TabIndex = 13;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(175, 27);
            this.t1.Multiline = true;
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(204, 28);
            this.t1.TabIndex = 12;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(175, 78);
            this.t2.Multiline = true;
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(204, 29);
            this.t2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "USERNAME";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(66, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(484, 39);
            this.label6.TabIndex = 7;
            this.label6.Text = "Login Into Teacher Main Page";
            // 
            // TeachLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Agutie.Properties.Resources.ADDIAT;
            this.ClientSize = new System.Drawing.Size(593, 327);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "TeachLog";
            this.Text = "login2";
            this.Load += new System.EventHandler(this.login2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
    }
}