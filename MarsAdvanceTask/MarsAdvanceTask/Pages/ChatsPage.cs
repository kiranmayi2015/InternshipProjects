using MarsAdvanceTask.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsAdvanceTask.Input;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MarsAdvanceTask.Pages
{
    public class ChatsPage : CommonDriver
    {
          //  public IWebElement chatIcon => driver.FindElement(By.LinkText("Chat"));
            public IWebElement chatSearch => driver.FindElement(By.XPath("/html//div[@id='chatRoomContainer']/div[@class='chatRoom']//input[@class='prompt']"));
            public IWebElement chatName => driver.FindElement(By.XPath("/html//div[@id='chatList']/div[1]/div[@class='content']/div[@class='header']"));
            public IWebElement chatTextbox => driver.FindElement(By.XPath("/html//input[@id='chatTextBox']"));
            public IWebElement sendButton => driver.FindElement(By.XPath("/html//button[@id='btnSend']"));
            
          /*          public void Chat()
                    {
                        Thread.Sleep(6000);
                        chatIcon.Click();
                    }
            */
            public void ChatSearch()
            {
                ExcelReader.ReadDataTable(stream, "Chats");
                Thread.Sleep(2000);
                chatSearch.Click();
                 UseWait();
                chatSearch.SendKeys(ExcelReader.ReadData(1, "ChatSearch"));
            }
            public void ChatHistory()
            {
                ExcelReader.ReadDataTable(stream, "Chats");
                UseWait();
                string searchtext = driver.FindElement(By.XPath("//div[normalize-space()='Suneha']")).Text;
                Assert.AreEqual(searchtext, ExcelReader.ReadData(1, "ChatSearch"));

            }
            public void ChatMessage()
            {
                ExcelReader.ReadDataTable(stream, "Chats");
                UseWait();
                chatTextbox.Click();
                chatTextbox.SendKeys(ExcelReader.ReadData(1, "ChatInput"));

            }

            public void ChatSendbutton()
            {
                sendButton.Click();
                Thread.Sleep(2000);

            }
        }
    }
