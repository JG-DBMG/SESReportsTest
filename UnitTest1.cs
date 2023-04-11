using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace SESReportsTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Browser Driver
            IWebDriver webDriver = new EdgeDriver();

            // Navigate To Site
            webDriver.Navigate().GoToUrl("https://sesqa.schuff.com/");

            // Open SES 000

            
        }
    }
}