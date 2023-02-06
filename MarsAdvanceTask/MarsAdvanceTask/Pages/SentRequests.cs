using MarsAdvanceTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsAdvanceTask.Input;
using AventStack.ExtentReports;

namespace MarsAdvanceTask.Pages
{
    public class SentRequests : CommonDriver
    {
        public IWebElement sentButton => driver.FindElement(By.LinkText("Sent Requests"));
        public IWebElement withdrawRequest => driver.FindElement(By.XPath("//button[normalize-space()='Withdraw']"));
        public IWebElement withdrawStatus => driver.FindElement(By.XPath("//td[normalize-space()='Withdrawn']"));
        public IWebElement statusPending => driver.FindElement(By.XPath("//td[normalize-space()='Pending']"));
        public IWebElement statusDeclined => driver.FindElement(By.XPath("//td[normalize-space()='Declined']"));

        public IWebElement statusAccepted = driver.FindElement(By.XPath("//td[normalize-space()='Accepted']"));
        public IWebElement markasCompleteButton => driver.FindElement(By.XPath("//button[normalize-space()='Completed']"));
        public IWebElement statusCompleted => driver.FindElement(By.XPath("///tbody/tr[4]/td[5]"));
        public IWebElement reviewButton => driver.FindElement(By.XPath("(//button[@type='button'])[3]"));
        public IWebElement sellerCommunicationRating => driver.FindElement(By.XPath("//div[@id='communicationRating']/i[3]"));
        public IWebElement ServiceAsDesccribed => driver.FindElement(By.XPath("//div[@id='serviceRating']/i[3]"));
        public IWebElement wouldRecommend => driver.FindElement(By.XPath("//div[@id='recommendRating']/i[4]"));
        public IWebElement reviewSaveButton => driver.FindElement(By.XPath("//div[2]/div/div[4]/div"));
        public IWebElement reviewText => driver.FindElement(By.XPath("//textarea[@id='reviewCommentInput']"));


        public void SentRequest()
        {
            sentButton.Click();
        }
        public void WithdrawSentRequest()
        {
            withdrawRequest.Click();
        }
        public void WithdrawStatus()
        {
            string WithdrawStatus = driver.FindElement(By.XPath("//td[normalize-space()='Withdrawn']")).Text;
            Assert.AreEqual(WithdrawStatus, "Withdrawn");
        }
        public void PendingStatus()
        {
            var PendingStatus = driver.FindElement(By.XPath("//td[normalize-space()='Pending']"));
            Assert.AreEqual(PendingStatus, "Pending");
        }
        public void DeclineStatus()
        {
            string DeclineStatus = driver.FindElement(By.XPath("//td[normalize-space()='Declined']")).Text;
            Assert.AreEqual(DeclineStatus, "Declined");
        }

        public void AcceptedStatus()
        {
            string acceptedStatus = driver.FindElement(By.XPath("//td[normalize-space()='Accepted']")).Text;
            Assert.AreEqual(acceptedStatus, "Accepted");
        }

        public void CompleteButton()
        {
            var completebuttonVisible = driver.FindElement(By.XPath("//button[normalize-space()='Completed']")).Text;
            if (completebuttonVisible == "Completed")
            {
                Console.WriteLine("Complete Button Visible");
            }
        }
        public void Completed()
        {
            markasCompleteButton.Click();
        }
        public void CompleteStatus()
        {
            string completeStatus = driver.FindElement(By.XPath("///tbody/tr[4]/td[5]")).Text;
            Assert.AreEqual(completeStatus, "Completed");
        }

        public void ReviewButton()
        {
            reviewButton.Click();
        }
        public void Review()
        {
            sellerCommunicationRating.Click();
            ServiceAsDesccribed.Click();
            wouldRecommend.Click();
            ExcelReader.ReadDataTable(stream, "SentRequest");
            reviewText.SendKeys(ExcelReader.ReadData(1, "Review"));
            reviewSaveButton.Click();
        }

    }
}
    

