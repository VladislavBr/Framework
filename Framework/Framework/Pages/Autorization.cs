using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    class Authorization
    {
        public string Login;
        public static string Localhost = "http://localhost/";
        public string Password;
        private static string EmailFiledId = "input-email";
        private static string PasswordFiledId = "input-password";
        public string BaseSiteAdress = $"{Localhost}/opencart/Store";//
        private static string LoginFormAdress = $"{Localhost}/opencart/index.php?route=account/login";
        private static string RegisterFormAdress = $"{Localhost}/opencart/index.php?route=account/register";
        private static string LoginToggleElement = "/html/body/nav/div/div[2]/ul/li[2]/a";
        private static string LoginButtonToggleElement = "/html/body/nav/div/div[2]/ul/li[2]/ul/li[2]/a";
        private static string LoginButtonToInByClass = "btn btn-primary";


        public static void goToSite(IWebDriver driver, string site)
        {
            driver.Navigate().GoToUrl(site);
        }

        public static void XPachClickElement(IWebDriver driver, string XPachAdress)
        {
            driver.FindElement(By.XPath(XPachAdress)).Click();
        }

        public static void CssClickElement(IWebDriver driver, string CssAdress)
        {
            driver.FindElement(By.CssSelector(CssAdress)).Click();
        }

        public static void ByNameClickElement(IWebDriver driver, string NameAdress)
        {
            driver.FindElement(By.Name(NameAdress)).Click();
        }

        public static void ByIdClickElement(IWebDriver driver, string IdAdress)
        {
            driver.FindElement(By.Id(IdAdress)).Click();
        }

        public static void ByClassNameClickElement(IWebDriver driver, string ClassNameAdress)
        {
            driver.FindElement(By.ClassName(ClassNameAdress)).Click();
        }

        public static void ByTagNameClickElement(IWebDriver driver, string TagNameAdress)
        {
            driver.FindElement(By.TagName(TagNameAdress)).Click();
        }

        public static void Registration(IWebDriver driver, Authorization account)
        {
            goToSite(driver, account.BaseSiteAdress);

        }

        public static void Autorization(IWebDriver driver, Authorization account)
        {
            driver.FindElement(By.CssSelector(LoginFormAdress)).Click();
            driver.FindElement(By.Id(EmailFiledId)).SendKeys(account.Login);
            driver.FindElement(By.Id(PasswordFiledId)).SendKeys(account.Password + Keys.Enter);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(d => d.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div[1]/ul/li")));
        }

    }
}
