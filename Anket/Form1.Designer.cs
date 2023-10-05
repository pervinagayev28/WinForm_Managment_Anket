namespace Anket
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
            tbox_searcById = new TextBox();
            panel1 = new Panel();
            label9 = new Label();
            btn_load = new Button();
            pageSetupDialog1 = new PageSetupDialog();
            pageSetupDialog2 = new PageSetupDialog();
            pageSetupDialog3 = new PageSetupDialog();
            panel2 = new Panel();
            btn_sort = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btn_save = new Button();
            tbox_name = new TextBox();
            tbox_gmail = new TextBox();
            tbox_phone = new TextBox();
            tbox_surname = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel3 = new Panel();
            label8 = new Label();
            lbl_error = new Label();
            gridview_users = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            surname = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            gmail = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridview_users).BeginInit();
            SuspendLayout();
            // 
            // tbox_searcById
            // 
            tbox_searcById.BackColor = Color.Crimson;
            tbox_searcById.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbox_searcById.Location = new Point(1180, -1);
            tbox_searcById.Margin = new Padding(3, 4, 3, 4);
            tbox_searcById.Name = "tbox_searcById";
            tbox_searcById.Size = new Size(99, 30);
            tbox_searcById.TabIndex = 1000;
            tbox_searcById.Text = "user_id";
            tbox_searcById.TextAlign = HorizontalAlignment.Center;
            tbox_searcById.Click += tbox_searcById_Click;
            tbox_searcById.TextChanged += label9_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Pink;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(tbox_searcById);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1297, 33);
            panel1.TabIndex = 1000;
            // 
            // label9
            // 
            label9.Font = new Font("Bauhaus 93", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(485, 0);
            label9.Name = "label9";
            label9.Size = new Size(286, 37);
            label9.TabIndex = 1001;
            label9.Text = "ManagmentAnket";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click_1;
            // 
            // btn_load
            // 
            btn_load.BackColor = Color.Crimson;
            btn_load.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_load.Location = new Point(1180, 0);
            btn_load.Margin = new Padding(3, 4, 3, 4);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(105, 67);
            btn_load.TabIndex = 1000;
            btn_load.Text = "load";
            btn_load.UseVisualStyleBackColor = false;
            btn_load.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SpringGreen;
            panel2.Controls.Add(btn_sort);
            panel2.Controls.Add(btn_load);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 37);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1297, 73);
            panel2.TabIndex = 1000;
            panel2.Paint += panel2_Paint;
            // 
            // btn_sort
            // 
            btn_sort.BackColor = Color.Crimson;
            btn_sort.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sort.Location = new Point(740, 0);
            btn_sort.Margin = new Padding(3, 4, 3, 4);
            btn_sort.Name = "btn_sort";
            btn_sort.Size = new Size(418, 67);
            btn_sort.TabIndex = 1001;
            btn_sort.Text = "sort by Id";
            btn_sort.UseVisualStyleBackColor = false;
            btn_sort.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(517, 0);
            label1.Name = "label1";
            label1.Size = new Size(228, 67);
            label1.TabIndex = 1000;
            label1.Text = "Anket";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Lime;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 142);
            label2.Name = "label2";
            label2.Size = new Size(118, 36);
            label2.TabIndex = 3;
            label2.Text = "username";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Lime;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 249);
            label3.Name = "label3";
            label3.Size = new Size(118, 37);
            label3.TabIndex = 4;
            label3.Text = "phone";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Lime;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(50, 193);
            label4.Name = "label4";
            label4.Size = new Size(118, 37);
            label4.TabIndex = 5;
            label4.Text = "surname";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Lime;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(50, 305);
            label5.Name = "label5";
            label5.Size = new Size(118, 37);
            label5.TabIndex = 6;
            label5.Text = "gmail";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.Lime;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(50, 366);
            label6.Name = "label6";
            label6.Size = new Size(118, 37);
            label6.TabIndex = 6;
            label6.Text = "bir.DATE";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.Lime;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(50, 426);
            label7.Name = "label7";
            label7.Size = new Size(118, 37);
            label7.TabIndex = 8;
            label7.Text = "gender";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Crimson;
            btn_save.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_save.Location = new Point(50, 507);
            btn_save.Margin = new Padding(3, 4, 3, 4);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(559, 56);
            btn_save.TabIndex = 9;
            btn_save.Text = "save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // tbox_name
            // 
            tbox_name.BackColor = SystemColors.ScrollBar;
            tbox_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbox_name.Location = new Point(222, 142);
            tbox_name.Margin = new Padding(3, 4, 3, 4);
            tbox_name.Name = "tbox_name";
            tbox_name.Size = new Size(361, 34);
            tbox_name.TabIndex = 0;
            tbox_name.TextChanged += textBox2_TextChanged;
            // 
            // tbox_gmail
            // 
            tbox_gmail.BackColor = SystemColors.ScrollBar;
            tbox_gmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbox_gmail.Location = new Point(222, 305);
            tbox_gmail.Margin = new Padding(3, 4, 3, 4);
            tbox_gmail.Name = "tbox_gmail";
            tbox_gmail.Size = new Size(361, 34);
            tbox_gmail.TabIndex = 3;
            tbox_gmail.TextChanged += textBox4_TextChanged;
            // 
            // tbox_phone
            // 
            tbox_phone.BackColor = SystemColors.ScrollBar;
            tbox_phone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbox_phone.Location = new Point(222, 249);
            tbox_phone.Margin = new Padding(3, 4, 3, 4);
            tbox_phone.Name = "tbox_phone";
            tbox_phone.Size = new Size(361, 34);
            tbox_phone.TabIndex = 2;
            // 
            // tbox_surname
            // 
            tbox_surname.BackColor = SystemColors.ScrollBar;
            tbox_surname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbox_surname.Location = new Point(222, 193);
            tbox_surname.Margin = new Padding(3, 4, 3, 4);
            tbox_surname.Name = "tbox_surname";
            tbox_surname.Size = new Size(361, 34);
            tbox_surname.TabIndex = 1;
            tbox_surname.TextChanged += textBox6_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(222, 366);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(361, 34);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // radioButton1
            // 
            radioButton1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(420, 422);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(165, 40);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "female";
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(222, 422);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(165, 45);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "male";
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Pink;
            panel3.Controls.Add(label8);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 597);
            panel3.Name = "panel3";
            panel3.Size = new Size(1297, 51);
            panel3.TabIndex = 18;
            panel3.Paint += panel3_Paint;
            // 
            // label8
            // 
            label8.Font = new Font("Bauhaus 93", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(485, 0);
            label8.Name = "label8";
            label8.Size = new Size(286, 51);
            label8.TabIndex = 19;
            label8.Text = "ManagmentAnket";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // lbl_error
            // 
            lbl_error.ForeColor = Color.Crimson;
            lbl_error.Location = new Point(222, 471);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(326, 38);
            lbl_error.TabIndex = 19;
            lbl_error.Click += label9_Click;
            // 
            // gridview_users
            // 
            gridview_users.BackgroundColor = SystemColors.Window;
            gridview_users.BorderStyle = BorderStyle.Fixed3D;
            gridview_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridview_users.Columns.AddRange(new DataGridViewColumn[] { Id, name, surname, phone, gmail, date, gender });
            gridview_users.Location = new Point(675, 117);
            gridview_users.Name = "gridview_users";
            gridview_users.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            gridview_users.RowHeadersWidth = 23;
            gridview_users.RowTemplate.Height = 29;
            gridview_users.ShowCellToolTips = false;
            gridview_users.ShowEditingIcon = false;
            gridview_users.Size = new Size(622, 453);
            gridview_users.TabIndex = 1001;
            gridview_users.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // name
            // 
            name.HeaderText = "name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // surname
            // 
            surname.HeaderText = "surname";
            surname.MinimumWidth = 6;
            surname.Name = "surname";
            surname.Width = 125;
            // 
            // phone
            // 
            phone.HeaderText = "phone";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.Width = 125;
            // 
            // gmail
            // 
            gmail.HeaderText = "gmail";
            gmail.MinimumWidth = 6;
            gmail.Name = "gmail";
            gmail.Width = 125;
            // 
            // date
            // 
            date.HeaderText = "date";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.Width = 125;
            // 
            // gender
            // 
            gender.HeaderText = "gender";
            gender.MinimumWidth = 6;
            gender.Name = "gender";
            gender.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1297, 648);
            Controls.Add(gridview_users);
            Controls.Add(lbl_error);
            Controls.Add(panel3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbox_surname);
            Controls.Add(tbox_phone);
            Controls.Add(tbox_gmail);
            Controls.Add(tbox_name);
            Controls.Add(btn_save);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridview_users).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbox_searcById;
        private Panel panel1;
        private Button btn_load;
        private PageSetupDialog pageSetupDialog1;
        private PageSetupDialog pageSetupDialog2;
        private PageSetupDialog pageSetupDialog3;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btn_save;
        private TextBox tbox_name;
        private TextBox tbox_gmail;
        private TextBox tbox_phone;
        private TextBox tbox_surname;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel panel3;
        private Label label8;
        private Label lbl_error;
        private DataGridView gridview_users;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn surname;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn gmail;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn gender;
        private Label label9;
        private Button btn_sort;
    }
}