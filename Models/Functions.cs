using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace url_shortner.Models
{
    public class Functions
    { 
      //Get the long url
	  public static String GetOriginUrl(String ShortLink){
        var param = new Dictionary<string, object>() { { "@ShortLink", ShortLink }};
        DataSet ds= new dbconfig().quirySelect("SELECT * FROM links WHERE ShortLink=@ShortLink",param);
        return ds.Tables[0].Rows.Count > 0 ? ds.Tables[0].Rows[0]["OriginUrl"].ToString() : null;
	  }
      
      //add new record to data base
	  public static String AddNewLinkToDB(String url){
          String ShortLink=generateShortLink();
          var param = new Dictionary<string, object>() { { "@OriginUrl", url }, { "@ShortLink", ShortLink } };
          new dbconfig().quiryUpdate("INSERT INTO links (OriginUrl,ShortLink) VALUES (@OriginUrl,@ShortLink)", param);
          return ShortLink;
	  }

      //generate random string with length=5 and verify that it's not exist in the DB
	  public static String generateShortLink(){
        String ShortLink= RandomString(5);
        while (GetOriginUrl(ShortLink) != null)
        {
            ShortLink = RandomString(5);	 
		}
        return ShortLink;
	   }

      //generate random string with specific lenght
       public static string RandomString(int length)
       {
          Random random = new Random();
          const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
          return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
       }

       //check if a string is a valid url c#
       public static bool isValidUrl(String uriName)
       {
           Uri uriResult;
           bool result = Uri.TryCreate(uriName, UriKind.Absolute, out uriResult)
               && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
           return result;
       }
     }
}