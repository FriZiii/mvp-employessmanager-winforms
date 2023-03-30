namespace mvp_employees_manager.Views
{
    partial class EditView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditView));
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
            btnConfirm = new Button();
            btnCancel = new Button();
            label7 = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // numSalary
            // 
            numSalary.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numSalary.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numSalary.Location = new Point(110, 350);
            numSalary.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numSalary.Minimum = new decimal(new int[] { 3500, 0, 0, 0 });
            numSalary.Name = "numSalary";
            numSalary.Size = new Size(187, 29);
            numSalary.TabIndex = 30;
            numSalary.Value = new decimal(new int[] { 3500, 0, 0, 0 });
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 352);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 29;
            label6.Text = "Salary";
            // 
            // cbPosition
            // 
            cbPosition.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbPosition.FormattingEnabled = true;
            cbPosition.Items.AddRange(new object[] { "Back-end dev", "Front-end dev", "Full-stack dev", "UI/UX designer", "Software engineer", "Data scientist", "Network architect", "Desk analyst" });
            cbPosition.Location = new Point(110, 310);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(187, 29);
            cbPosition.TabIndex = 28;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(56, 278);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(250, 25);
            radioButton3.TabIndex = 27;
            radioButton3.TabStop = true;
            radioButton3.Text = "Contract for an indefinite period";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(56, 247);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(149, 25);
            radioButton2.TabIndex = 26;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mandate contract";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(56, 216);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(197, 25);
            radioButton1.TabIndex = 25;
            radioButton1.TabStop = true;
            radioButton1.Text = "Contract of employment";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // tbDate
            // 
            tbDate.DropDownAlign = LeftRightAlignment.Right;
            tbDate.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbDate.Format = DateTimePickerFormat.Short;
            tbDate.Location = new Point(109, 145);
            tbDate.Name = "tbDate";
            tbDate.RightToLeft = RightToLeft.No;
            tbDate.Size = new Size(188, 29);
            tbDate.TabIndex = 24;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 313);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 23;
            label5.Text = "Position";
            // 
            // labelTypeOfContract
            // 
            labelTypeOfContract.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTypeOfContract.AutoSize = true;
            labelTypeOfContract.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTypeOfContract.Location = new Point(24, 192);
            labelTypeOfContract.Name = "labelTypeOfContract";
            labelTypeOfContract.Size = new Size(126, 21);
            labelTypeOfContract.TabIndex = 22;
            labelTypeOfContract.Text = "Type of Contract:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 151);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 21;
            label3.Text = "Birth Date";
            // 
            // tbSurname
            // 
            tbSurname.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbSurname.Location = new Point(110, 106);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(187, 29);
            tbSurname.TabIndex = 20;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 109);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 19;
            label2.Text = "Surname";
            // 
            // tbName
            // 
            tbName.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(109, 66);
            tbName.Name = "tbName";
            tbName.Size = new Size(188, 29);
            tbName.TabIndex = 18;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 69);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // btnConfirm
            // 
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirm.Image = (Image)resources.GetObject("btnConfirm.Image");
            btnConfirm.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirm.Location = new Point(164, 402);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.RightToLeft = RightToLeft.No;
            btnConfirm.Size = new Size(133, 46);
            btnConfirm.TabIndex = 33;
            btnConfirm.Text = "Confirm";
            btnConfirm.TextAlign = ContentAlignment.MiddleRight;
            btnConfirm.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(24, 402);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 46);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(65, 17);
            label7.Name = "label7";
            label7.Size = new Size(201, 32);
            label7.TabIndex = 35;
            label7.Text = "Employee Editor";
            // 
            // errorProvider
            // 
            errorProvider.BlinkRate = 0;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            errorProvider.Icon = (Icon)resources.GetObject("errorProvider.Icon");
            // 
            // EditView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(326, 464);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(numSalary);
            Controls.Add(label6);
            Controls.Add(cbPosition);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(tbDate);
            Controls.Add(label5);
            Controls.Add(labelTypeOfContract);
            Controls.Add(label3);
            Controls.Add(tbSurname);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Name = "EditView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditView";
            ((System.ComponentModel.ISupportInitialize)numSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numSalary;
        private Label label6;
        private ComboBox cbPosition;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker tbDate;
        private Label label5;
        private Label labelTypeOfContract;
        private Label label3;
        private TextBox tbSurname;
        private Label label2;
        private TextBox tbName;
        private Label label1;
        private Button btnConfirm;
        private Button btnCancel;
        private Label label7;
        private ErrorProvider errorProvider;
    }
}