// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(OracleDbContext))]
    partial class OracleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.LOGMNR_EVOLVE_SEQ$", "'LOGMNR_EVOLVE_SEQ$', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.LOGMNR_SEQ$", "'LOGMNR_SEQ$', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.LOGMNR_UIDS$", "'LOGMNR_UIDS$', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.MVIEW$_ADVSEQ_GENERIC", "'MVIEW$_ADVSEQ_GENERIC', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.MVIEW$_ADVSEQ_ID", "'MVIEW$_ADVSEQ_ID', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.REPCAT$_EXCEPTIONS_S", "'REPCAT$_EXCEPTIONS_S', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.REPCAT$_FLAVOR_NAME_S", "'REPCAT$_FLAVOR_NAME_S', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.REPCAT$_FLAVORS_S", "'REPCAT$_FLAVORS_S', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.REPCAT$_REFRESH_TEMPLATES_S", "'REPCAT$_REFRESH_TEMPLATES_S', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.REPCAT$_REPPROP_KEY", "'REPCAT$_REPPROP_KEY', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.REPCAT$_RUNTIME_PARMS_S", "'REPCAT$_RUNTIME_PARMS_S', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.REPCAT$_TEMP_OUTPUT_S", "'REPCAT$_TEMP_OUTPUT_S', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.REPCAT$_TEMPLATE_OBJECTS_S", "'REPCAT$_TEMPLATE_OBJECTS_S', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.REPCAT$_TEMPLATE_PARMS_S", "'REPCAT$_TEMPLATE_PARMS_S', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.REPCAT$_TEMPLATE_REFGROUPS_S", "'REPCAT$_TEMPLATE_REFGROUPS_S', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.REPCAT$_TEMPLATE_SITES_S", "'REPCAT$_TEMPLATE_SITES_S', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.REPCAT$_USER_AUTHORIZATIONS_S", "'REPCAT$_USER_AUTHORIZATIONS_S', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.REPCAT$_USER_PARM_VALUES_S", "'REPCAT$_USER_PARM_VALUES_S', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.REPCAT_LOG_SEQUENCE", "'REPCAT_LOG_SEQUENCE', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.TEMPLATE$_TARGETS_S", "'TEMPLATE$_TARGETS_S', '', '1', '1', '', '', 'Int64', 'False'");

            modelBuilder.Entity("Domain.Entities.CushionSet", b =>
                {
                    b.Property<int>("CushionSetId")
                        .HasColumnName("CUSHIONSETID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("CushionSetNumber")
                        .IsRequired()
                        .HasColumnName("CUSHIONSETNUMBER")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("RollNumber")
                        .HasColumnName("ROLLNUMBER")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CushionSetId")
                        .HasName("CUSHIONSSETS_PK");

                    b.ToTable("CUSHIONSSETS");
                });
#pragma warning restore 612, 618
        }
    }
}
