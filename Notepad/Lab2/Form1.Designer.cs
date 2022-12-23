namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeFlt = new System.Windows.Forms.ComboBox();
            this.customerFlt = new System.Windows.Forms.ComboBox();
            this.supplierFlt = new System.Windows.Forms.ComboBox();
            this.oderDateFrom = new System.Windows.Forms.DateTimePicker();
            this.oderDateTo = new System.Windows.Forms.DateTimePicker();
            this.freightFrom = new System.Windows.Forms.NumericUpDown();
            this.freightTo = new System.Windows.Forms.NumericUpDown();
            this.sortByEmployee = new System.Windows.Forms.RadioButton();
            this.sortByCustomer = new System.Windows.Forms.RadioButton();
            this.sortByOderDate = new System.Windows.Forms.RadioButton();
            this.Filter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freightFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freightTo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(444, 510);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // employeeFlt
            // 
            this.employeeFlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeFlt.FormattingEnabled = true;
            this.employeeFlt.Location = new System.Drawing.Point(577, 12);
            this.employeeFlt.Name = "employeeFlt";
            this.employeeFlt.Size = new System.Drawing.Size(151, 28);
            this.employeeFlt.TabIndex = 1;
            this.employeeFlt.SelectedIndexChanged += new System.EventHandler(this.employeeFlt_SelectedIndexChanged);
            // 
            // customerFlt
            // 
            this.customerFlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerFlt.FormattingEnabled = true;
            this.customerFlt.Location = new System.Drawing.Point(577, 101);
            this.customerFlt.Name = "customerFlt";
            this.customerFlt.Size = new System.Drawing.Size(151, 28);
            this.customerFlt.TabIndex = 2;
            // 
            // supplierFlt
            // 
            this.supplierFlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierFlt.FormattingEnabled = true;
            this.supplierFlt.Location = new System.Drawing.Point(577, 55);
            this.supplierFlt.Name = "supplierFlt";
            this.supplierFlt.Size = new System.Drawing.Size(151, 28);
            this.supplierFlt.TabIndex = 3;
            // 
            // oderDateFrom
            // 
            this.oderDateFrom.Location = new System.Drawing.Point(81, 33);
            this.oderDateFrom.Name = "oderDateFrom";
            this.oderDateFrom.Size = new System.Drawing.Size(192, 27);
            this.oderDateFrom.TabIndex = 4;
            this.oderDateFrom.ValueChanged += new System.EventHandler(this.oderDateFrom_ValueChanged);
            // 
            // oderDateTo
            // 
            this.oderDateTo.Location = new System.Drawing.Point(81, 76);
            this.oderDateTo.Name = "oderDateTo";
            this.oderDateTo.Size = new System.Drawing.Size(192, 27);
            this.oderDateTo.TabIndex = 5;
            // 
            // freightFrom
            // 
            this.freightFrom.Location = new System.Drawing.Point(81, 32);
            this.freightFrom.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.freightFrom.Name = "freightFrom";
            this.freightFrom.Size = new System.Drawing.Size(150, 27);
            this.freightFrom.TabIndex = 6;
            this.freightFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.freightFrom.ValueChanged += new System.EventHandler(this.freightFrom_ValueChanged);
            // 
            // freightTo
            // 
            this.freightTo.Location = new System.Drawing.Point(81, 77);
            this.freightTo.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.freightTo.Name = "freightTo";
            this.freightTo.Size = new System.Drawing.Size(150, 27);
            this.freightTo.TabIndex = 7;
            // 
            // sortByEmployee
            // 
            this.sortByEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortByEmployee.AutoSize = true;
            this.sortByEmployee.Location = new System.Drawing.Point(577, 383);
            this.sortByEmployee.Name = "sortByEmployee";
            this.sortByEmployee.Size = new System.Drawing.Size(116, 24);
            this.sortByEmployee.TabIndex = 8;
            this.sortByEmployee.TabStop = true;
            this.sortByEmployee.Text = "By Employee";
            this.sortByEmployee.UseVisualStyleBackColor = true;
            // 
            // sortByCustomer
            // 
            this.sortByCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortByCustomer.AutoSize = true;
            this.sortByCustomer.Location = new System.Drawing.Point(577, 413);
            this.sortByCustomer.Name = "sortByCustomer";
            this.sortByCustomer.Size = new System.Drawing.Size(113, 24);
            this.sortByCustomer.TabIndex = 9;
            this.sortByCustomer.TabStop = true;
            this.sortByCustomer.Text = "By Customer";
            this.sortByCustomer.UseVisualStyleBackColor = true;
            // 
            // sortByOderDate
            // 
            this.sortByOderDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortByOderDate.AutoSize = true;
            this.sortByOderDate.Location = new System.Drawing.Point(577, 443);
            this.sortByOderDate.Name = "sortByOderDate";
            this.sortByOderDate.Size = new System.Drawing.Size(120, 24);
            this.sortByOderDate.TabIndex = 10;
            this.sortByOderDate.TabStop = true;
            this.sortByOderDate.Text = "By OrderDate";
            this.sortByOderDate.UseVisualStyleBackColor = true;
            // 
            // Filter
            // 
            this.Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Filter.Location = new System.Drawing.Point(518, 473);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(94, 29);
            this.Filter.TabIndex = 11;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Employee";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Supplier";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "OderDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(17, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Freight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "To";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(518, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Sort";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.oderDateFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.oderDateTo);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(496, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 118);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.freightTo);
            this.groupBox2.Controls.Add(this.freightFrom);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(496, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 118);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh.Location = new System.Drawing.Point(675, 473);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(94, 29);
            this.refresh.TabIndex = 24;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 510);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.sortByOderDate);
            this.Controls.Add(this.sortByCustomer);
            this.Controls.Add(this.sortByEmployee);
            this.Controls.Add(this.supplierFlt);
            this.Controls.Add(this.customerFlt);
            this.Controls.Add(this.employeeFlt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freightFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freightTo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox employeeFlt;
        private ComboBox customerFlt;
        private ComboBox supplierFlt;
        private DateTimePicker oderDateFrom;
        private DateTimePicker oderDateTo;
        private NumericUpDown freightFrom;
        private NumericUpDown freightTo;
        private RadioButton sortByEmployee;
        private RadioButton sortByCustomer;
        private RadioButton sortByOderDate;
        private Button Filter;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button refresh;
    }
}