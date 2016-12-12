namespace ForTesting
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boorowControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.recordDateDataGridViewTextBoxColumn,
            this.shelfDataGridViewTextBoxColumn,
            this.activeStockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1190, 697);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wellcome To Özyegin University Library Management System";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(551, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(639, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(460, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.boorowControlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem1,
            this.bookToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.studentToolStripMenuItem.Text = "Administration";
            // 
            // studentToolStripMenuItem1
            // 
            this.studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            this.studentToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.studentToolStripMenuItem1.Text = "Student";
            this.studentToolStripMenuItem1.Click += new System.EventHandler(this.studentToolStripMenuItem1_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // boorowControlToolStripMenuItem
            // 
            this.boorowControlToolStripMenuItem.Name = "boorowControlToolStripMenuItem";
            this.boorowControlToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.boorowControlToolStripMenuItem.Text = "BoorowControl";
            this.boorowControlToolStripMenuItem.Click += new System.EventHandler(this.boorowControlToolStripMenuItem_Click);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(ForTesting.Book);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 200;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // recordDateDataGridViewTextBoxColumn
            // 
            this.recordDateDataGridViewTextBoxColumn.DataPropertyName = "recordDate";
            this.recordDateDataGridViewTextBoxColumn.HeaderText = "recordDate";
            this.recordDateDataGridViewTextBoxColumn.Name = "recordDateDataGridViewTextBoxColumn";
            this.recordDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // shelfDataGridViewTextBoxColumn
            // 
            this.shelfDataGridViewTextBoxColumn.DataPropertyName = "shelf";
            this.shelfDataGridViewTextBoxColumn.HeaderText = "shelf";
            this.shelfDataGridViewTextBoxColumn.Name = "shelfDataGridViewTextBoxColumn";
            // 
            // activeStockDataGridViewTextBoxColumn
            // 
            this.activeStockDataGridViewTextBoxColumn.DataPropertyName = "activeStock";
            this.activeStockDataGridViewTextBoxColumn.HeaderText = "activeStock";
            this.activeStockDataGridViewTextBoxColumn.Name = "activeStockDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 801);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MinimumSize = new System.Drawing.Size(774, 747);
            this.Name = "Form1";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boorowControlToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeStockDataGridViewTextBoxColumn;
    }
}

