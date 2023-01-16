using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace ASPNetCoreAjax
{
    public class Helper
    {
        public static string RenderRazorToView(Controller controller, string viewName,object model = null)
        {
            controller.ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var component = controller.ViewComponent(viewName);
                IViewEngine viewEngine = controller.HttpContext.RequestServices.GetServices(typeof (ICompositeViewEngine)).FirstOrDefault() as ICompositeViewEngine;
                ViewEngineResult viewResult = viewEngine.FindView(controller.ControllerContext, viewName, false);
                ViewContext viewContext = new ViewContext(
                    controller.ControllerContext,
                    viewResult.View,
                    controller.ViewData,
                    controller.TempData,
                    sw,
                    new Microsoft.AspNetCore.Mvc.ViewFeatures.HtmlHelperOptions()
                    );
                viewResult.View.RenderAsync(viewContext);
                return sw.GetStringBuilder().ToString();
            }
        }
    }
}
