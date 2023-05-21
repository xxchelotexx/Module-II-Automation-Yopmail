using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_II_Automation.Todois.code.factoryBrowser;
using OpenQA.Selenium;

namespace Module_II_Automation.Todois.code.session
{
    public class Session
    {
        private static Session instance = null;
        private IWebDriver browser;
        
        private Session() 
        {
            browser = FactoryBrowser.Make("chrome").Create();
        }

        public static Session Instance() 
        {
            if (instance == null)
            {
                instance = new Session();
            }
            return instance;
        }

        public void CloseBrowser() 
        {
            instance = null;
            browser.Quit();
        }

        public IWebDriver GetBrowser() 
        {
            return browser;
        }
    }
}
