using System.Web;
using System.Web.Optimization;

namespace WhereToEat.Web
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/vendor/jquery/jquery-1.10.2.min.js",
                        "~/Scripts/vendor/jquerymobile/jquery.mobile-1.3.2.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/index").Include(
                "~/Scripts/src/index.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Scripts/vendor/jquerymobile/jquery.mobile-1.3.2.min.css",
                      "~/Content/css/site.css"));
        }
    }
}
