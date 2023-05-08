using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TutorialsNinja_QA_Project.Data;

namespace TutorialsNinja_QA_Project.Pages
{
    public class RegisterPage
    {
        IWebDriver driver;

        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void RegisterAccount()
        {
            driver.FindElement(By.XPath("//input[@id='input-firstname']")).SendKeys(Constants.FirstName);
            driver.FindElement(By.XPath("//input[@id='input-lastname']")).SendKeys(Constants.LastName);
            driver.FindElement(By.XPath("//input[@id='input-email']")).SendKeys(Constants.Email);
            driver.FindElement(By.XPath("//input[@id='input-telephone']")).SendKeys(Constants.PhoneNumber);
            driver.FindElement(By.XPath("//input[@id='input-password']")).SendKeys(Constants.Password);
            driver.FindElement(By.XPath("//input[@id='input-confirm']")).SendKeys(Constants.Password);
            driver.FindElement(By.XPath("(//label[@class='radio-inline'])[1]")).Click();
            driver.FindElement(By.XPath("//input[@type='checkbox']")).Click();
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
        }
    }
}
