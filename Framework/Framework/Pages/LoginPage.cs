using Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.Login
{
    public class AutorizationPage : BasePage
    {
        public static string host = "https://demo.opencart.com/index.php?route=account/login";
        public string FindElementTeg;
        private static string EmailFiledId = "input-email";//поле емейл для реєстрації та авторизації однакове id
        private static string PasswordFiledId = "input-password";//поле пароль для реєстрації та авторизації однакове id
        private static string LoginToggleElement = "/html/body/nav/div/div[2]/ul/li[2]/a";//випадаючий список головної сторінки вибір ЛОГІН/Реєстрація XPath
        private static string LoginButtonToggleElement = "/html/body/nav/div/div[2]/ul/li[2]/ul/li[2]/a";//пункт випадаючого списку що вказує на форму логін XPath
        private static string LoginButtonToInByXPath = "/html/body/div[2]/div/div/div/div[2]/div/form/input";//елемент кнопка LOGIN для форми логування щоб увійти XPath

        public static void SiteBasePage(IWebDriver driver, Account account)
        {
            goToSite(driver, host);
        }

        public static void AuthorizationPageTest(IWebDriver driver, Account account)
        {
            goToSite(driver, host);
            XPathClickElement(driver, LoginToggleElement);
            XPathClickElement(driver, LoginButtonToggleElement);
            ByIdClickElement(driver, EmailFiledId);
            ByIdWriteElement(driver, EmailFiledId, account.Email);
            ByIdClickElement(driver, PasswordFiledId);
            ByIdWriteElement(driver, PasswordFiledId, account.Password);
            XPathClickElement(driver, LoginButtonToInByXPath);
        }

    }
}
