using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Pages.Login;

namespace Framework.Test
{
	[TestFixture]
	class AutorizationTest
	{
		public IWebDriver driver;
		[OneTimeSetUp]
		public void StartTest()
		{
			driver = new ChromeDriver();
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
		}
		[OneTimeTearDown]
		public void EndTest()
		{
			driver.Quit();
		}
		[Test]
		public void AutorizationPageTest()
		{
			Account account = new Account("kover18595@geeky83.com", "hahaitwork");
			//Step
			Pages.Login.AutorizationPage.AuthorizationPageTest(driver, account);

			Assert.AreEqual("2","2");
			driver.Quit();
		}
	}
}
