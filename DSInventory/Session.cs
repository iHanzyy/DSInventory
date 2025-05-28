using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSInventory
{
    public static class Session
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }

        public static void Clear()
        {
            UserId = 0;
            Username = string.Empty;
            Role = string.Empty;
        }
    }
}
