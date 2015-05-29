using System.Web.Optimization;

namespace ColinWerra.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
#if !DEBUG
            bundles.UseCdn = true;
            BundleTable.EnableOptimizations = true;
#endif

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/styles.css"));

            bundles.Add(new ScriptBundle("~/bundles/websitescripts").Include(
                "~/Scripts/jquery-2.1.4.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/activeTab.js"));
        }
    }
}