using Application.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public partial class OracleDbContext : DbContext, IOracleDbContext
    {
        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options)
        {
        }

        public DbSet<CushionSet> CushionsSets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CushionSet>(entity =>
            {
                entity.HasKey(e => e.CushionSetId)
                    .HasName("CUSHIONSSETS_PK");

                entity.ToTable("CUSHIONSSETS");

                entity.Property(e => e.CushionSetId)
                    .HasColumnName("CUSHIONSETID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CushionSetNumber)
                    .IsRequired()
                    .HasColumnName("CUSHIONSETNUMBER");

                entity.Property(e => e.RollNumber).HasColumnName("ROLLNUMBER");
            });

            modelBuilder.HasSequence("LOGMNR_EVOLVE_SEQ$");

            modelBuilder.HasSequence("LOGMNR_SEQ$");

            modelBuilder.HasSequence("LOGMNR_UIDS$");

            modelBuilder.HasSequence("MVIEW$_ADVSEQ_GENERIC");

            modelBuilder.HasSequence("MVIEW$_ADVSEQ_ID");

            modelBuilder.HasSequence("REPCAT$_EXCEPTIONS_S");

            modelBuilder.HasSequence("REPCAT$_FLAVOR_NAME_S");

            modelBuilder.HasSequence("REPCAT$_FLAVORS_S");

            modelBuilder.HasSequence("REPCAT$_REFRESH_TEMPLATES_S");

            modelBuilder.HasSequence("REPCAT$_REPPROP_KEY");

            modelBuilder.HasSequence("REPCAT$_RUNTIME_PARMS_S");

            modelBuilder.HasSequence("REPCAT$_TEMP_OUTPUT_S");

            modelBuilder.HasSequence("REPCAT$_TEMPLATE_OBJECTS_S");

            modelBuilder.HasSequence("REPCAT$_TEMPLATE_PARMS_S");

            modelBuilder.HasSequence("REPCAT$_TEMPLATE_REFGROUPS_S");

            modelBuilder.HasSequence("REPCAT$_TEMPLATE_SITES_S");

            modelBuilder.HasSequence("REPCAT$_USER_AUTHORIZATIONS_S");

            modelBuilder.HasSequence("REPCAT$_USER_PARM_VALUES_S");

            modelBuilder.HasSequence("REPCAT_LOG_SEQUENCE");

            modelBuilder.HasSequence("TEMPLATE$_TARGETS_S");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
