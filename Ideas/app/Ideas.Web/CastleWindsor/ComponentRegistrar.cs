﻿using Castle.Windsor;
using RPXLib.Interfaces;
using SharpArch.Core.PersistenceSupport.NHibernate;
using SharpArch.Data.NHibernate;
using SharpArch.Core.PersistenceSupport;
using SharpArch.Web.Castle;
using Castle.MicroKernel.Registration;
using SharpArch.Core.CommonValidator;
using SharpArch.Core.NHibernateValidator.CommonValidatorAdapter;
using RPXLib;

namespace Ideas.Web.CastleWindsor
{
    public class ComponentRegistrar
    {
        public static void AddComponentsTo(IWindsorContainer container)
        {
            AddGenericRepositoriesTo(container);
            AddCustomRepositoriesTo(container);
            AddApplicationServicesTo(container);

            container.AddComponent("validator",
                typeof(IValidator), typeof(Validator));

            container.Register(Component.For<IRPXService>().ImplementedBy<RPXService>());
            container.Register(Component.For<IRPXApiSettings>().ImplementedBy<RPXApiSettings>());
        }

        private static void AddApplicationServicesTo(IWindsorContainer container)
        {
            container.Register(
                AllTypes.Pick()
                .FromAssemblyNamed("Ideas.ApplicationServices")
                .WithService.FirstInterface());
        }

        private static void AddCustomRepositoriesTo(IWindsorContainer container)
        {
            container.Register(
                AllTypes.Pick()
                .FromAssemblyNamed("Ideas.Data")
                .WithService.FirstNonGenericCoreInterface("Ideas.Core"));
        }

        private static void AddGenericRepositoriesTo(IWindsorContainer container)
        {
            container.AddComponent("entityDuplicateChecker",
                typeof(IEntityDuplicateChecker), typeof(EntityDuplicateChecker));
            container.AddComponent("repositoryType",
                typeof(IRepository<>), typeof(Repository<>));
            container.AddComponent("nhibernateRepositoryType",
                typeof(INHibernateRepository<>), typeof(NHibernateRepository<>));
            container.AddComponent("repositoryWithTypedId",
                typeof(IRepositoryWithTypedId<,>), typeof(RepositoryWithTypedId<,>));
            container.AddComponent("nhibernateRepositoryWithTypedId",
                typeof(INHibernateRepositoryWithTypedId<,>), typeof(NHibernateRepositoryWithTypedId<,>));
        }
    }
}
