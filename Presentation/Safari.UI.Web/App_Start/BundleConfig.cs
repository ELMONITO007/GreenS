using System.Web;
using System.Web.Optimization;

namespace WebApplication2
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
   
                       bundles.Add(new StyleBundle("~/bundles/css")
                .Include(
                        "~/Content/css/creative.min.css",
                        "~/Content/vendor/magnific-popup/magnific-popup.css",
                        "~/Content/vendor/fontawesome-free/css/all.min.css"));

           
            bundles.Add(new ScriptBundle("~/bundles/js").Include(

                        "~/Content/vendor/jquery/jquery.min.js",
                        "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js",
                        "~/Content/vendor/jquery-easing/jquery.easing.min.js",
                        "~/Content/vendor/magnific-popup/jquery.magnific-popup.min.js",
                        "~/Content/js/creative.min.js"));


        }
    }
}
