using System.Web;
using System.Web.Optimization;

namespace GlobalAnomaliesMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.

            bundles.Add(new Bundle("~/bundles/javascript").Include(
                    "~/Scripts/bootstrap.min.js",
                    "~/Scripts/chart.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/Site.css"));

        }
    }
}
