using System.Data.Entity.Migrations;
using System.Web.Mvc;
using System.Web.Routing;
using Elmah.Contrib.Mvc;
using NuGetGallery.Migrations;
using Ninject;

[assembly: WebActivator.PreApplicationStartMethod(typeof(NuGetGallery.Bootstrapper), "Start")]
namespace NuGetGallery
{
    public static class Bootstrapper
    {
        public static void Start()
        {
            UpdateDatabase();
            Routes.RegisterRoutes(RouteTable.Routes);

            DynamicDataEFCodeFirst.Registration.Register(RouteTable.Routes);

            // TODO: move profile bootstrapping and container bootstrapping to here
            GlobalFilters.Filters.Add(new ElmahHandleErrorAttribute());

            ValueProviderFactories.Factories.Add(new HttpHeaderValueProviderFactory());

            CreateIndexes();
        }

        private static void CreateIndexes()
        {
            var packageSvc = Container.Kernel.Get<IPackageService>();
            var packages = packageSvc.GetLatestPackageVersions(allowPrerelease: true);
            var indexingSvc = Container.Kernel.Get<IIndexingService>();
            indexingSvc.CreateIndex(packages);
        }

        private static void UpdateDatabase()
        {
            var dbMigrator = new DbMigrator(new Settings());
            dbMigrator.Update();
            // The Seed method of Settings is never called, so 
            // we call it here again as a workaround.
            Settings.SeedDatabase(new EntitiesContext());
        }
    }
}