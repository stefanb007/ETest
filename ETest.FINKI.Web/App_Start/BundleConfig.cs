using System.Web.Optimization;

namespace ETest.FINKI.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery-validate.*"));

            bundles.Add(new ScriptBundle("~/bundles/modenizr").Include(
                "~/Scripts/modernizr-{version}.js"));

            bundles.Add( new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/Site.css",
                "~/Content/bootstrap-responsive.css"
                ));
        }
    }
}