using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_II_Automation.Todois.code.session;
using OpenQA.Selenium;

namespace Module_II_Automation.Todois.code.control
{
    public class ControlSelenium
    {
        protected By locator;
        protected IWebElement control;

        public ControlSelenium(By locator) 
        {
            this.locator = locator;
        }

        protected void FindControl()
        {
            control = Session.Instance().GetBrowser().FindElement(locator);
        }

        public void Click() 
        {
            FindControl();
            control.Click();
        }

        public Boolean IsControlDisplayed() 
        {
            try 
            {
                FindControl();
                return control.Displayed;
            }catch (Exception ex)   
            {
                return false;
            }
        }
    }
}
