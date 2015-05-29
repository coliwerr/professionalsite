﻿using System.Web.Optimization;

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


            bundles.Add(new StyleBundle("~/Content/css"/*,
                "//maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css"*/).Include(
                "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/customcss").Include(
                "~/Content/styles.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryscripts",
                "//ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js").Include(
                "~/Scripts/jquery-2.1.4.js"));

            bundles.Add(new ScriptBundle("~/bundles/websitescripts",
                "//maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/activeTab.js"));
        }
    }
}