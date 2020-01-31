using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Pages
{
    public class DashboardPage : MainPage<DashboardPage_Selectors>
    {
        public DashboardPage(Pages p) 
            : base(p, new DashboardPage_Selectors()) {}
    }

    public class DashboardPage_Selectors : MainPage_Selectors
    {
    }
}
