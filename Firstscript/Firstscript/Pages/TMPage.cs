using Firstscript.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstscript.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            try
            {
                IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
                createNewButton.Click();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Create new button not found", ex.Message);
            }
            //select time from typecode dropdown//
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeDropdown.Click();
            Thread.Sleep(1000);

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            timeOption.Click();

            //enter the code in code textbox//

            IWebElement codeTextbox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            codeTextbox.SendKeys("firstscript");

            //enter the description in description textbox//

            IWebElement descriptionTextBox = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            descriptionTextBox.SendKeys("description");


            //enter the price on price per unit textbox//

            IWebElement inputTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            inputTag.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("15");

            //click on save button//

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(7000);


            //Check if new record is created successfully//

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(15000);

        }
        public string GetCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;
        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }

        /*IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
        IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));

        Thread.Sleep(10000);
        Assert.That(newCode.Text == "firstscript", "New code and expected code do not match.");
        Assert.That(newDescription.Text == "description", "New description and expected description do not match.");
        Assert.That(newPrice.Text == "$15.00", "New price and expected price do not match.");
        */



        public void EditTM(IWebDriver driver, string description, string code, string price)
        {

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(15000);


            //bool staleElement = true;
            //while (staleElement)
            //{
            //    try
            //    {
            //        driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            //        staleElement = false;
            //    }
            //    catch (StaleElementReferenceException e)
            //    {
            //        staleElement = true;
            //    }
            //}



            /*   IWebElement findCreatedRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
               Thread.Sleep(10000);

               if (findCreatedRecord.Text == "firstscript")
               {
                   IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                   editButton.Click();
               }
               else
               {
                   Assert.Fail("Record to be edited not found. Record not edited");
               }
            */


            //select time from typecode dropdown//
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(2000);
            IWebElement typCodeDropdown1 = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typCodeDropdown1.Click();
            Thread.Sleep(1000);

            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            materialOption.Click();

            //update the code in code textbox//

            IWebElement editCode = driver.FindElement(By.Id("Code"));
            editCode.Clear();
            editCode.SendKeys(code);


            //update the description in description textbox//

            IWebElement editDesc = driver.FindElement(By.Id("Description"));
            editDesc.Clear();
            editDesc.SendKeys(description);


            //enter the price in price per unit text box//

            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            newPrice.Click();


            IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
            priceTextBox.Clear();

            IWebElement priceTB = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTB.Click();

            IWebElement editedPrice = driver.FindElement(By.Id("Price"));
            editedPrice.SendKeys(price);
            Thread.Sleep(3000);

            //click on save button//

            IWebElement savButton = driver.FindElement(By.Id("SaveButton"));
            savButton.Click();
            Thread.Sleep(5000);

            //click on go to lastpage and check if record is updated//


            IWebElement goLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goLastPage.Click();
            Thread.Sleep(20000);

            IWebElement editedCodeNew = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(15000);

            if (editedCodeNew.Text == "EditCode2022")
            {
                Assert.Pass("Record is edited sucessfully,test passed");
            }
            else
            {

                Assert.Fail("Record not edited,test failed");
            }
        }

        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement EditedDescription1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return EditedDescription1.Text;
        }

        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement EditedCode1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return EditedCode1.Text;
        }

        public string GetEditedPrice(IWebDriver driver)
        {
            IWebElement EditedPrice1 = driver.FindElement(By.XPath("//*[@id=\\\"TimeMaterialEditForm\\\"]/div/div[4]/div/span[1]/span/input[1]"));
            return EditedPrice1.Text;
        }



        public void DeleteTM(IWebDriver driver)
        {

            IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton1.Click();
            Thread.Sleep(10000);

            bool staleElement2 = true;
            while (staleElement2)
            {
                try
                {
                    driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
                    staleElement2 = false;
                }
                catch (StaleElementReferenceException e)
                {
                    staleElement2 = true;
                }
            }


            IWebElement findEditedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(10000);

            if (findEditedCode.Text == "EditedCode2022")

            {
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(5000);
                driver.SwitchTo().Alert().Accept();
            }
            else
            {
                Assert.Fail("Edited code hasn't been found. Record cannot be deleted");
            }

            Thread.Sleep(5000);

            // confirmation alert appears if you are sure to delete the record//

            //click on ok button//


            // driver.Navigate().Refresh();


            IWebElement deletedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(20000);

            //validate delete

            if (deletedCode.Text != "EditedCode2022")
            {

                Assert.Pass("Record deleted,test passed");
            }
            else
            {
                Assert.Fail("record not deleted,test failed");
            }
         }

    }
}
