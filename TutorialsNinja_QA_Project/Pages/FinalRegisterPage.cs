using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TutorialsNinja_QA_Project.Pages
{
    public class FinalRegisterPage
    {
        private IWebDriver driver;

        public FinalRegisterPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetFinalMessage()
        {
           return driver.FindElement(By.XPath("//div[@id='content']")).Text;
        }

        public void ClickContinueButton()
        {
            driver.FindElement(By.CssSelector(".btn.btn-primary")).Click();
        }
    }
}
