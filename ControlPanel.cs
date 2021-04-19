using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProjectMAS
{
    class ControlPanel
    {
        private int id;
        private string location;
        private string username;
        private string password;
        private bool loggedIn;

        // constructors
        public ControlPanel()
        {
            id = 0;
            location = "unknown";
            username = "unknown";
            password = "unknown";
            loggedIn = false;
        }
        public ControlPanel(int panelId, string panelLocation, string panelUsername, string panelPassword)
        {
            id = panelId;
            location = panelLocation;
            username = panelUsername;
            password = panelPassword;
            loggedIn = false;
        }

        //behaviors
        public bool LogIn()
        {
            if (loggedIn == false)
            {
                Console.WriteLine("\nLogin Successful.");
                loggedIn = true;
                return true;
            }
            else
            {
                Console.WriteLine("\nError, you are already logged in.");
                return true;
            }
        }
        public bool LogOut()
        {
            Console.WriteLine("\nYou have logged out successfully.");
            loggedIn = false;
            return false;
        }
    }
}
