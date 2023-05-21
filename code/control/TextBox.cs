﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Module_II_Automation.Todois.code.control
{
    public class TextBox : ControlSelenium
    {
        public TextBox(By locator) : base(locator) 
        {
        }

        public void SetText(String value)
        {
            FindControl();
            control.Clear();
            control.SendKeys(value);
        }

    }
}
