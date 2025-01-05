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
            dataGridViewQuantity.Location = new Point(10, 10);
            dataGridViewQuantity.Margin = new Padding(2);
            dataGridViewQuantity.Name = "dataGridViewQuantity";
            dataGridViewQuantity.RowHeadersVisible = false;
            dataGridViewQuantity.RowHeadersWidth = 62;
            dataGridViewQuantity.Size = new Size(508, 429);
            dataGridViewQuantity.TabIndex = 0;
            dataGridViewQuantity.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnAdd.Location = new Point(561, 199);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 27);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(560, 262);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 27);
            btnSave.TabIndex = 2;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(587, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(63, 63);
            btnBack.TabIndex = 76;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AddImportProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 489);
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
        }

        #endregion

        private DataGridView dataGridViewQuantity;
        private Button btnAdd;
        private Button btnSave;
        private Button btnBack;
    }
}