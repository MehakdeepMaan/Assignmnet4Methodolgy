using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class ValidatePhoneNumberEnterIncorrectNumberDisplayErrorMessage
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheValidatePhoneNumberEnterIncorrectNumberDisplayErrorMessageTest()
        {
            driver.Navigate().GoToUrl("http://localhost/websiteasiignment4m/New.html");
            driver.FindElement(By.Id("sellerName")).Click();
            driver.FindElement(By.Id("sellerName")).Clear();
            driver.FindElement(By.Id("sellerName")).SendKeys("rajwinder");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("23king street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("waterloo");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("678");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("eha@gmail.com");
            driver.FindElement(By.Id("make")).Click();
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Honda");
            driver.FindElement(By.Id("model")).Click();
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("Accord-Hybrid");
            driver.FindElement(By.Id("year")).Click();
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2018");
            driver.FindElement(By.Name("submit")).Click();
            Assert.AreEqual(" Data stored ", CloseAlertAndGetItsText());
            driver.FindElement(By.Id("phoneEr")).Click();
            Assert.AreEqual("phone number must be filled out in correct format !", driver.FindElement(By.Id("phoneEr")).Text);
        }
        [Test]
        public void TheValidateEmailEnterInvalidEmailErrorMessageDisplayTest()
        {
            driver.Navigate().GoToUrl("http://localhost/websiteasiignment4m/New.html");
            driver.FindElement(By.Id("sellerName")).Click();
            driver.FindElement(By.Id("sellerName")).Clear();
            driver.FindElement(By.Id("sellerName")).SendKeys("iqbal singh");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("dhaipai");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("faridkot");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("456-678-9087");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("raniggamil.com");
            driver.FindElement(By.Id("make")).Click();
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Chrysler");
            driver.FindElement(By.Id("model")).Click();
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("300");
            driver.FindElement(By.Id("year")).Click();
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2018");
            driver.FindElement(By.Name("submit")).Click();
            driver.FindElement(By.Id("emailEr")).Click();
            Assert.AreEqual("email address must be filled out in correct format !", driver.FindElement(By.Id("emailEr")).Text);
        }


        [Test]
        public void TheValidateCityFieldLeftBlankCityFieldErrorMessageTest()
        {
            driver.Navigate().GoToUrl("http://localhost/websiteasiignment4m/New.html");
            driver.FindElement(By.Id("sellerName")).Click();
            driver.FindElement(By.Id("sellerName")).Clear();
            driver.FindElement(By.Id("sellerName")).SendKeys("rani");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("89king street");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("567-789-9876");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("rani@gmail.com");
            driver.FindElement(By.Id("make")).Click();
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Ford");
            driver.FindElement(By.Id("model")).Click();
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("Edge");
            driver.FindElement(By.Id("year")).Click();
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2018");
            driver.FindElement(By.Name("submit")).Click();
            Assert.AreEqual(" Data stored ", CloseAlertAndGetItsText());
            driver.FindElement(By.Name("myForm")).Click();
            driver.FindElement(By.Id("cityEr")).Click();
            Assert.AreEqual("Address must be enterted", driver.FindElement(By.Id("cityEr")).Text);
        }



        [Test]
        public void TheValidateJDpowerLinkClickonLinkOpenJDpowerWebsiteTest()
        {
            driver.Navigate().GoToUrl("http://localhost/websiteasiignment4m/New.html");
            driver.FindElement(By.Id("sellerName")).Click();
            driver.FindElement(By.Id("sellerName")).Clear();
            driver.FindElement(By.Id("sellerName")).SendKeys("sarbjit");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("89king street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("cambrige");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("567-78-6789");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("567-787-6789");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("mehak@gmail.com");
            driver.FindElement(By.Id("make")).Click();
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Ferrari");
            driver.FindElement(By.Id("model")).Click();
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("488 GTB");
            driver.FindElement(By.Id("year")).Click();
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2018");
            driver.FindElement(By.Name("submit")).Click();
            Assert.AreEqual(" Data stored ", CloseAlertAndGetItsText());
            driver.FindElement(By.LinkText("2018Ferrari488 GTB")).Click();
        }
        [Test]
        public void TheSavedAllDataFilledAllFieldsDataStoredCorrectlyTest()
        {
            driver.Navigate().GoToUrl("http://localhost/websiteasiignment4m/New.html");
            driver.FindElement(By.Id("sellerName")).Click();
            driver.FindElement(By.Id("sellerName")).Clear();
            driver.FindElement(By.Id("sellerName")).SendKeys("jp kaur");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("23king");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("kkp");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("567-567-3456");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("jp@gmail.com");
            driver.FindElement(By.Id("make")).Click();
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Ford");
            driver.FindElement(By.Id("model")).Click();
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("Edge");
            driver.FindElement(By.Id("year")).Click();
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2018");
            driver.FindElement(By.Name("submit")).Click();
            Assert.AreEqual(" Data stored ", CloseAlertAndGetItsText());
            Assert.AreEqual("jp kaur kkp 23king jp@gmail.com 567-567-3456 Ford Edge 2018 2018FordEdge", driver.FindElement(By.Id("Newdata")).Text);
        }


        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
