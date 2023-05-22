using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_II_Automation.Todois.code.control;
using OpenQA.Selenium;

namespace Yopmail.code.page
{
    public class InboxIFrame
    {
        public Boolean mailNameDisplayed(String nameValue)
        {
            Label mailName = new Label(By.XPath("//div[text()='" + nameValue + "']"));
            return mailName.IsControlDisplayed();
        }
    }
       
}
