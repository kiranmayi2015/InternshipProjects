using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstscript.Pages
{
    public class EmployeePage
    {
        public void CreateEmployee(IWebDriver driver)
        {

            try
            {
                IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
                createButton.Click();
                Thread.Sleep(1000);
            }
            catch (Exception ex1)
            {
                Assert.Fail("Create button not found", ex1.Message);
            }
            //enter name in name text box

            IWebElement NameTextBox = driver.FindElement(By.Id("Name"));
            NameTextBox.SendKeys("Bunny");

            //enter username

            IWebElement UserNameBox = driver.FindElement(By.Id("Username"));
            UserNameBox.SendKeys("Bunny15");
            Thread.Sleep(1000);

            IWebElement editButton = driver.FindElement(By.Id("EditContactButton"));
            editButton.Click();
            Thread.Sleep(1000);

            //switching to iframe window

            driver.SwitchTo().Frame(0);

            IWebElement firstName = driver.FindElement(By.Id("FirstName"));
            firstName.SendKeys("kiranmayi");

            IWebElement lastName = driver.FindElement(By.Id("LastName"));
            lastName.SendKeys("melmayi");

            IWebElement preferredName = driver.FindElement(By.Id("PreferedName"));
            preferredName.SendKeys("kiranmayi");

            IWebElement phoneNo = driver.FindElement(By.Id("Phone"));
            phoneNo.SendKeys("0987654321");

            IWebElement mobileNo = driver.FindElement(By.Id("Mobile"));
            mobileNo.SendKeys("0987654321");

            IWebElement emailId = driver.FindElement(By.Id("email"));
            emailId.SendKeys("kirru.me@gmail.com");

            IWebElement faxNum = driver.FindElement(By.Id("Fax"));
            faxNum.SendKeys("12345");

            IWebElement streetName = driver.FindElement(By.Id("Street"));
            streetName.SendKeys("36,Roseville court");

            IWebElement cityName = driver.FindElement(By.Id("City"));
            cityName.SendKeys("Dublin");

            IWebElement postCode = driver.FindElement(By.Id("Postcode"));
            postCode.SendKeys("517501");

            IWebElement countryName = driver.FindElement(By.Id("Country"));
            countryName.SendKeys("Ireland");

            IWebElement submitButton = driver.FindElement(By.Id("submitButton"));
            submitButton.Click();

            Thread.Sleep(5000);


            //Switching back to original window

            driver.SwitchTo().DefaultContent();


            //enter password

            IWebElement PasswordTextBox = driver.FindElement(By.Id("Password"));
            PasswordTextBox.SendKeys("Sharan123$");

            //retype password

            IWebElement RetypePasswordBox = driver.FindElement(By.Id("RetypePassword"));
            RetypePasswordBox.SendKeys("Sharan123$");

            //click on admin checkbox

            IWebElement AdminCheckBox = driver.FindElement(By.Id("IsAdmin"));
            AdminCheckBox.Click();

            //click on vehicle textbox

            IWebElement vehicleBox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicleBox.SendKeys("Car"); ;


            //click on groups dropdown

            IWebElement GroupsDropDown = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            GroupsDropDown.Click();
            Thread.Sleep(3000);

            //select testaa option

            IWebElement testaaOption = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[2]"));
            testaaOption.Click();
            Thread.Sleep(3000);

            //click on save button

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(8000);


            //click on back to list

            IWebElement backToList = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToList.Click();
            Thread.Sleep(8000);

            //click on go to lastpage

            IWebElement gotoLastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            gotoLastPage.Click();
            Thread.Sleep(10000);

            IWebElement newName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement newUserName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));



            Thread.Sleep(10000);
            Assert.That(newName.Text == "Bunny", "New code and expected code do not match.");
            Assert.That(newUserName.Text == "Bunny15", "New description and expected description do not match.");


        }
        public void EditEmployee(IWebDriver driver)
        {
            IWebElement gotoLastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            gotoLastPage.Click();
            Thread.Sleep(15000);
         
            IWebElement findCreatedEmployee = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(10000);

            if (findCreatedEmployee.Text == "Bunny")
            {
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
                editButton.Click();
                Thread.Sleep(6000);
            }
            else
            {
                Assert.Fail("Employee to be edited not found");
            }
            //edit the name

            IWebElement editNameTextBox = driver.FindElement(By.Id("Name"));
            editNameTextBox.Clear();
            editNameTextBox.SendKeys("sunnybunny");

            //edit username

            IWebElement editUserNameTextBox = driver.FindElement(By.Id("Username"));
            editUserNameTextBox.Clear();
            editUserNameTextBox.SendKeys("sunnybunny2015");

                     
            //click on save button

            IWebElement saveButton1 = driver.FindElement(By.Id("SaveButton"));
            saveButton1.Click();
            Thread.Sleep(8000);

            //click on back to list

            IWebElement backToList1 = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToList1.Click();
            Thread.Sleep(10000);

            IWebElement gotoLastPageButton1 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            gotoLastPageButton1.Click();
            Thread.Sleep(10000);

            IWebElement editedEmployeeName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(10000);

            if (editedEmployeeName.Text == "sunnybunny")
            {
                Assert.Pass("Employee record edited successfully");
            }
            else
            {
                Assert.Fail("Employee record not updated");
            }


        }

        public void DeleteEmployee(IWebDriver driver)
        {

            //goto  last page
            IWebElement gotoLastPageButton2 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            gotoLastPageButton2.Click();
            Thread.Sleep(10000);


            IWebElement findEditedEmployee = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(5000);

            if (findEditedEmployee.Text == "sunnybunny")
            {
                IWebElement deleteEmployee = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
                deleteEmployee.Click();
                Thread.Sleep(5000);
            }
            else
            {
                Assert.Fail("Edited Employee record not found");
            }

            //confirmation alert appears

            //click on ok button

            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(5000);

            IWebElement deletedEmployee = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(10000);

            if (deletedEmployee.Text != "sunnybunny")
            {
                Assert.Pass("Employee record deleted successfully");
            }
            else
            {
                Assert.Fail("Employee Record hasn't been deleted");
            }
        }
    }

}
