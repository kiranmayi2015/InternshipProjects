using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open the chrome browser//

IWebDriver driver = new ChromeDriver();

//navigate to the Turn up portal//
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
driver.Manage().Window.Maximize();

//identify user name textbox and enter valid username//
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//identify password textbox and enter valid password//
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//identify the login button and click it//
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

//check if user is logged in successfully//
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if(helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Login successful,test passed");
}
else
{
    Console.WriteLine("Login unsuccessful, test failed");
}
