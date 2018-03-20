using System.Web;
using System.Web.Optimization;

namespace WebUIMVC
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备就绪，请使用 https://modernizr.com 上的生成工具仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/bundles/libCss").Include("~/Content/assets/css/bootstrap.min.css").Include("~/Content/assets/vendor/font-awesome/css/font-awesome.min.css").Include("~/Content/assets/vendor/linearicons/style.css").Include("~/Content/assets/css/main.css").Include("~/Content/assets/css/pagerstyles.css"));
            bundles.Add(new StyleBundle("~/bundles/app").Include("~/Content/css/app.css"));
            bundles.Add(new ScriptBundle("~/bundles/util").Include("~/Content/js/util.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-slimscroll").Include("~/Content/assets/vendor/jquery-slimscroll/jquery.slimscroll.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/klorofil-common").Include("~/Content/assets/scripts/klorofil-common.js"));
            bundles.Add(new ScriptBundle("~/bundles/Ueditor").Include("~/Content/lib/ueditor/ueditor.config.js").Include("~/Content/lib/ueditor/ueditor.all.js").Include("~/Content/lib/ueditor/lang/zh-cn/zh-cn.js"));
        }
    }
}
