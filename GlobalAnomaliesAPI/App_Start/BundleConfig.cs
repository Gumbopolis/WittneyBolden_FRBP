using System.Web;
using System.Web.Optimization;

namespace GlobalAnomaliesAPI
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new Bundle("~/bundles/javascript").Include(
                     "~/Scripts/bootstrap.js",
                     "~/Scripts/Chart.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/Chart.css"));
        }
    }
}
