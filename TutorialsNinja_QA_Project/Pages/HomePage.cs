using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TutorialsNinja_QA_Project.Pages
{
    public class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickAccount()
        {
            driver.FindElement(By.XPath("(//a[@class='dropdown-toggle'])[1]")).Click();
        }

        public void ClickRegisterAccount()
        {
            driver.FindElement(By.XPath("//a[contains(text(), 'Register')]")).Click();
        }
    }
}
