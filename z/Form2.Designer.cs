namespace z
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.кабинетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet = new z.Database2DataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.предметПреподавательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.предметBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.предметTableAdapter = new z.Database2DataSetTableAdapters.ПредметTableAdapter();
            this.преподавательTableAdapter = new z.Database2DataSetTableAdapters.ПреподавательTableAdapter();
            this.кабинетTableAdapter = new z.Database2DataSetTableAdapters.КабинетTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.кабинетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметПреподавательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(240, 73);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(117, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Первая/Вторая н.";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(143, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "На весь поток";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.кабинетBindingSource;
            this.comboBox3.DisplayMember = "Номер";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 73);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // кабинетBindingSource
            // 
            this.кабинетBindingSource.DataMember = "Кабинет";
            this.кабинетBindingSource.DataSource = this.database2DataSet;
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.предметПреподавательBindingSource;
            this.comboBox2.DisplayMember = "Имя преподавателя";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(351, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // предметПреподавательBindingSource
            // 
            this.предметПреподавательBindingSource.DataMember = "ПредметПреподаватель";
            this.предметПреподавательBindingSource.DataSource = this.предметBindingSource;
            // 
            // предметBindingSource
            // 
            this.предметBindingSource.DataMember = "Предмет";
            this.предметBindingSource.DataSource = this.database2DataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.предметBindingSource;
            this.comboBox1.DisplayMember = "Имя предмета";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(351, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // предметTableAdapter
            // 
            this.предметTableAdapter.ClearBeforeFill = true;
            // 
            // преподавательTableAdapter
            // 
            this.преподавательTableAdapter.ClearBeforeFill = true;
            // 
            // кабинетTableAdapter
            // 
            this.кабинетTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 163);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.кабинетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметПреподавательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource предметBindingSource;
        private Database2DataSetTableAdapters.ПредметTableAdapter предметTableAdapter;
        private System.Windows.Forms.BindingSource предметПреподавательBindingSource;
        private Database2DataSetTableAdapters.ПреподавательTableAdapter преподавательTableAdapter;
        private System.Windows.Forms.BindingSource кабинетBindingSource;
        private Database2DataSetTableAdapters.КабинетTableAdapter кабинетTableAdapter;
    }
}