using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace SelenTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // driver 
            IWebDriver driver = new InternetExplorerDriver();

            // open browser
            driver.Navigate().GoToUrl("https://amazon.co.jp");

            Thread.Sleep(3000);

            // search for socks. Requires knowing how to access element on pages
            // IWebElement searchBox = driver.FindElement(By.CssSelector("input[id=twotabsearchtextbox]"));
            IWebElement searchBox = driver.FindElement(By.Name("field-keywords"));

            // type into search box
            searchBox.SendKeys("socks");
        }
    }
}
