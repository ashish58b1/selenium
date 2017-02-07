using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace FlowView3
{
    class SeleniumTest
    {
        static void Main(string[]args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://fv3test.azurewebsites.net/login";
            System.Console.WriteLine("selenium");
            
        }
        
    }

}