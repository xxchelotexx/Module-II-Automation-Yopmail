using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_II_Automation.Todois.code.session;
using Module_II_Automation.Todois.code.test;
using Module_II_Automation.Yopmail.code.page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Yopmail.code.control;
using Yopmail.code.page;

namespace Yopmail.code.test
{
    
    [TestClass]
    public class MailTest : TestBase
    {
        MainPage mainpage = new MainPage();
        InboxIFrame inboxiframe = new InboxIFrame();
        MailIFrame mailiframe = new MailIFrame();
        ChangeFrame changeframe = new ChangeFrame(); 
        ChangeDefaultFrame changedefaultframe = new ChangeDefaultFrame();
        LeftPanel leftpnael = new LeftPanel();

        

        [TestMethod]

        public void VerifyThatAMailIsSentSucessfully() 
        {

            //Generate a random mail
            string randomValue = RandomMail.GenerateRandom(6);
            mainpage.mailTextBox.SetText(randomValue);
            mainpage.checkInboxButton.Click();
            
            //Generate a new mail message
            leftpnael.newMailButton.Click();
            changeframe.FrameName("ifmail");
            mailiframe.destinationMailTextBox.SetText(randomValue+"@yopmail.com");
            mailiframe.subjectTextBox.SetText(randomValue);
            mailiframe.messageBodyTextBox.SetText(randomValue);
            Thread.Sleep(1000);
            mailiframe.sendMailButton.Click();
            Thread.Sleep(1000);


            //Refresh the inbox
            changedefaultframe.DefaultFrame();
            leftpnael.refreshButton.Click();
            Thread.Sleep(3000);

            //Verify that the mail is received.
            changeframe.FrameName("ifinbox");
            Assert.IsTrue(inboxiframe.mailNameDisplayed(randomValue),"ERROR! El Correo no coincide");

            Thread.Sleep(1000);
        }

    }
}
