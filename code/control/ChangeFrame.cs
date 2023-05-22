using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_II_Automation.Todois.code.session;

namespace Yopmail.code.control
{
    public class ChangeFrame
    {
        public void FrameName(String value) 
        {
            Session.Instance().GetBrowser().SwitchTo().Frame(value);
        }
    }
}
