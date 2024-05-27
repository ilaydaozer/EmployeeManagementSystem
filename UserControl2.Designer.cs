namespace EmployeeManagementSystem
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_emp_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add_emp_fullName = new System.Windows.Forms.TextBox();
            this.add_emp_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add_emp_position = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.add_emp_phoneNumber = new System.Windows.Forms.TextBox();
            this.add_emp_image = new System.Windows.Forms.PictureBox();
            this.add_emp_import_btn = new System.Windows.Forms.Button();
            this.add_emp_add_btn = new System.Windows.Forms.Button();
            this.add_emp_update_btn = new System.Windows.Forms.Button();
            this.add_emp_delete_btn = new System.Windows.Forms.Button();
            this.add_emp_clearr_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.add_emp_status = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_emp_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 279);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(798, 212);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee\'s Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID : ";
            // 
            // add_emp_id
            // 
            this.add_emp_id.Location = new System.Drawing.Point(162, 340);
            this.add_emp_id.Name = "add_emp_id";
            this.add_emp_id.Size = new System.Drawing.Size(121, 20);
            this.add_emp_id.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name : ";
            // 
            // add_emp_fullName
            // 
            this.add_emp_fullName.Location = new System.Drawing.Point(162, 377);
            this.add_emp_fullName.Name = "add_emp_fullName";
            this.add_emp_fullName.Size = new System.Drawing.Size(121, 20);
            this.add_emp_fullName.TabIndex = 5;
            // 
            // add_emp_gender
            // 
            this.add_emp_gender.FormattingEnabled = true;
            this.add_emp_gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.add_emp_gender.Location = new System.Drawing.Point(162, 413);
            this.add_emp_gender.Name = "add_emp_gender";
            this.add_emp_gender.Size = new System.Drawing.Size(121, 21);
            this.add_emp_gender.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Position : ";
            // 
            // add_emp_position
            // 
            this.add_emp_position.FormattingEnabled = true;
            this.add_emp_position.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e"});
            this.add_emp_position.Location = new System.Drawing.Point(420, 376);
            this.add_emp_position.Name = "add_emp_position";
            this.add_emp_position.Size = new System.Drawing.Size(121, 21);
            this.add_emp_position.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phone  Number : ";
            // 
            // add_emp_phoneNumber
            // 
            this.add_emp_phoneNumber.Location = new System.Drawing.Point(420, 340);
            this.add_emp_phoneNumber.Name = "add_emp_phoneNumber";
            this.add_emp_phoneNumber.Size = new System.Drawing.Size(121, 20);
            this.add_emp_phoneNumber.TabIndex = 9;
            // 
            // add_emp_image
            // 
            this.add_emp_image.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_emp_image.Location = new System.Drawing.Point(734, 325);
            this.add_emp_image.Name = "add_emp_image";
            this.add_emp_image.Size = new System.Drawing.Size(100, 99);
            this.add_emp_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.add_emp_image.TabIndex = 14;
            this.add_emp_image.TabStop = false;
            // 
            // add_emp_import_btn
            // 
            this.add_emp_import_btn.Location = new System.Drawing.Point(747, 450);
            this.add_emp_import_btn.Name = "add_emp_import_btn";
            this.add_emp_import_btn.Size = new System.Drawing.Size(75, 23);
            this.add_emp_import_btn.TabIndex = 15;
            this.add_emp_import_btn.Text = "Import";
            this.add_emp_import_btn.UseVisualStyleBackColor = true;
            this.add_emp_import_btn.Click += new System.EventHandler(this.add_emp_import_btn_Click);
            // 
            // add_emp_add_btn
            // 
            this.add_emp_add_btn.Location = new System.Drawing.Point(135, 471);
            this.add_emp_add_btn.Name = "add_emp_add_btn";
            this.add_emp_add_btn.Size = new System.Drawing.Size(89, 53);
            this.add_emp_add_btn.TabIndex = 16;
            this.add_emp_add_btn.Text = "Add";
            this.add_emp_add_btn.UseVisualStyleBackColor = true;
            this.add_emp_add_btn.Click += new System.EventHandler(this.add_emp_add_btn_Click);
            // 
            // add_emp_update_btn
            // 
            this.add_emp_update_btn.Location = new System.Drawing.Point(230, 471);
            this.add_emp_update_btn.Name = "add_emp_update_btn";
            this.add_emp_update_btn.Size = new System.Drawing.Size(89, 53);
            this.add_emp_update_btn.TabIndex = 17;
            this.add_emp_update_btn.Text = "Update";
            this.add_emp_update_btn.UseVisualStyleBackColor = true;
            this.add_emp_update_btn.Click += new System.EventHandler(this.add_emp_update_btn_Click);
            // 
            // add_emp_delete_btn
            // 
            this.add_emp_delete_btn.Location = new System.Drawing.Point(325, 471);
            this.add_emp_delete_btn.Name = "add_emp_delete_btn";
            this.add_emp_delete_btn.Size = new System.Drawing.Size(89, 53);
            this.add_emp_delete_btn.TabIndex = 18;
            this.add_emp_delete_btn.Text = "Delete";
            this.add_emp_delete_btn.UseVisualStyleBackColor = true;
            this.add_emp_delete_btn.Click += new System.EventHandler(this.add_emp_delete_btn_Click);
            // 
            // add_emp_clearr_btn
            // 
            this.add_emp_clearr_btn.Location = new System.Drawing.Point(420, 471);
            this.add_emp_clearr_btn.Name = "add_emp_clearr_btn";
            this.add_emp_clearr_btn.Size = new System.Drawing.Size(89, 53);
            this.add_emp_clearr_btn.TabIndex = 19;
            this.add_emp_clearr_btn.Text = "Clear";
            this.add_emp_clearr_btn.UseVisualStyleBackColor = true;
            this.add_emp_clearr_btn.Click += new System.EventHandler(this.add_emp_clearr_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Status : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // add_emp_status
            // 
            this.add_emp_status.FormattingEnabled = true;
            this.add_emp_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.add_emp_status.Location = new System.Drawing.Point(420, 413);
            this.add_emp_status.Name = "add_emp_status";
            this.add_emp_status.Size = new System.Drawing.Size(121, 21);
            this.add_emp_status.TabIndex = 20;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.add_emp_status);
            this.Controls.Add(this.add_emp_clearr_btn);
            this.Controls.Add(this.add_emp_delete_btn);
            this.Controls.Add(this.add_emp_update_btn);
            this.Controls.Add(this.add_emp_add_btn);
            this.Controls.Add(this.add_emp_import_btn);
            this.Controls.Add(this.add_emp_image);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add_emp_position);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.add_emp_phoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.add_emp_gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add_emp_fullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add_emp_id);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(873, 563);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_emp_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox add_emp_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox add_emp_fullName;
        private System.Windows.Forms.ComboBox add_emp_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox add_emp_position;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox add_emp_phoneNumber;
        private System.Windows.Forms.PictureBox add_emp_image;
        private System.Windows.Forms.Button add_emp_import_btn;
        private System.Windows.Forms.Button add_emp_add_btn;
        private System.Windows.Forms.Button add_emp_update_btn;
        private System.Windows.Forms.Button add_emp_delete_btn;
        private System.Windows.Forms.Button add_emp_clearr_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox add_emp_status;
    }
}
