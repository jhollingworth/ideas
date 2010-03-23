using System;
using System.Linq;
using FluentNHibernate;
using FluentNHibernate.Automapping;
using FluentNHibernate.Conventions;
using Ideas.Core;
using Ideas.Data.NHibernateMaps.Conventions;
using SharpArch.Core.DomainModel;
using SharpArch.Data.NHibernate.FluentNHibernate;
using ForeignKeyConvention=Ideas.Data.NHibernateMaps.Conventions.ForeignKeyConvention;
using ManyToManyTableNameConvention=Ideas.Data.NHibernateMaps.Conventions.ManyToManyTableNameConvention;

namespace Ideas.Data.NHibernateMaps
{
    public class AutoPersistenceModelGenerator : IAutoPersistenceModelGenerator
    {
        #region IAutoPersistenceModelGenerator Members

        public AutoPersistenceModel Generate()
        {
            var mappings = new AutoPersistenceModel();
            
            mappings.AddEntityAssembly(typeof (Class1).Assembly).Where(GetAutoMappingFilter);
            mappings.Conventions.Setup(GetConventions());
            mappings.Setup(GetSetup());
            mappings.UseOverridesFromAssemblyOf<AutoPersistenceModelGenerator>();

            mappings.Override<Idea>(i => i.Map(m => m.Text).CustomSqlType("TEXT"));
            mappings.Override<Comment>(c => c.Map(m => m.Text).CustomSqlType("TEXT"));

            return mappings;
        }

        #endregion

        private static Action<AutoMappingExpressions> GetSetup()
        {
            return c => { c.FindIdentity = type => type.Name == "Id"; };
        }

        private static Action<IConventionFinder> GetConventions()
        {
            return c =>
                {
                    c.Add<ForeignKeyConvention>();
                    c.Add<HasManyConvention>();
                    c.Add<HasManyToManyConvention>();
                    c.Add<ManyToManyTableNameConvention>();
                    c.Add<PrimaryKeyConvention>();
                    c.Add<ReferenceConvention>();
                    c.Add<TableNameConvention>();
                };
        }

        /// <summary>
        /// Provides a filter for only including types which inherit from the IEntityWithTypedId interface.
        /// </summary>
        private static bool GetAutoMappingFilter(Type t)
        {
            return t.IsSubclassOf(typeof (Entity));
        }
    }
}