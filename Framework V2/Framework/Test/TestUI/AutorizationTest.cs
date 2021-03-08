using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Pages;
using Data;
using Framework.Data.User;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using OpenQA.Selenium.Remote;

namespace Framework.Test
{
	[AllureNUnit]
	class AutorizationTest
	{
		private IWebDriver driver;
		[OneTimeSetUp]
		public void StartTest()
		{
			BrowserOption StartInDocker = new BrowserOption();
			driver = StartInDocker.OptionForSelenoid();
			
		}
		[OneTimeTearDown]
		public void EndTest()
		{
			driver.Quit();
		}
		[Test]
		public void AutorizationPageTest()
		{
			//Step
			AutorizationPage.AuthorizationPageTest(driver, User.GetUser());
			//Verefication
			Assert.AreEqual(driver.Url, AutorizationPage.loginPageVereficationUrl);
		}
	}
}
