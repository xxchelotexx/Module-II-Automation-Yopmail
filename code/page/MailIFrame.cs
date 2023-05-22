using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_II_Automation.Todois.code.control;
using OpenQA.Selenium;

namespace Yopmail.code.page
{
    internal class MailIFrame
    {
        public TextBox destinationMailTextBox = new TextBox(By.XPath("//input[@id='msgto']"));
        public TextBox subjectTextBox = new TextBox(By.XPath("//input[@id='msgsubject']"));
        public TextBox messageBodyTextBox = new TextBox(By.XPath("//div[@id='msgbody']"));
        public Button sendMailButton = new Button(By.XPath("//button[@id='msgsend']"));
    }
}
