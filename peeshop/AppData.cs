using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peeshop
{
    internal static class AppData
    {
        public const int ROLE_USER = 0;
        public const int ROLE_STAFF = 1;
        public const int ROLE_MANAGER = 2;

        public static bool isLogin = false;
        public static string username;
        public static string fullname;
        public static int role;
    }
}
