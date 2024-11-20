namespace ConvenienceStore_WF
{
    partial class Product
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtFindPro = new System.Windows.Forms.TextBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNamePro = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtPricePro = new System.Windows.Forms.TextBox();
            this.txtQuanPro = new System.Windows.Forms.TextBox();
            this.lblRich = new System.Windows.Forms.Label();
            this.richTxtPro = new System.Windows.Forms.RichTextBox();
            this.lblCate = new System.Windows.Forms.Label();
            this.cmbCatePro = new System.Windows.Forms.ComboBox();
            this.btnAddPro = new System.Windows.Forms.Button();
            this.btnDeletePro = new System.Windows.Forms.Button();
            this.btnUpPro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(4, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 2);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 76);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.dgvProduct);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(4, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(888, 566);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtFindPro);
            this.panel4.Location = new System.Drawing.Point(7, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 38);
            this.panel4.TabIndex = 5;
            // 
            // txtFindPro
            // 
            this.txtFindPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFindPro.Location = new System.Drawing.Point(7, 5);
            this.txtFindPro.Multiline = true;
            this.txtFindPro.Name = "txtFindPro";
            this.txtFindPro.Size = new System.Drawing.Size(219, 29);
            this.txtFindPro.TabIndex = 0;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(7, 132);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(873, 229);
            this.dgvProduct.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnUpPro);
            this.panel5.Controls.Add(this.btnDeletePro);
            this.panel5.Controls.Add(this.btnAddPro);
            this.panel5.Controls.Add(this.cmbCatePro);
            this.panel5.Controls.Add(this.lblCate);
            this.panel5.Controls.Add(this.richTxtPro);
            this.panel5.Controls.Add(this.lblRich);
            this.panel5.Controls.Add(this.txtQuanPro);
            this.panel5.Controls.Add(this.txtPricePro);
            this.panel5.Controls.Add(this.lblQuantity);
            this.panel5.Controls.Add(this.lblPrice);
            this.panel5.Controls.Add(this.txtNamePro);
            this.panel5.Controls.Add(this.lblName);
            this.panel5.Location = new System.Drawing.Point(7, 371);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(873, 186);
            this.panel5.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(139, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtNamePro
            // 
            this.txtNamePro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamePro.Location = new System.Drawing.Point(218, 10);
            this.txtNamePro.Name = "txtNamePro";
            this.txtNamePro.Size = new System.Drawing.Size(132, 20);
            this.txtNamePro.TabIndex = 1;
            this.txtNamePro.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(137, 59);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(82, 17);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Sell Price:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(137, 112);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(74, 17);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtPricePro
            // 
            this.txtPricePro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPricePro.Location = new System.Drawing.Point(218, 56);
            this.txtPricePro.Name = "txtPricePro";
            this.txtPricePro.Size = new System.Drawing.Size(132, 20);
            this.txtPricePro.TabIndex = 4;
            // 
            // txtQuanPro
            // 
            this.txtQuanPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuanPro.Location = new System.Drawing.Point(218, 109);
            this.txtQuanPro.Name = "txtQuanPro";
            this.txtQuanPro.Size = new System.Drawing.Size(132, 20);
            this.txtQuanPro.TabIndex = 5;
            // 
            // lblRich
            // 
            this.lblRich.AutoSize = true;
            this.lblRich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRich.Location = new System.Drawing.Point(392, 11);
            this.lblRich.Name = "lblRich";
            this.lblRich.Size = new System.Drawing.Size(95, 17);
            this.lblRich.TabIndex = 6;
            this.lblRich.Text = "Description:";
            // 
            // richTxtPro
            // 
            this.richTxtPro.Location = new System.Drawing.Point(493, 7);
            this.richTxtPro.Name = "richTxtPro";
            this.richTxtPro.Size = new System.Drawing.Size(234, 67);
            this.richTxtPro.TabIndex = 7;
            this.richTxtPro.Text = "";
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCate.Location = new System.Drawing.Point(392, 109);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(78, 17);
            this.lblCate.TabIndex = 8;
            this.lblCate.Text = "Category:";
            // 
            // cmbCatePro
            // 
            this.cmbCatePro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCatePro.FormattingEnabled = true;
            this.cmbCatePro.Location = new System.Drawing.Point(496, 104);
            this.cmbCatePro.Name = "cmbCatePro";
            this.cmbCatePro.Size = new System.Drawing.Size(163, 21);
            this.cmbCatePro.TabIndex = 9;
            // 
            // btnAddPro
            // 
            this.btnAddPro.AutoSize = true;
            this.btnAddPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPro.Location = new System.Drawing.Point(290, 148);
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(75, 27);
            this.btnAddPro.TabIndex = 10;
            this.btnAddPro.Text = "Add";
            this.btnAddPro.UseVisualStyleBackColor = false;
            // 
            // btnDeletePro
            // 
            this.btnDeletePro.AutoSize = true;
            this.btnDeletePro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDeletePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePro.Location = new System.Drawing.Point(428, 147);
            this.btnDeletePro.Name = "btnDeletePro";
            this.btnDeletePro.Size = new System.Drawing.Size(96, 27);
            this.btnDeletePro.TabIndex = 11;
            this.btnDeletePro.Text = "Delete";
            this.btnDeletePro.UseVisualStyleBackColor = false;
            // 
            // btnUpPro
            // 
            this.btnUpPro.AutoSize = true;
            this.btnUpPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpPro.Location = new System.Drawing.Point(561, 148);
            this.btnUpPro.Name = "btnUpPro";
            this.btnUpPro.Size = new System.Drawing.Size(75, 27);
            this.btnUpPro.TabIndex = 12;
            this.btnUpPro.Text = "Update";
            this.btnUpPro.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConvenienceStore_WF.Properties.Resources.new_arrival;
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 582);
            this.Controls.Add(this.panel3);
            this.Name = "Product";
            this.Text = "Product";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtFindPro;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNamePro;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtQuanPro;
        private System.Windows.Forms.TextBox txtPricePro;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblRich;
        private System.Windows.Forms.RichTextBox richTxtPro;
        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.ComboBox cmbCatePro;
        private System.Windows.Forms.Button btnUpPro;
        private System.Windows.Forms.Button btnDeletePro;
        private System.Windows.Forms.Button btnAddPro;
    }
}