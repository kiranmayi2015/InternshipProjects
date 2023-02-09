using MarsAdvanceTask.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvanceTask.Pages
{
    public class ProfilePage : CommonDriver
    {
       public IWebElement searchIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[1]/i"));
       public IWebElement managerequestsTab => driver.FindElement(By.XPath("//div[@class='ui dropdown link item']"));
        public IWebElement sentRequestOption => driver.FindElement(By.LinkText("Sent Requests"));
        public IWebElement chatsIcon => driver.FindElement(By.LinkText("Chat"));

        public void GoToSearchSkillsPage()
        {
            Thread.Sleep(3000);
            searchIcon.Click();
            UseWait();
        }
        public void ManageRequestsTab()
        {
            Thread.Sleep(3000);
            managerequestsTab.Click();
        }
        public void GoToSentRequestPage()
        {
            Thread.Sleep(3000);
            sentRequestOption.Click();
        }
        public void GoToChatsPage()
        {
            Thread.Sleep(6000);
            chatsIcon.Click();
            UseWait();
        }

    }
}
