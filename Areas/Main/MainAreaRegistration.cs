using System.Web.Mvc;

namespace COVIDProyecto2._0.Areas.Main
{
    public class MainAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Main";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Main_default",
                "Main/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}