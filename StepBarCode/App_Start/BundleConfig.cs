using System.Web.Optimization;

namespace StepBarCode
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                //CORE PLUGINS
                "~/Content/global/plugins/jquery.min.js",
                "~/Content/global/plugins/bootstrap/js/bootstrap.min.js",
                "~/Content/global/plugins/js.cookie.min.js",
                "~/Content/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
                "~/Content/global/plugins/jquery.blockui.min.js",
                "~/Content/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js",
                //THEME GLOBAL SCRIPTS
                "~/Content/global/scripts/app.min.js",
                //THEME LAYOUT SCRIPTS
                "~/Content/layouts/layout/scripts/layout.min.js",
                "~/Content/layouts/layout/scripts/demo.min.js",
                "~/Content/layouts/global/scripts/quick-sidebar.min.js",
                "~/Content/layouts/global/scripts/quick-nav.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                //GLOBAL MANDATORY STYLES
                "~/Content/global/plugins/font-awesome/css/font-awesome.min.css",
                "~/Content/global/plugins/simple-line-icons/simple-line-icons.min.css",
                "~/Content/global/plugins/bootstrap/css/bootstrap.min.css",
                "~/Content/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css",
                //THEME GLOBAL STYLES
                "~/Content/global/css/components.min.css",
                "~/Content/global/css/plugins.min.css",
                //THEME LAYOUT STYLES
                "~/Content/layouts/layout/css/layout.min.css",
                "~/Content/layouts/layout/css/themes/blue.min.css",
                "~/Content/layouts/layout/css/custom.min.css"));
        }
    }
}
