using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace LongRichAutomationUI.Common.Utilities
{
    class GenerateRandomStringFromDate
    {
        public static string GetDate()
        {
            return DateTime.Now.ToString("yyyyMMdd HHmmss");
        }

        public static string GenerateRandomText(string text)
        {
            return text + GetDate();
        }


        public static string GenerateTextAndStoreInContext(string text, string contextName)
        {
            string name = GenerateRandomText(text);
            ScenarioContext.Current[contextName] = name;
            return name;
        }
    }
}
