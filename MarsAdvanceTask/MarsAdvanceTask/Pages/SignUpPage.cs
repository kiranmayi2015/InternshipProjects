using MarsAdvanceTask.Input;
using MarsAdvanceTask.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvanceTask.Pages
{
    public class SignUpPage : CommonDriver
    {
        IWebElement joinButton => driver.FindElement(By.XPath("//button[contains(text(),'Join')]"));
        IWebElement firstNamebox => driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/form[1]/div[1]/input[1]"));
        IWebElement lastNamebox => driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/form[1]/div[2]/input[1]"));
        IWebElement emailTextbox => driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
        IWebElement passwordTextbox => driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/form[1]/div[4]/input[1]"));
        IWebElement confirmPassword => driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/form[1]/div[5]/input[1]"));
        IWebElement agreeCheckbox => driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/form[1]/div[6]/div[1]/div[1]/input[1]"));
        IWebElement submitButton => driver.FindElement(By.XPath("//div[@id='submit-btn']"));

        public void SignUpSteps()
        {
            ExcelReader.ReadDataTable(stream, "Signup");
            joinButton.Click();

            firstNamebox.Click();
            firstNamebox.SendKeys(ExcelReader.ReadData(1, "Firstname"));

            lastNamebox.Click();
            lastNamebox.SendKeys(ExcelReader.ReadData(1, "Lastname"));

            emailTextbox.Click();
            emailTextbox.SendKeys(ExcelReader.ReadData(1, "EmailId"));

            passwordTextbox.Click();
            passwordTextbox.SendKeys(ExcelReader.ReadData(1, "Password"));

            confirmPassword.Click();
            confirmPassword.SendKeys(ExcelReader.ReadData(1, "Confirmpassword"));

            agreeCheckbox.Click();
            submitButton.Click();

        }

    }
}
