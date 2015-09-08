using System.Web.Mvc;
using System.IO;
namespace MyWebPageApp.Infrastructure
{
    // Creat a CustomeView
    // We pass object of Custome View type to ViewEngineResult Constructor
    public class CustomDataView :  IView
    {
        public void Render(ViewContext viewContext, TextWriter textWriter)
        {
            //viewContext provides information about the request and the output
            //from the action Method

            //textWriter writing output to the client
            textWriter.Write("Creating Custome View");
        }
    }

    //Creat CustomeViewEngine that creat ViewEngineResult object
    public class CustomViewEngine : IViewEngine
    {
        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName,
                string masterName, bool useCache)
        {
            if (viewName == "CustomData")
            {
                /// <returns>Creat and return ViewEngineResutl Type</returns>
                /// <param> CustomeDataView object </param>
                /// <param> CustomeViewEngine object </param>
                return new ViewEngineResult(new CustomDataView(), this);
            }
            else
            {
                ///Creat ViewEngineResult Type object using second Constructor
                ///that takes IEnumerable Searched location as a parameter
                return new ViewEngineResult(new string[] { "No View Found" });
            }
        }
        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName,
                bool useCache)
        {
            return new ViewEngineResult(new string[] { "No View Found" });
        }
        public void ReleaseView(ControllerContext controllerContext, IView view) { }
    }
}