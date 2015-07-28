﻿using System.Web;
using System.Web.Optimization;

namespace AngularMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular")
         .Include("~/Scripts/angular.js",
                   "~/Scripts/angular-route.js")
                   .IncludeDirectory("~/Scripts/Controllers", "*.js")
                   .IncludeDirectory("~/Scripts/Factories", "*.js")
         .Include("~/Scripts/AngularMVC.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/_extensions.js"));

          
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                       "~/Scripts/modernizr-*"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
          
            BundleTable.EnableOptimizations = true;
        }
    }
}
