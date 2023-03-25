namespace mvp_employees_manager.Views
{
    partial class EmployeeView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeView));
            leftBar = new Panel();
            label7 = new Label();
            btnImport = new Button();
            btnRemove = new Button();
            btnExport = new Button();
            btnAdd = new Button();
            numSalary = new NumericUpDown();
            label6 = new Label();
            cbPosition = new ComboBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tbDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tbSurname = new TextBox();
            label2 = new Label();
            tbName = new TextBox();
            label1 = new Label();
            listEmployees = new ListBox();
            errorProvider = new ErrorProvider(components);
            leftBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // leftBar
            // 
            leftBar.AutoScroll = true;
            leftBar.Controls.Add(label7);
            leftBar.Controls.Add(btnImport);
            leftBar.Controls.Add(btnRemove);
            leftBar.Controls.Add(btnExport);
            leftBar.Controls.Add(btnAdd);
            leftBar.Controls.Add(numSalary);
            leftBar.Controls.Add(label6);
            leftBar.Controls.Add(cbPosition);
            leftBar.Controls.Add(radioButton3);
            leftBar.Controls.Add(radioButton2);
            leftBar.Controls.Add(radioButton1);
            leftBar.Controls.Add(tbDate);
            leftBar.Controls.Add(label5);
            leftBar.Controls.Add(label4);
            leftBar.Controls.Add(label3);
            leftBar.Controls.Add(tbSurname);
            leftBar.Controls.Add(label2);
            leftBar.Controls.Add(tbName);
            leftBar.Controls.Add(label1);
            leftBar.Dock = DockStyle.Left;
            leftBar.Location = new Point(0, 0);
            leftBar.Name = "leftBar";
            leftBar.Size = new Size(360, 579);
            leftBar.TabIndex = 0;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(61, 20);
            label7.Name = "label7";
            label7.Size = new Size(234, 32);
            label7.TabIndex = 21;
            label7.Text = "Employee Manager";
            // 
            // btnImport
            // 
            btnImport.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnImport.Image = (Image)resources.GetObject("btnImport.Image");
            btnImport.Location = new Point(176, 507);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(135, 46);
            btnImport.TabIndex = 19;
            btnImport.Text = "Import";
            btnImport.TextAlign = ContentAlignment.MiddleRight;
            btnImport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImport.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.Image = (Image)resources.GetObject("btnRemove.Image");
            btnRemove.Location = new Point(36, 456);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(275, 45);
            btnRemove.TabIndex = 18;
            btnRemove.Text = "Remove Employee";
            btnRemove.TextAlign = ContentAlignment.MiddleRight;
            btnRemove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExport.Image = (Image)resources.GetObject("btnExport.Image");
            btnExport.Location = new Point(36, 507);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(134, 46);
            btnExport.TabIndex = 20;
            btnExport.Text = "Export";
            btnExport.TextAlign = ContentAlignment.MiddleRight;
            btnExport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(36, 405);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.No;
            btnAdd.Size = new Size(275, 45);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add Employee";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // numSalary
            // 
            numSalary.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numSalary.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numSalary.Location = new Point(122, 355);
            numSalary.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numSalary.Minimum = new decimal(new int[] { 3500, 0, 0, 0 });
            numSalary.Name = "numSalary";
            numSalary.Size = new Size(187, 29);
            numSalary.TabIndex = 16;
            numSalary.Value = new decimal(new int[] { 3500, 0, 0, 0 });
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 357);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 15;
            label6.Text = "Salary";
            // 
            // cbPosition
            // 
            cbPosition.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbPosition.FormattingEnabled = true;
            cbPosition.Items.AddRange(new object[] { "Back-end dev", "Front-end dev", "Full-stack dev", "UI/UX designer", "Software engineer", "Data scientist", "Network architect", "Desk analyst" });
            cbPosition.Location = new Point(122, 315);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(187, 29);
            cbPosition.TabIndex = 14;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(68, 283);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(250, 25);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "Contract for an indefinite period";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(68, 252);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(149, 25);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mandate contract";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(68, 221);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(197, 25);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Contract of employment";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // tbDate
            // 
            tbDate.DropDownAlign = LeftRightAlignment.Right;
            tbDate.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbDate.Format = DateTimePickerFormat.Short;
            tbDate.Location = new Point(121, 150);
            tbDate.Name = "tbDate";
            tbDate.RightToLeft = RightToLeft.No;
            tbDate.Size = new Size(188, 29);
            tbDate.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(36, 318);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 8;
            label5.Text = "Position";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 197);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 6;
            label4.Text = "Type of Contract:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 156);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 4;
            label3.Text = "Birth Date";
            // 
            // tbSurname
            // 
            tbSurname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbSurname.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbSurname.Location = new Point(122, 111);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(187, 29);
            tbSurname.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 114);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 2;
            label2.Text = "Surname";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(121, 71);
            tbName.Name = "tbName";
            tbName.Size = new Size(188, 29);
            tbName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 74);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // listEmployees
            // 
            listEmployees.BorderStyle = BorderStyle.None;
            listEmployees.Dock = DockStyle.Fill;
            listEmployees.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listEmployees.FormattingEnabled = true;
            listEmployees.HorizontalScrollbar = true;
            listEmployees.ItemHeight = 21;
            listEmployees.Location = new Point(360, 0);
            listEmployees.Margin = new Padding(0);
            listEmployees.Name = "listEmployees";
            listEmployees.Size = new Size(762, 579);
            listEmployees.TabIndex = 1;
            // 
            // errorProvider
            // 
            errorProvider.BlinkRate = 0;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // EmployeeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 579);
            Controls.Add(listEmployees);
            Controls.Add(leftBar);
            Name = "EmployeeView";
            Text = "EmployeeView";
            leftBar.ResumeLayout(false);
            leftBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftBar;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tbSurname;
        private Label label2;
        private TextBox tbName;
        private Label label1;
        private Label label7;
        private Button btnImport;
        private Button btnRemove;
        private Button btnExport;
        private Button btnAdd;
        private NumericUpDown numSalary;
        private Label label6;
        private ComboBox cbPosition;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker tbDate;
        private ListBox listEmployees;
        private ErrorProvider errorProvider;
    }
}