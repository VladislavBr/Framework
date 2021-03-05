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
			//_driver = new ChromeDriver(BrowserOption.BrowserSettings());
			//_driver = new ChromeDriver(BrowserOption.BrowserSettings());
			//driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
			//_driver = new ChromeDriver();
			//BrowserOption.OptionForSelenoid();
			BrowserOption br = new BrowserOption();
			_driver = br.OptionForSelenoid();
			//var driverOptions = new ChromeOptions();
			//var runName = GetType().Assembly.GetName().Name;
			//var timestamp = $"{DateTime.Now:yyyyMMdd.HHmm}";
			//driverOptions.AddArgument("start-maximized");
			//driverOptions.AddAdditionalCapability("name", runName, true);
			//driverOptions.AddAdditionalCapability("videoName", $"{runName}.{timestamp}.mp4", true);
			//driverOptions.AddAdditionalCapability("logName", $"{runName}.{timestamp}.log", true);
			//driverOptions.AddAdditionalCapability("enableVNC", true, true);
			//driverOptions.AddAdditionalCapability("enableVideo", true, true);
			//driverOptions.AddAdditionalCapability("enableLog", true, true);
			//driverOptions.AddAdditionalCapability("screenResolution", "1920x1080x24", true);
			//_driver = new RemoteWebDriver(new Uri("http://127.0.0.1:8080/wd/hub"), driverOptions);
			//_driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
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
