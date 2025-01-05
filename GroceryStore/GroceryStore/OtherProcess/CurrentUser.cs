using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.OtherProcess
{
    public static class CurrentUser
    {
        // Biến static để lưu UserID của người dùng hiện tại
        public static int? UserID { get; set; }
    }
}
