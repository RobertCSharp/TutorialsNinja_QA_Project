using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using TutorialsNinja_QA_Project.Data;
using TutorialsNinja_QA_Project.Pages;

namespace TutorialsNinja_QA_Project
{
    public class BasesTests
    {
        IWebDriver driver;
        HomePage homePage;
        RegisterPage registerPage;
        FinalRegisterPage finalRegisterPage;

        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Constants.URL);
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
            finalRegisterPage = new FinalRegisterPage(driver);
        }

        [Test]
        public void RegisterTest()
        {
            homePage.ClickAccount();
            homePage.ClickRegisterAccount();
            registerPage.RegisterAccount();

            string finalMessage = finalRegisterPage.GetFinalMessage();
            Console.WriteLine(finalMessage);
            Assert.IsTrue(finalMessage.Contains(Constants.CreateAccountMessage));
            finalRegisterPage.ClickContinueButton();
        }

        [Test]
        public void EndToEndTest()
        {
            driver.FindElement(By.XPath("(//a[@class='dropdown-toggle'])[1]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Login')]")).Click();
            driver.FindElement(By.XPath("//input[@id='input-email']")).SendKeys("robert232@yahoo.com");
            driver.FindElement(By.XPath("//input[@id='input-password']")).SendKeys("Parola23@");
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            driver.FindElement(By.XPath("(//a[@class='dropdown-toggle'])[2]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(), 'Mac (1)')])")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//button[@type='button'])[10]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//span[@class='hidden-xs hidden-sm hidden-md'])[5]")).Click();
            driver.FindElement(By.XPath("//a[@class='btn btn-primary']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='button-shipping-address']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='button-shipping-method']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@type='checkbox']")).Click();
            driver.FindElement(By.XPath("//input[@id='button-payment-method']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='button-confirm']")).Click();
            Thread.Sleep(2000);
            string finalMessage = "Your order has been placed!";
            string actualMessage = driver.FindElement(By.CssSelector("#content")).Text;
            Assert.IsTrue(actualMessage.Contains(finalMessage));
        }

    }
}