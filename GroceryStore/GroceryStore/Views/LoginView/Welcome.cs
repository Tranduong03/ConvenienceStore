using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore.Views
{
    public partial class Welcome : Form
    {
        private Panel pnlLogin;
        public Welcome()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            // Khởi tạo childForm login cho form Welcome
            var loginForm = new Login_Child
            {
                Owner = this
            };

            pnlLogin = loginForm.pnlLogin;

            pnlWork.Controls.Add(pnlLogin);

        }

    }
}
