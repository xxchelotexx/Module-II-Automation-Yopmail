using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_II_Automation.Todois.code.factoryBrowser
{
    public class FactoryBrowser
    {
        public static IBrowser Make (String type)
        {
            IBrowser browser;

            switch (type)
            {
                case "chrome":
                    browser = new Chrome();
                    break;
                default: 
                    browser = new Chrome();
                    break;
            }
            return browser;
        }
    }
}
