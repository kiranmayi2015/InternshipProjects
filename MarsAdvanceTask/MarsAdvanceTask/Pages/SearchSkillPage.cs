using MarsAdvanceTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using SharpCompress.Compressors.Xz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvanceTask.Pages
{
    public class SearchSkillPage : CommonDriver
    {
        public IWebElement programmingCategory => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[7]"));

        public IWebElement qaSubcategory => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[11]"));
            
        public IWebElement onlineBtn => driver.FindElement(By.XPath("//button[@class='ui button'][contains(.,'Online')]"));

        public  IWebElement onsiteBtn => driver.FindElement(By.XPath("//button[@class='ui button'][contains(.,'Onsite')]"));

        public IWebElement showAllBtn => driver.FindElement(By.XPath("//button[@class='ui button'][contains(.,'ShowAll')]"));

        public IWebElement resultBtn => driver.FindElement(By.XPath("(//img[@src='http://mars-listing-photo.s3.amazonaws.com/18a85a80-e30e-4a1a-9341-7b6859c20908default-image.jpg'])[1]"));

        public void Category()
        {
            programmingCategory.Click();
        }
        public void SubCategory()
        {
            qaSubcategory.Click();
        }

        public void ClickOnlineBtn()
        {
            UseWait();
            onlineBtn.Click();

        }

        public void ClickOnSiteBtn()
        {
            UseWait();
            onsiteBtn.Click();

        }

        public void ClickShowAllBtn()
        {
            UseWait();
            showAllBtn.Click();

        }

        public void ClickResultBtn()
        {
            UseWait();
            resultBtn.Click();

        }
      
    }

}
