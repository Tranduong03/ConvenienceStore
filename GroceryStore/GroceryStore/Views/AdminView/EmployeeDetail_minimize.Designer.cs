namespace GroceryStore.Views.AdminView
{
    partial class EmployeeDetail_minimize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetail_minimize));
            picEmployee = new PictureBox();
            lblEmployeeName = new Label();
            lblEmployeePhone = new Label();
            btnDelete = new PictureBox();
            pnlEmployee = new Panel();
            btnInformation = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnInformation).BeginInit();
            SuspendLayout();
            // 
            // picEmployee
            // 
            picEmployee.Image = (Image)resources.GetObject("picEmployee.Image");
            picEmployee.Location = new Point(65, 12);
            picEmployee.Name = "picEmployee";
            picEmployee.Size = new Size(75, 75);
            picEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
            picEmployee.TabIndex = 0;
            picEmployee.TabStop = false;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.Location = new Point(22, 109);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(164, 22);
            lblEmployeeName.TabIndex = 1;
            lblEmployeeName.Text = "Unknown";
            lblEmployeeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmployeePhone
            // 
            lblEmployeePhone.Location = new Point(22, 151);
            lblEmployeePhone.Name = "lblEmployeePhone";
            lblEmployeePhone.Size = new Size(164, 22);
            lblEmployeePhone.TabIndex = 2;
            lblEmployeePhone.Text = "unknownPhone";
            lblEmployeePhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(165, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(33, 30);
            btnDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            btnDelete.TabIndex = 3;
            btnDelete.TabStop = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // pnlEmployee
            // 
            pnlEmployee.BackColor = SystemColors.ActiveBorder;
            pnlEmployee.Controls.Add(btnInformation);
            pnlEmployee.Controls.Add(picEmployee);
            pnlEmployee.Controls.Add(btnDelete);
            pnlEmployee.Controls.Add(lblEmployeeName);
            pnlEmployee.Controls.Add(lblEmployeePhone);
            pnlEmployee.Location = new Point(0, 0);
            pnlEmployee.Name = "pnlEmployee";
            pnlEmployee.Size = new Size(210, 213);
            pnlEmployee.TabIndex = 4;
            // 
            // btnInformation
            // 
            btnInformation.BackColor = SystemColors.ActiveBorder;
            btnInformation.Image = (Image)resources.GetObject("btnInformation.Image");
            btnInformation.Location = new Point(165, 48);
            btnInformation.Name = "btnInformation";
            btnInformation.Size = new Size(33, 30);
            btnInformation.SizeMode = PictureBoxSizeMode.StretchImage;
            btnInformation.TabIndex = 4;
            btnInformation.TabStop = false;
            btnInformation.Click += btnInformation_Click;
            // 
            // EmployeeDetail_minimize
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(210, 213);
            Controls.Add(pnlEmployee);
            Font = new Font("Tahoma", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeDetail_minimize";
            Text = "EmployeeDetail";
            ((System.ComponentModel.ISupportInitialize)picEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            pnlEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnInformation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picEmployee;
        private Label lblEmployeeName;
        private Label lblEmployeePhone;
        private PictureBox btnDelete;
        public Panel pnlEmployee;
        private PictureBox btnInformation;
    }
}