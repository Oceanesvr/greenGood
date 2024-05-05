using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GREEN_GOOD
{
    public static class SessionManager
    {
        private static int loggedInUserId;

        public static int LoggedInUserId
        {
            get { return loggedInUserId; }
        }

        public static void SetLoggedInUserId(int userId)
        {
            loggedInUserId = userId;
        }

        public static void ClearSession()
        {
            loggedInUserId = 0;
        }
    }
}


