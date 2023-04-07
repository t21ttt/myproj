
namespace Agutie
{
    partial class SudentLogin
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.t2);
            this.groupBox3.Controls.Add(this.t1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 253);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "StudentLoginForm";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 35);
            this.button5.TabIndex = 13;
            this.button5.Text = "EXIT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(129, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(186, 95);
            this.t2.Multiline = true;
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(160, 32);
            this.t2.TabIndex = 11;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(186, 27);
            this.t1.Multiline = true;
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(160, 34);
            this.t1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "PASSWORD";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "USERNAME";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightCyan;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(466, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "Login Into Student  Main Page";
            // 
            // SudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(490, 342);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Name = "SudentLogin";
            this.Text = "SudentLogin";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}