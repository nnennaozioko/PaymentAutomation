using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace LongRichAutomationUI.Utilities
{
	public class Browser
	{
		static Browser()
		{
			Driver = null;
		}
		public static IWebDriver Driver { get; set; }
		public static string TestURL { get; set; }
		public static void Refresh()

		{
			Driver.Url = Driver.Url;
		}

	}
}
