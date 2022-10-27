using OpenQA.Selenium;
using NUnit.Framework;
using Firstscript.Utilities;

namespace Firstscript.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
       
           //navigate to the Turn up portal//
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            
            try
            {

                //identify user name textbox and enter valid username//
                IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");
            }
            catch (Exception ex)
            {
                Assert.Fail("Turnup portal didnot launch", ex.Message);
            }
            
            //identify password textbox and enter valid password//
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            //identify the login button and click it//
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(1000);

        }
    }
}
