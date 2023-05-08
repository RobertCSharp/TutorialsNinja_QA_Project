using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TutorialsNinja_QA_Project.Data
{
    public class Constants
    {
        public const string URL = "https://tutorialsninja.com/demo/";
        public const string FirstName = "Pahonie";
        public const string LastName = "Robert";
        public static readonly string Email = CreateNewEmail();
        public const string PhoneNumber = "0471136005";
        public const string Password = "Parola23@";
        public const string CreateAccountMessage = "Your Account Has Been Created!";

        public static string CreateNewEmail()
        {
            DateTime dateTime = DateTime.Now;
            return "robert" + (dateTime.TimeOfDay).ToString().Replace(":", "").Replace(".", "") + "@yahoo.com";

        }
    }

}
