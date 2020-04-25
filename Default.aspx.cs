using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using url_shortner.Models;

namespace url_shortner
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Functions.isValidUrl(url.Value))
            {
                String ShortLink=Functions.AddNewLinkToDB(url.Value);
                String HostName = Request.Url.Host;
                String domainName = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority);

                ShortLink = domainName + "/" + ShortLink;
                data_place.InnerHtml = @"<div class='alert alert-success'><a href='" + ShortLink + "' target='blanc'>" + ShortLink + "</div>";
            }
            else
            {
                data_place.InnerHtml = "<div class='alert alert-danger'>try with a valid url</div>";
            }
           

        }
    }
}