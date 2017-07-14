using System.Web.Mvc;

namespace Modulo5.Areas.Profesor
{
    public class ProfesorAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Profesor";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Profesor_default",
                "Profesor/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}