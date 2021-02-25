using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class BasePage
    {
        private static string DesctopsText = "Show All Desktops";
        private static string LaptopsAndNotebooksText = "Show All Laptops & Notebooks";
        private static string ComponentsText = "Show All Components";
        private static string MP3PlayersText = "Show All MP3 Players";
        private static string BasePageAdress = "https://demo.opencart.com/index.php?route=common/home";
        private static string URLDesctops = "https://demo.opencart.com/index.php?route=product/category&amp;path=20";
        private static string Desctops = "/html/body/div[1]/nav/div[2]/ul/li[1]/div/a";
        private static string desctopsPc = "https://demo.opencart.com/index.php?route=product/category&amp;path=20_26";
        private static string desctopsMac = "https://demo.opencart.com/index.php?route=product/category&amp;path=20_27";
        private static string URLLaptopsAndNotebooks = "https://demo.opencart.com/index.php?route=product/category&amp;path=18";
        private static string LaptopsAndNotebooks = "/html/body/div[1]/nav/div[2]/ul/li[2]/div/a";
        private static string LaptopsAndNotebookMacs = "https://demo.opencart.com/index.php?route=product/category&amp;path=18_46";
        private static string LaptopsAndNotebookWindows = "https://demo.opencart.com/index.php?route=product/category&amp;path=18_45";
        private static string URLComponents = "https://demo.opencart.com/index.php?route=product/category&amp;path=25";
        private static string Components = "/html/body/div[1]/nav/div[2]/ul/li[3]/div/a";
        private static string ComponentsMiceAndTrackballs = "https://demo.opencart.com/index.php?route=product/category&amp;path=25_29";
        private static string ComponentsMonitors = "https://demo.opencart.com/index.php?route=product/category&amp;path=25_28";
        private static string ComponentsPrinters = "https://demo.opencart.com/index.php?route=product/category&amp;path=25_30";
        private static string ComponentsScanners = "https://demo.opencart.com/index.php?route=product/category&amp;path=25_31";
        private static string ComponentsWebCameras = "https://demo.opencart.com/index.php?route=product/category&amp;path=25_32";
        private static string URLTablets = "https://demo.opencart.com/index.php?route=product/category&amp;path=57";
        private static string Software = "https://demo.opencart.com/index.php?route=product/category&amp;path=17";
        private static string PhonesAndPDAs = "https://demo.opencart.com/index.php?route=product/category&amp;path=24";
        private static string Cameras = "https://demo.opencart.com/index.php?route=product/category&amp;path=33";
        private static string UrlMP3Players = "https://demo.opencart.com/index.php?route=product/category&amp;path=34";
        private static string MP3Players = "/html/body/div[1]/nav/div[2]/ul/li[8]/div/a";

        public static void ShowAllDesctops(IWebDriver driver, string site)
        {
            XPathClickElement(driver, Desctops);
            ByTextClickElement(driver, DesctopsText);
        }

        public static void ShowAllLaptopsAndNotebooks(IWebDriver driver, string site)
        {
            XPathClickElement(driver, LaptopsAndNotebooks);
            ByTextClickElement(driver, LaptopsAndNotebooksText);
        }

        public static void ShowAllComponents(IWebDriver driver, string site)
        {
            XPathClickElement(driver, Components);
            ByTextClickElement(driver, ComponentsText);
        }

        public static void ShowAllMP3Players(IWebDriver driver, string site)
        {
            XPathClickElement(driver, MP3Players);
            ByTextClickElement(driver, MP3PlayersText);
        }

        public static void goToSite(IWebDriver driver, string site)
        {
            driver.Navigate().GoToUrl(site);
        }

        public static void ByTextClickElement(IWebDriver driver, string XPathAdress)
        {
            driver.FindElement(By.LinkText(XPathAdress)).Click();
        }

        public static void XPathClickElement(IWebDriver driver, string XPathAdress)
        {
            driver.FindElement(By.XPath(XPathAdress)).Click();
        }
        public static void XPathWriteElement(IWebDriver driver, string IdAdress, string fildText)
        {
            driver.FindElement(By.XPath(IdAdress)).SendKeys(fildText);
        }

        public static void ByNameClickElement(IWebDriver driver, string NameAdress)
        {
            driver.FindElement(By.Name(NameAdress)).Click();
        }
        public static void ByNameWriteElement(IWebDriver driver, string IdAdress, string fildText)
        {
            driver.FindElement(By.Name(IdAdress)).SendKeys(fildText);
        }

        public static void ByIdClickElement(IWebDriver driver, string IdAdress)
        {
            driver.FindElement(By.Id(IdAdress)).Click();
        }
        public static void ByIdWriteElement(IWebDriver driver, string IdAdress, string fildText)
        {
            driver.FindElement(By.Id(IdAdress)).SendKeys(fildText);
        }

        public static void ByClassNameClickElement(IWebDriver driver, string ClassNameAdress)
        {
            driver.FindElement(By.CssSelector(ClassNameAdress)).Click();
        }
        public static void ByClassWriteElement(IWebDriver driver, string IdAdress, string fildText)
        {
            driver.FindElement(By.ClassName(IdAdress)).SendKeys(fildText);
        }
    }
}
