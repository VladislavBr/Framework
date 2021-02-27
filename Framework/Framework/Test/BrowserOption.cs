using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Framework.Test
{
	class BrowserOption
	{
		public static ChromeOptions FirstOption()
		{
			ChromeOptions options = new ChromeOptions();
			options.AddArgument("start-maximized");
			options.AddArgument("disable-infobars");
			//options.AddArgument("user-data-dir=C:\\Users\\Vlad\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Default");
			return options;
		}
	}
}
