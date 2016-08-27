using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointUpload
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static string SharePointAccessToken()
        {
            // Get SharePoint Site and URI
            Uri siteUri = new Uri(ConfigurationManager.AppSettings["SiteUrl"]);
            string realm = TokenHelper.GetRealmFromTargetUrl(siteUri);
            // Get Access Token
            return TokenHelper.GetAppOnlyAccessToken(TokenHelper.SharePointPrincipal, siteUri.Authority, realm).AccessToken;
        }
    }
}
