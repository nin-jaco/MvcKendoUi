using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using EvolutionRepository.ManualModels;

namespace EvolutionWeb
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);  //Because of Kendo, rather put all CSS and JS references directly into Views\Shared\_layout.cshtml
            
            //Database.SetInitializer<EvolutionWebContext>(null);

            // This line forces JSON serialization (strange, I know - it should be the other way round) even when browser asks for XML
            // GlobalConfiguration.Configuration.Formatters.XmlFormatter.UseXmlSerializer = true;
            
        }
    }
}