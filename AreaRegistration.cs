using System.Web.Mvc;

namespace SoftSupply.Help.Areas.GanSoftWeb
{
    public class GanSoftWebAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "GanSoftWeb";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                AreaName,
                AreaName + "/{controller}/{action}/{id}",
                new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}