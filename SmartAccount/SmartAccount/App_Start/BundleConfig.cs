using System.Web.Optimization;

namespace SmartAccount.App_Start
{
    public class BundleConfig
    {
       public static void RegisterBundles(BundleCollection bundles)
        {        
            bundles.Add(new StyleBundle("~/Content").Include("~/Content/SiteStyle.css"));
        }
    }
}