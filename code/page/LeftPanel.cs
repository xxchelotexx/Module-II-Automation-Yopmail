using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_II_Automation.Todois.code.control;
using OpenQA.Selenium;

namespace Yopmail.code.page
{
    public class LeftPanel
    {
        public Button newMailButton = new Button(By.Id("newmail"));
        public Button refreshButton = new Button(By.XPath("//button[@id='refresh']"));
    }
}
