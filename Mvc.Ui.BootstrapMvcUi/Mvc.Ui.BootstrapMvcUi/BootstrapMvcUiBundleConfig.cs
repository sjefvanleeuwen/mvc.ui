using System.Web.Optimization;

namespace Mvc.Ui.BootstrapMvcUi
{
    public class BootstrapMvcUiBundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/BootstrapMvcUi").Include( 
                "~/Content/bootstrap-datetimepickjer.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/BootstrapMvcUi").Include(
                "~/Scripts/moment.js",
                "~/Scripts/bootstrap-datetimepicker.min.js",
                "~/Scripts/locale/bootstrap-datetimepicker/nl.js",
                "~/Scripts/jquery.maskMoney.min.js",
                "~/Scripts/jquery.maskedinput.min.js",
                "~/Scripts/jquery.numeric.min.js"));
        }
    }
}
