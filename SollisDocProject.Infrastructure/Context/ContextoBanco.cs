
using SollisDocProject.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SollisDocProject.Infrastructure.Data.Context
{
    public class ContextoBanco : DbContext
    {
        public ContextoBanco() : base("ProjectDocHomologacao")
        {

        }

        /** Prepara DbSet para a criação das Tabelas via Migration */
        /** Configura e Mapeia o Entity para aplicar as Entidades na criação das Tabelas **/
        public DbSet<CadCplxAna> CadCplxAna { get; set; }
        public DbSet<CadCplxProg> CadCplxProg { get; set; }
        public DbSet<CadEmpresa> CadEmpresa { get; set; }
        public DbSet<CadModulos> CadModulos { get; set; }
        public DbSet<CadSistema> CadSistema { get; set; }
        public DbSet<CadStatus> CadStatus { get; set; }
        public DbSet<CadMotivo> CadMotivo { get; set; }
        public DbSet<CadStProjeto> CadStProjeto { get; set; }
        public DbSet<MovtoProjeto> MovtoProjeto { get; set; }
        public DbSet<MovtoSolicProjeto> MovtoSolicProjeto { get; set; }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        /** Método para retirar convenções setadas pelo SQL SERVER **/
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            /** Seta algumas propriedades de Campos **/
            //modelBuilder.Properties().Where(p => p.Id == p.ReflectedType.Id + "Name").Configure(p => p.IsKey());
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("Varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));


            /** Mapeamento do ConfigurationsEF **/
            //modelBuilder.Configurations.Add(new CadCplxAnaMap());
            //modelBuilder.Configurations.Add(new CadCplxProgMap());
            //modelBuilder.Configurations.Add(new CadEmpresaMap());
            //modelBuilder.Configurations.Add(new CadModulosMap());
            //modelBuilder.Configurations.Add(new CadSistemaMap());
            //modelBuilder.Configurations.Add(new CadStatusMap());
            //modelBuilder.Configurations.Add(new CadStProjetoMap());
            //modelBuilder.Configurations.Add(new MovtoProjetoMap());
            //modelBuilder.Configurations.Add(new MovtoSolicProjetoMap());


            base.OnModelCreating(modelBuilder);
        }
}
