namespace GroceryStore.Views
{
    partial class ChooseCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseCustomer));
            label1 = new Label();
            tableCustomerList = new DataGridView();
            colCustomerID = new DataGridViewTextBoxColumn();
            colCustomerName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnSearch = new Button();
            txbSearch = new TextBox();
            btnReturn = new Button();
            btnChooseCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)tableCustomerList).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 29);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 70;
            label1.Text = "Chọn khách hàng";
            // 
            // tableCustomerList
            // 
            tableCustomerList.AllowUserToAddRows = false;
            tableCustomerList.AllowUserToDeleteRows = false;
            tableCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableCustomerList.Columns.AddRange(new DataGridViewColumn[] { colCustomerID, colCustomerName, colPhone });
            tableCustomerList.Location = new Point(40, 75);
            tableCustomerList.MultiSelect = false;
            tableCustomerList.Name = "tableCustomerList";
            tableCustomerList.ReadOnly = true;
            tableCustomerList.RowHeadersVisible = false;
            tableCustomerList.RowHeadersWidth = 51;
            tableCustomerList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableCustomerList.Size = new Size(489, 399);
            tableCustomerList.TabIndex = 71;
            // 
            // colCustomerID
            // 
            colCustomerID.HeaderText = "ID";
            colCustomerID.MinimumWidth = 6;
            colCustomerID.Name = "colCustomerID";
            colCustomerID.ReadOnly = true;
            colCustomerID.Width = 60;
            // 
            // colCustomerName
            // 
            colCustomerName.HeaderText = "Tên";
            colCustomerName.MinimumWidth = 6;
            colCustomerName.Name = "colCustomerName";
            colCustomerName.ReadOnly = true;
            colCustomerName.Width = 300;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Số điện thoại";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.Width = 126;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(txbSearch);
            panel3.Location = new Point(235, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(294, 34);
            panel3.TabIndex = 72;
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(262, 1);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(32, 30);
            btnSearch.TabIndex = 1;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txbSearch
            // 
            txbSearch.Font = new Font("Tahoma", 10F);
            txbSearch.Location = new Point(3, 3);
            txbSearch.Name = "txbSearch";
            txbSearch.PlaceholderText = "Find Customer Here";
            txbSearch.Size = new Size(262, 28);
            txbSearch.TabIndex = 0;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = SystemColors.ActiveBorder;
            btnReturn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(50, 495);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(201, 49);
            btnReturn.TabIndex = 74;
            btnReturn.Text = " Trở về";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnChooseCustomer
            // 
            btnChooseCustomer.BackColor = SystemColors.ActiveCaption;
            btnChooseCustomer.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChooseCustomer.Location = new Point(314, 495);
            btnChooseCustomer.Name = "btnChooseCustomer";
            btnChooseCustomer.Size = new Size(201, 49);
            btnChooseCustomer.TabIndex = 73;
            btnChooseCustomer.Text = " Chọn";
            btnChooseCustomer.UseVisualStyleBackColor = false;
            btnChooseCustomer.Click += btnChooseCustomer_Click;
            // 
            // ChooseCustomer
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(600, 600);
            Controls.Add(btnReturn);
            Controls.Add(btnChooseCustomer);
            Controls.Add(panel3);
            Controls.Add(tableCustomerList);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChooseCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChooseCustomer";
            Load += ChooseCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)tableCustomerList).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView tableCustomerList;
        private Panel panel3;
        private Button btnSearch;
        private TextBox txbSearch;
        private Button btnReturn;
        private Button btnChooseCustomer;
        private DataGridViewTextBoxColumn colCustomerID;
        private DataGridViewTextBoxColumn colCustomerName;
        private DataGridViewTextBoxColumn colPhone;
    }
}