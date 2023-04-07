
namespace Agutie
{
    partial class studsection
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
            this.classRoom1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agutDataSet = new Agutie.AgutDataSet();
            this.class_Room1TableAdapter = new Agutie.AgutDataSetTableAdapters.Class_Room1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.student1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student1TableAdapter = new Agutie.AgutDataSetTableAdapters.Student1TableAdapter();
            this.agutDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKsubject1studi35BCFE0ABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subject1TableAdapter = new Agutie.AgutDataSetTableAdapters.subject1TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.classRoom1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agutDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKsubject1studi35BCFE0ABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // classRoom1BindingSource
            // 
            this.classRoom1BindingSource.DataMember = "Class_Room1";
            this.classRoom1BindingSource.DataSource = this.agutDataSet;
            // 
            // agutDataSet
            // 
            this.agutDataSet.DataSetName = "AgutDataSet";
            this.agutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // class_Room1TableAdapter
            // 
            this.class_Room1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(499, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Assign";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // student1BindingSource
            // 
            this.student1BindingSource.DataMember = "Student1";
            this.student1BindingSource.DataSource = this.agutDataSet;
            // 
            // student1TableAdapter
            // 
            this.student1TableAdapter.ClearBeforeFill = true;
            // 
            // agutDataSetBindingSource
            // 
            this.agutDataSetBindingSource.DataSource = this.agutDataSet;
            this.agutDataSetBindingSource.Position = 0;
            // 
            // fKsubject1studi35BCFE0ABindingSource
            // 
            this.fKsubject1studi35BCFE0ABindingSource.DataMember = "FK__subject1__stud_i__35BCFE0A";
            this.fKsubject1studi35BCFE0ABindingSource.DataSource = this.student1BindingSource;
            // 
            // subject1TableAdapter
            // 
            this.subject1TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(378, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 179);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 66);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(327, 179);
            this.dataGridView2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(76, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "DISPLAY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student Assign To Class";
            // 
            // studsection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(747, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "studsection";
            this.Text = "studsection";
            this.Load += new System.EventHandler(this.studsection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classRoom1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agutDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKsubject1studi35BCFE0ABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AgutDataSet agutDataSet;
        private System.Windows.Forms.BindingSource classRoom1BindingSource;
        private AgutDataSetTableAdapters.Class_Room1TableAdapter class_Room1TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource student1BindingSource;
        private AgutDataSetTableAdapters.Student1TableAdapter student1TableAdapter;
        private System.Windows.Forms.BindingSource agutDataSetBindingSource;
        private System.Windows.Forms.BindingSource fKsubject1studi35BCFE0ABindingSource;
        private AgutDataSetTableAdapters.subject1TableAdapter subject1TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}