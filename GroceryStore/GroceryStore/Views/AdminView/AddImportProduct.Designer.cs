namespace GroceryStore.Views.AdminView
{
    partial class AddImportProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddImportProduct));
            dataGridViewQuantity = new DataGridView();
            btnAdd = new Button();
            btnSave = new Button();
            btnBack = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQuantity).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewQuantity
            // 
            dataGridViewQuantity.AllowUserToAddRows = false;
            dataGridViewQuantity.AllowUserToDeleteRows = false;
            dataGridViewQuantity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewQuantity.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewQuantity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQuantity.Location = new Point(11, 73);
            dataGridViewQuantity.Margin = new Padding(2);
            dataGridViewQuantity.Name = "dataGridViewQuantity";
            dataGridViewQuantity.RowHeadersVisible = false;
            dataGridViewQuantity.RowHeadersWidth = 62;
            dataGridViewQuantity.Size = new Size(838, 417);
            dataGridViewQuantity.TabIndex = 0;
            dataGridViewQuantity.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnAdd.Location = new Point(167, 504);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 39);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(560, 504);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 39);
            btnSave.TabIndex = 2;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(795, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(54, 56);
            btnBack.TabIndex = 76;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(275, 32);
            label1.TabIndex = 77;
            label1.Text = "Bảng lượng hàng nhập";
            // 
            // AddImportProduct
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(861, 554);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewQuantity);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AddImportProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ImportProduct";
            ((System.ComponentModel.ISupportInitialize)dataGridViewQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewQuantity;
        private Button btnAdd;
        private Button btnSave;
        private Button btnBack;
        private Label label1;
    }
}