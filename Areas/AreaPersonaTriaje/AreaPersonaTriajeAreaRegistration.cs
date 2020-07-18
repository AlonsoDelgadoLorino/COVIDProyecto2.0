using System.Web.Mvc;

namespace TRIAJE_COVID.Areas.AreaPersonaTriaje
{
    public class AreaPersonaTriajeAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AreaPersonaTriaje";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AreaPersonaTriaje_default",
                "AreaPersonaTriaje/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}