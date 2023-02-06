using MarsAdvanceTask.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
       public IWebElement managerequestsTab => driver.FindElement(By.XPath("//div[@id='account-profile-section']//section[@class='nav-secondary']/div/div[1]"));
       public IWebElement sentRequestOption => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[2]"));
       public IWebElement chatsIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[1]"));

        public void GoToSearchSkillsPage()
        {
            UseWait();
            searchIcon.Click();
        }
        public void ManageRequestsTab()
        {
            UseWait();
            managerequestsTab.Click();
        }
        public void GoToSentRequestPage()
        {
            UseWait();
            sentRequestOption.Click();
        }
        public void GoToChatsPage()
        {
            Thread.Sleep(6000);
            chatsIcon.Click();
        }

    }
}
