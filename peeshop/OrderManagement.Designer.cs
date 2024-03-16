namespace peeshop
{
    partial class OrderManagement
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
            dgv = new DataGridView();
            tbCustomerName = new TextBox();
            cbStaff = new ComboBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 338);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 82;
            dgv.RowTemplate.Height = 41;
            dgv.Size = new Size(2031, 897);
            dgv.TabIndex = 0;
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(59, 96);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(350, 39);
            tbCustomerName.TabIndex = 1;
            // 
            // cbStaff
            // 
            cbStaff.FormattingEnabled = true;
            cbStaff.Location = new Point(472, 95);
            cbStaff.Name = "cbStaff";
            cbStaff.Size = new Size(348, 40);
            cbStaff.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(961, 92);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(242, 46);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // OrderManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2055, 1247);
            Controls.Add(btnSearch);
            Controls.Add(cbStaff);
            Controls.Add(tbCustomerName);
            Controls.Add(dgv);
            Name = "OrderManagement";
            Text = "OrderManagement";
            Load += OrderManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private TextBox tbCustomerName;
        private ComboBox cbStaff;
        private Button btnSearch;
    }
}