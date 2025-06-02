using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie cookiee = new HttpCookie("TooltipShown", "yes");
            //cookiee.Expires = DateTime.Now.AddSeconds(3);
            //Response.Cookies.Add(cookiee);
            if (!IsPostBack && Request.Cookies["TooltipShown"] == null)
            {
                // Show tooltip only first time
                ClientScript.RegisterStartupScript(this.GetType(), "showTooltip", "showTooltip();", true);

                Session["tottltip"] = "started";
                // Set cookie to prevent re-showing
                HttpCookie cookie = new HttpCookie("TooltipShown", "yes");
                cookie.Expires = DateTime.Now.AddMinutes(1);
                Response.Cookies.Add(cookie);
            }
        }
    }
}