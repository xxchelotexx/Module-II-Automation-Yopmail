using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_II_Automation.Todois.code.session;

namespace Yopmail.code.control
{
    public class ChangeDefaultFrame
    {
        public void DefaultFrame()
        {
            Session.Instance().GetBrowser().SwitchTo().DefaultContent();
        }

    }
}
