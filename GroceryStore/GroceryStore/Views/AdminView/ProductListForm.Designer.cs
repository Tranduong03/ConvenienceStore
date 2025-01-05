namespace GroceryStore.Views.AdminView
{
    partial class ProductListForm
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
            dataGridViewProducts = new DataGridView();
            btnSelect = new Button();
            cbSupplier = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(269, 135);
            dataGridViewProducts.Margin = new Padding(2);
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.RowHeadersWidth = 62;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(288, 180);
            dataGridViewProducts.TabIndex = 0;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(355, 357);
            btnSelect.Margin = new Padding(2);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(90, 27);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Chọn";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // cbSupplier
            // 
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(371, 71);
            cbSupplier.Margin = new Padding(2);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(146, 28);
            cbSupplier.TabIndex = 2;
            cbSupplier.SelectedIndexChanged += cbSupplier_SelectedIndexChanged;
            // 
            // ProductListForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(640, 492);
            Controls.Add(cbSupplier);
            Controls.Add(btnSelect);
            Controls.Add(dataGridViewProducts);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "ProductListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductListForm";
            Load += ProductListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private Button btnSelect;
        private ComboBox cbSupplier;
    }
}