using System.Web.Mvc;

namespace COVIDProyecto2._0.Areas.PersonalAdmin
{
    public class PersonalAdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "PersonalAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "PersonalAdmin_default",
                "PersonalAdmin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}