using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using Pages;
using System.Threading;
using Data;

namespace Framework.Test
{
	class CheckPageItemsTest
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
			//give

			//Step
			BasePage.goToSite(driver);
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
			//driver.FindElement(By.PartialLinkText("Show All Desktops")).Click();
			//Actions actions = new Actions(driver);
			//IWebElement element = driver.FindElement(By.XPath("/html/body/div[1]/nav/div[2]/ul/li[1]/a"));
			//actions.MoveToElement(element).Build().Perform();
			BasePage.MouseHover(driver, BasePage.Desctops);
			BasePage.ClickButton(driver, "xpatch", BasePage.DesctopsShowAllDesktops);
			//Verefication
			Assert.AreEqual("Desktops", ShowAllCategotiesPage.TextCheckRead(driver, ShowAllCategotiesPage.DesctopsCheckXpatch));
			//Assert.IsTrue(Convert.ToBoolean(ShowAllCategotiesPage.TextCheckRead(driver, ShowAllCategotiesPage.DesctopsCheckXpatch)));
			//Assert.IsTrue(driver.FindElement(By.XPath("/html/body/div[2]/div/div/h2")));
			//Assert.AreEqual(driver.PageSource.Contains("Desktope"), true);
			//step
			BasePage.MouseHover(driver, BasePage.LaptopsAndNotebooks);
			BasePage.ClickButton(driver, "xpatch", BasePage.LaptopsAndNotebooksShowAll);
			Thread.Sleep(2000);
			//Verefication
			Assert.AreEqual("Laptops & Notebooks", ShowAllCategotiesPage.TextCheckRead(driver, ShowAllCategotiesPage.NotebookAndLapptopeTextCheck));

		}
	}
}
