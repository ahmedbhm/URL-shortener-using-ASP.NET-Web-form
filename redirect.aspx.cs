using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using url_shortner.Models;

namespace url_shortner
{
    public partial class redirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    String ShortLink = "";
                    ShortLink = Page.RouteData.Values["ShortLink"] as String;
                    String originUrl = Functions.GetOriginUrl(ShortLink);
                    if (originUrl != null)
                    {
                        result_area.InnerHtml = @"<h4>Your link is ready.</h4> 
                                              <a class='btn btn-primary' href='" + originUrl + "'>Get Link</a>";
                    }
                    else
                    {
                        result_area.InnerHtml = @"<h4>Page Not Found</h4>";
                    }
                }
                catch (Exception)
                {
                    
                    Response.Redirect("~/");
                }
            }
        }
    }
}