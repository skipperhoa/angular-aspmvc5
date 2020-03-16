using System.Web;
using System.Web.Optimization;

namespace Angular_mvc5
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {


            bundles.Add(new ScriptBundle("~/Script/Bundles").Include(
                     "~/dist/runtime-es2015.*",
                      "~/dist/runtime-es5.*",
                     "~/dist/polyfills-es2015.*",
                      "~/dist/polyfills-es5.*",
                     "~/dist/main-es2015.*",
                      "~/dist/main-es5.*"));

            bundles.Add(new StyleBundle("~/Content/Styles").Include(
                      "~/dist/styles.*"));
        }
    }
}
