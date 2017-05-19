using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1;
namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Tutorial tp = new Tutorial();
        protected void Page_Load(object sender, EventArgs e)
        {
            tp.Name = "Continuous Integration";
        }
    }
}