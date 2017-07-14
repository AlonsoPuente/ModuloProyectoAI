using System.Web.Mvc;

namespace Modulo5.Areas.Invitado
{
    public class InvitadoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Invitado";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Invitado_default",
                "Invitado/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}