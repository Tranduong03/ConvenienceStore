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
        private Panel pnlRegister;
        public Welcome()
        {
            InitializeComponent();

            // Khởi tạo childForm login cho form Welcome
            var loginForm = new Login_Child
            {
                Owner = this
            };

            var registerForm = new Register_Child
            {
                Owner = this
            };
            pnlLogin = loginForm.pnlLogin;
            pnlRegister = registerForm.pnlRegister;

            pnlWork.Controls.Add(pnlLogin);
            pnlWork.Controls.Add(pnlRegister);
            pnlLogin.BringToFront();

        }

        public void LoadFormIntoPanel()
        {
            if (IsControlInFront(pnlWork, pnlLogin))
            {
                pnlLogin.SendToBack();
            }
            else
            {
                pnlRegister.SendToBack();
            }   

        }

        bool IsControlInFront(Control parent, Control child)
        {
            // Kiểm tra nếu control con nằm trong parent
            if (parent.Controls.Contains(child))
            {
                // Kiểm tra chỉ số con
                return parent.Controls.GetChildIndex(child) == 0;
            }
            return false;
        }


    }
}
