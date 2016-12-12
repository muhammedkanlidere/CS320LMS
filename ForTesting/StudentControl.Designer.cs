namespace ForTesting
{
    partial class StudentControl
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
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.scodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfRecordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Maroon;
            this.lblWarning.Location = new System.Drawing.Point(49, 649);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(392, 22);
            this.lblWarning.TabIndex = 23;
            this.lblWarning.Text = "Please press the save button to complete your transaction...";
            this.lblWarning.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Minion Pro SmBd", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(860, 630);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 41);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Minion Pro SmBd", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(743, 630);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 41);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Minion Pro SmBd", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(622, 630);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 41);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(311, 247);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(647, 26);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(231, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Search :";
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Minion Pro SmBd", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(503, 630);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 41);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dateOfRecordDataGridViewTextBoxColumn,
            this.borrowDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(946, 333);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // scodeDataGridViewTextBoxColumn
            // 
            this.scodeDataGridViewTextBoxColumn.DataPropertyName = "scode";
            this.scodeDataGridViewTextBoxColumn.HeaderText = "scode";
            this.scodeDataGridViewTextBoxColumn.Name = "scodeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // dateOfRecordDataGridViewTextBoxColumn
            // 
            this.dateOfRecordDataGridViewTextBoxColumn.DataPropertyName = "dateOfRecord";
            this.dateOfRecordDataGridViewTextBoxColumn.HeaderText = "dateOfRecord";
            this.dateOfRecordDataGridViewTextBoxColumn.Name = "dateOfRecordDataGridViewTextBoxColumn";
            // 
            // borrowDataGridViewTextBoxColumn
            // 
            this.borrowDataGridViewTextBoxColumn.DataPropertyName = "Borrow";
            this.borrowDataGridViewTextBoxColumn.HeaderText = "Borrow";
            this.borrowDataGridViewTextBoxColumn.Name = "borrowDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(ForTesting.Student);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtMail);
            this.panel.Controls.Add(this.txtTel);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.txtSurname);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtScode);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(12, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(882, 197);
            this.panel.TabIndex = 15;
            // 
            // txtMail
            // 
            this.txtMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "email", true));
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(127, 142);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(583, 26);
            this.txtMail.TabIndex = 12;
            // 
            // txtTel
            // 
            this.txtTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "tel", true));
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel.Location = new System.Drawing.Point(127, 110);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(583, 26);
            this.txtTel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(49, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(65, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tel :";
            // 
            // txtSurname
            // 
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "surname", true));
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.Location = new System.Drawing.Point(127, 78);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(583, 26);
            this.txtSurname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname :";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "name", true));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(127, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(583, 26);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // txtScode
            // 
            this.txtScode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "scode", true));
            this.txtScode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtScode.Location = new System.Drawing.Point(127, 14);
            this.txtScode.Name = "txtScode";
            this.txtScode.Size = new System.Drawing.Size(234, 26);
            this.txtScode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scode :";
            // 
            // StudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 701);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(990, 740);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(990, 740);
            this.Name = "StudentControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentControl_FormClosing);
            this.Load += new System.EventHandler(this.StudentControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn scodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfRecordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}