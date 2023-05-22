using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_II_Automation.Todois.code.control;
using OpenQA.Selenium;

namespace Module_II_Automation.Yopmail.code.page
{
    public class MainPage
    {
        public TextBox mailTextBox = new TextBox (By.XPath("//input[@class='ycptinput']"));
        public Button checkInboxButton = new Button(By.XPath("//button[@class='md']"));
        public Button homeButton = new Button(By.XPath("//a[@title='YOPmail - Temporary email']"));
    }
}
