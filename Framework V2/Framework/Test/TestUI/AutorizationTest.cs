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
	//[TestFixture]
	[AllureNUnit]
	class AutorizationTest
	{
		private IWebDriver _driver;
		//public IWebDriver driver;
		[OneTimeSetUp]
		public void StartTest()
		{
			
			BrowserOption br = new BrowserOption();
			_driver = br.OptionForSelenoid();
			
		}
		[OneTimeTearDown]
		public void EndTest()
		{
			_driver.Quit();
		}
		[Test]
		public void AutorizationPageTest()
		{
			//Step
			AutorizationPage.AuthorizationPageTest(_driver, User.GetUser());
			//Verefication
			Assert.AreEqual(_driver.Url, AutorizationPage.loginPageVereficationUrl);
		}
	}
}
