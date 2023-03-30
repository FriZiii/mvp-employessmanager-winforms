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
            btnEdit = new Button();
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
            labelTypeOfContract = new Label();
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
            leftBar.BackColor = Color.White;
            leftBar.BorderStyle = BorderStyle.FixedSingle;
            leftBar.Controls.Add(btnEdit);
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
            leftBar.Controls.Add(labelTypeOfContract);
            leftBar.Controls.Add(label3);
            leftBar.Controls.Add(tbSurname);
            leftBar.Controls.Add(label2);
            leftBar.Controls.Add(tbName);
            leftBar.Controls.Add(label1);
            leftBar.Dock = DockStyle.Left;
            leftBar.Location = new Point(0, 0);
            leftBar.Name = "leftBar";
            leftBar.Size = new Size(344, 609);
            leftBar.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(34, 450);
            btnEdit.Name = "btnEdit";
            btnEdit.RightToLeft = RightToLeft.No;
            btnEdit.Size = new Size(273, 45);
            btnEdit.TabIndex = 22;
            btnEdit.Text = "Edit Employee";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(56, 18);
            label7.Name = "label7";
            label7.Size = new Size(234, 32);
            label7.TabIndex = 21;
            label7.Text = "Employee Manager";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnImport
            // 
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnImport.Image = (Image)resources.GetObject("btnImport.Image");
            btnImport.ImageAlign = ContentAlignment.MiddleLeft;
            btnImport.Location = new Point(174, 552);
            btnImport.Name = "btnImport";
            btnImport.RightToLeft = RightToLeft.No;
            btnImport.Size = new Size(133, 46);
            btnImport.TabIndex = 19;
            btnImport.Text = "Import";
            btnImport.TextAlign = ContentAlignment.MiddleRight;
            btnImport.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnImport.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.Image = (Image)resources.GetObject("btnRemove.Image");
            btnRemove.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemove.Location = new Point(34, 501);
            btnRemove.Name = "btnRemove";
            btnRemove.RightToLeft = RightToLeft.No;
            btnRemove.Size = new Size(273, 45);
            btnRemove.TabIndex = 18;
            btnRemove.Text = "Remove Employee";
            btnRemove.TextAlign = ContentAlignment.MiddleRight;
            btnRemove.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExport.Image = (Image)resources.GetObject("btnExport.Image");
            btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnExport.Location = new Point(34, 552);
            btnExport.Name = "btnExport";
            btnExport.RightToLeft = RightToLeft.No;
            btnExport.Size = new Size(133, 46);
            btnExport.TabIndex = 20;
            btnExport.Text = "Export";
            btnExport.TextAlign = ContentAlignment.MiddleRight;
            btnExport.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(34, 399);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.No;
            btnAdd.Size = new Size(273, 45);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add Employee";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // numSalary
            // 
            numSalary.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numSalary.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numSalary.Location = new Point(120, 353);
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
            label6.Location = new Point(34, 355);
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
            cbPosition.Location = new Point(120, 313);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(187, 29);
            cbPosition.TabIndex = 14;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(66, 281);
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
            radioButton2.Location = new Point(66, 250);
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
            radioButton1.Location = new Point(66, 219);
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
            tbDate.Location = new Point(119, 148);
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
            label5.Location = new Point(34, 316);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 8;
            label5.Text = "Position";
            // 
            // labelTypeOfContract
            // 
            labelTypeOfContract.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTypeOfContract.AutoSize = true;
            labelTypeOfContract.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTypeOfContract.Location = new Point(34, 195);
            labelTypeOfContract.Name = "labelTypeOfContract";
            labelTypeOfContract.Size = new Size(126, 21);
            labelTypeOfContract.TabIndex = 6;
            labelTypeOfContract.Text = "Type of Contract:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 154);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 4;
            label3.Text = "Birth Date";
            // 
            // tbSurname
            // 
            tbSurname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbSurname.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbSurname.Location = new Point(120, 109);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(187, 29);
            tbSurname.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 112);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 2;
            label2.Text = "Surname";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(119, 69);
            tbName.Name = "tbName";
            tbName.Size = new Size(188, 29);
            tbName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 72);
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
            listEmployees.Location = new Point(344, 0);
            listEmployees.Margin = new Padding(0);
            listEmployees.Name = "listEmployees";
            listEmployees.Size = new Size(630, 609);
            listEmployees.TabIndex = 1;
            // 
            // errorProvider
            // 
            errorProvider.BlinkRate = 0;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            errorProvider.Icon = (Icon)resources.GetObject("errorProvider.Icon");
            // 
            // EmployeeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 609);
            Controls.Add(listEmployees);
            Controls.Add(leftBar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeeView";
            Text = "Employee Manager";
            leftBar.ResumeLayout(false);
            leftBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftBar;
        private Label label5;
        private Label labelTypeOfContract;
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
        private Button btnEdit;
    }
}