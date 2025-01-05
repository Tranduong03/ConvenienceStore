namespace GroceryStore.Views.AdminView
{
    partial class ImportProduct
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
            dataGridViewQuantity = new DataGridView();
            btnAdd = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQuantity).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewQuantity
            // 
            dataGridViewQuantity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQuantity.Location = new Point(12, 12);
            dataGridViewQuantity.Name = "dataGridViewQuantity";
            dataGridViewQuantity.RowHeadersWidth = 62;
            dataGridViewQuantity.Size = new Size(776, 376);
            dataGridViewQuantity.TabIndex = 0;
            dataGridViewQuantity.CellValueChanged += dataGridViewQuantity_CellValueChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(169, 404);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(456, 404);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 2;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // ImportProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewQuantity);
            Name = "ImportProduct";
            Text = "ImportProduct";
            ((System.ComponentModel.ISupportInitialize)dataGridViewQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewQuantity;
        private Button btnAdd;
        private Button btnSave;
    }
}