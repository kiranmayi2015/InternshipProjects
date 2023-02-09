using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsAdvanceTask.Utilities;
using MarsAdvanceTask.Input;

namespace MarsAdvanceTask.Pages
{
    public class LoginPage : CommonDriver
    {

       public IWebElement signInButton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
       public IWebElement usernameTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
       public IWebElement passwordTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
       public IWebElement loginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));


           public void LoginSteps()
           {

            signInButton.Click();
            usernameTextbox.SendKeys(LoginCredentials.String1);
            passwordTextbox.SendKeys(LoginCredentials.String2);
            loginButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//a[contains(text(),'Share Skill')]", 10);
            Thread.Sleep(3000);

        }
    }
}


    

