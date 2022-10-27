using Firstscript.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using Firstscript.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstscript.Tests
{
    [TestFixture]
    [Parallelizable]
    
    public class Employee_Tests : CommonDriver
    {
        
        HomePage homepageObj = new HomePage(); 
        EmployeePage employeepageObj = new EmployeePage();

      
        [Test, Order(1), Description("This test creates New Employee Record")]


        public void CreateEmployeeTest()
        {
            homepageObj.GoToEmployeePage(driver);
            employeepageObj.CreateEmployee(driver);

        }


        [Test, Order(2), Description("This test edits an Employee Record")]

        public void EditEmployeeTest()
        {
            homepageObj.GoToEmployeePage(driver);

            employeepageObj.EditEmployee(driver);
        }

        [Test, Order(3), Description("This test deletes an Employee Record")]

        public void DeleteEmployeeTest()
        {

            homepageObj.GoToEmployeePage(driver);
            employeepageObj.DeleteEmployee(driver);

        }

    }

} 
    

