using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;
using NUnit.Framework;

namespace TripPlannerTest1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                // Initialise Web Driver
                IWebDriver driver = new ChromeDriver();

                // Set Web Address
                driver.Navigate().GoToUrl("https://transportnsw.info/trip#/");

                // Find the input elements
                IWebElement eleFrom = driver.FindElement(By.XPath("//*[@id=\"search-input-From\"]"));
                IWebElement eleTo = driver.FindElement(By.XPath("//*[@id=\"search-input-To\"]"));
                IWebElement btnGo = driver.FindElement(By.XPath("//*[@id=\"search-button\"]"));
                IWebElement btnOptions = driver.FindElement(By.ClassName("btn-search-options"));

                // Input a value for the From field
                eleFrom.Clear();
                eleFrom.SendKeys("North Sydney Station");
                eleFrom.SendKeys(Keys.Tab);
                eleFrom.Submit();

                // Input a value for the To field
                eleTo.Clear();
                eleTo.SendKeys("Town Hall Station");
                eleTo.SendKeys(Keys.Tab);
                eleTo.Submit();

                // Sleep the thread so the page elements can finish processing
                Thread.Sleep(1000);

                // Click the Go button
                Actions actions = new Actions(driver);
                actions.MoveToElement(btnGo).Perform();
                btnGo.Click();

                // Sleep the thread so the button clicked can finish processing
                Thread.Sleep(1000);

                // Look for the results
                if (FindMyElement(driver, By.XPath("//*[@id=\"search-results-success\"]"), out IWebElement foundResults))
                {
                    bool visible = IsElementVisible(foundResults);
                    if (visible)
                    {
                        // If Found - Test that it contains route numbers, throw an exception if not
                        String expectedMessage = "route number";
                        String message = foundResults.Text;
                        StringAssert.Contains(expectedMessage, message);
                    }
                }

                // Close the Web Address
                driver.Quit();
                driver = null;

                // Throw an exception of success
                Assert.Pass("Test Passed!");

            }
            catch (Exception ex)
            {
                Assert.Fail("An exception has occurred.  Error Message: " + ex.Message);
            }
        }

        static private bool FindMyElement(IWebDriver driver, By by, out IWebElement element)
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(300);

            try
            {
                element = driver.FindElement(by);
            }
            catch (NoSuchElementException)
            {
                element = null;
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(20000);
                return false;
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(20000);
            return true;
        }

        static private bool IsElementVisible(IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }
    }
}
