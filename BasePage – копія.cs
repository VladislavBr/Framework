using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Authorization 
    {
        public string Email;
        public string Password;
        public string FindElementTeg;
        private static string EmailFiledId = "input-email";//поле емейл для реєстрації та авторизації однакове id
        private static string PasswordFiledId = "input-password";//поле пароль для реєстрації та авторизації однакове id
        public string BaseSiteAdress = "https://demo.opencart.com/";//адреса головної сторінки url
        private static string LoginFormAdress = "https://demo.opencart.com/index.php?route=account/login";//адреса форми логування url
        private static string RegisterFormAdress = "https://demo.opencart.com/index.php?route=account/register";//адреса форми реєстрації url
        private string LoginToggleElement = "/html/body/nav/div/div[2]/ul/li[2]/a";//випадаючий список головної сторінки вибір ЛОГІН/Реєстрація XPath
        private string LoginButtonToggleElement = "/html/body/nav/div/div[2]/ul/li[2]/ul/li[2]/a";//пункт випадаючого списку що вказує на форму логін XPath
        private static string LoginButtonToInByClass = "btn btn-primary";//елемент кнопка LOGIN для форми логування щоб увійти class
        private static string RegisterFirstNameId = "input-firstname";//поле ім'я для форми реєстрації id
        private static string RegisterLastNameId = "input-lastname";//поле прізвище для форми реєстрації id
        private static string RegisterEmailId = "input-email";//поле емейл для форми реєстрації id
        private static string RegisterTelephoneId = "input-telephone";//поле емейл для форми реєстрації id
        private static string RegisterPasswordId = "input-password";//поле пароль для форми реєстрації id
        private static string RegisterPasswordConfirmId = "input-confirm";//поле підтвердження паролю для форми реєстрації id
        private static string RegisterCheckboxByName = "agree";//погодитись з політикою петра порошенка для форми реєстрації name
        private static string RegisterButtonContinueByClass = "btn btn-primary";//кнопка продовжити для форми реєстрації перехід на ішшу сторінку class


        public static void goToSite(IWebDriver driver, string site)
        {
            driver.Navigate().GoToUrl(site);
        }

        public static void XPathClickElement(IWebDriver driver, string XPathAdress)
        {
            driver.FindElement(By.XPath(XPathAdress)).Click();
        }
        public static void XPathWriteElement(IWebDriver driver, string IdAdress, string fildText)
        {
            driver.FindElement(By.XPath(IdAdress)).SendKeys(fildText);
        }

        public static void CssClickElement(IWebDriver driver, string CssAdress)
        {
            driver.FindElement(By.CssSelector(CssAdress)).Click();
        }
        public static void CssWriteElement(IWebDriver driver, string IdAdress, string fildText)
        {
            driver.FindElement(By.CssSelector(IdAdress)).SendKeys(fildText);
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
            driver.FindElement(By.ClassName(ClassNameAdress)).Click();
        }
        public static void ByClassWriteElement(IWebDriver driver, string IdAdress, string fildText)
        {
            driver.FindElement(By.ClassName(IdAdress)).SendKeys(fildText);
        }

        public static void ByTagNameClickElement(IWebDriver driver, string TagNameAdress)
        {
            driver.FindElement(By.TagName(TagNameAdress)).Click();
        }
        public static void ByTegWriteElement(IWebDriver driver, string IdAdress, string fildname)
        {
            driver.FindElement(By.TagName(IdAdress)).SendKeys(fildname);
        }

        public static void Registration(IWebDriver driver, Authorization account)
        {
            goToSite(driver, account.BaseSiteAdress);
            ByIdClickElement(driver, RegisterFirstNameId);
            ByIdWriteElement(driver, RegisterFirstNameId, "Name");
            ByIdClickElement(driver, RegisterLastNameId);
            ByIdWriteElement(driver, RegisterLastNameId, "LName");
            ByIdClickElement(driver, RegisterEmailId);
            ByIdWriteElement(driver, RegisterEmailId, account.Email);
            ByIdClickElement(driver, RegisterTelephoneId);
            ByIdWriteElement(driver, RegisterTelephoneId, "0123224532");
            ByIdClickElement(driver, RegisterPasswordId);
            ByIdWriteElement(driver, RegisterPasswordId, account.Password);
            ByIdClickElement(driver, RegisterPasswordConfirmId);
            ByIdWriteElement(driver, RegisterPasswordConfirmId, account.Password);
            ByNameClickElement(driver, RegisterCheckboxByName);
            ByClassNameClickElement(driver, RegisterButtonContinueByClass);
        }
        public static void SiteBasePage(IWebDriver driver, Authorization account)
        {
            goToSite(driver, account.BaseSiteAdress);
        }

        public static void AuthorizationPage(IWebDriver driver, Authorization account)
        {
            goToSite(driver, account.BaseSiteAdress);
            XPathClickElement(driver, account.LoginToggleElement);
            XPathClickElement(driver, account.LoginButtonToggleElement);
            ByIdClickElement(driver, EmailFiledId);
            ByIdWriteElement(driver, EmailFiledId, account.Email);
            ByIdClickElement(driver, PasswordFiledId);
            ByIdWriteElement(driver, PasswordFiledId, account.Password);
            ByClassNameClickElement(driver, LoginButtonToInByClass);
        }

        public Authorization(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }
    }
}
