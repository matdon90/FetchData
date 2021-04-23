using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class OracleDbInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "LOGMNR_EVOLVE_SEQ$");

            migrationBuilder.CreateSequence(
                name: "LOGMNR_SEQ$");

            migrationBuilder.CreateSequence(
                name: "LOGMNR_UIDS$");

            migrationBuilder.CreateSequence(
                name: "MVIEW$_ADVSEQ_GENERIC");

            migrationBuilder.CreateSequence(
                name: "MVIEW$_ADVSEQ_ID");

            migrationBuilder.CreateSequence(
                name: "REPCAT$_EXCEPTIONS_S");

            migrationBuilder.CreateSequence(
                name: "REPCAT$_FLAVOR_NAME_S");

            migrationBuilder.CreateSequence(
                name: "REPCAT$_FLAVORS_S");

            migrationBuilder.CreateSequence(
                name: "REPCAT$_REFRESH_TEMPLATES_S");

            migrationBuilder.CreateSequence(
                name: "REPCAT$_REPPROP_KEY");

            migrationBuilder.CreateSequence(
                name: "REPCAT$_RUNTIME_PARMS_S");

            migrationBuilder.CreateSequence(
                name: "REPCAT$_TEMP_OUTPUT_S");

            migrationBuilder.CreateSequence(
                name: "REPCAT$_TEMPLATE_OBJECTS_S");

            migrationBuilder.CreateSequence(
                name: "REPCAT$_TEMPLATE_PARMS_S");

            migrationBuilder.CreateSequence(
                name: "REPCAT$_TEMPLATE_REFGROUPS_S");

            migrationBuilder.CreateSequence(
                name: "REPCAT$_TEMPLATE_SITES_S");

            migrationBuilder.CreateSequence(
                name: "REPCAT$_USER_AUTHORIZATIONS_S");

            migrationBuilder.CreateSequence(
                name: "REPCAT$_USER_PARM_VALUES_S");

            migrationBuilder.CreateSequence(
                name: "REPCAT_LOG_SEQUENCE");

            migrationBuilder.CreateSequence(
                name: "TEMPLATE$_TARGETS_S");

            migrationBuilder.CreateTable(
                name: "CUSHIONSSETS",
                columns: table => new
                {
                    CUSHIONSETID = table.Column<int>(nullable: false),
                    ROLLNUMBER = table.Column<int>(nullable: false),
                    CUSHIONSETNUMBER = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CUSHIONSSETS_PK", x => x.CUSHIONSETID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CUSHIONSSETS");

            migrationBuilder.DropSequence(
                name: "LOGMNR_EVOLVE_SEQ$");

            migrationBuilder.DropSequence(
                name: "LOGMNR_SEQ$");

            migrationBuilder.DropSequence(
                name: "LOGMNR_UIDS$");

            migrationBuilder.DropSequence(
                name: "MVIEW$_ADVSEQ_GENERIC");

            migrationBuilder.DropSequence(
                name: "MVIEW$_ADVSEQ_ID");

            migrationBuilder.DropSequence(
                name: "REPCAT$_EXCEPTIONS_S");

            migrationBuilder.DropSequence(
                name: "REPCAT$_FLAVOR_NAME_S");

            migrationBuilder.DropSequence(
                name: "REPCAT$_FLAVORS_S");

            migrationBuilder.DropSequence(
                name: "REPCAT$_REFRESH_TEMPLATES_S");

            migrationBuilder.DropSequence(
                name: "REPCAT$_REPPROP_KEY");

            migrationBuilder.DropSequence(
                name: "REPCAT$_RUNTIME_PARMS_S");

            migrationBuilder.DropSequence(
                name: "REPCAT$_TEMP_OUTPUT_S");

            migrationBuilder.DropSequence(
                name: "REPCAT$_TEMPLATE_OBJECTS_S");

            migrationBuilder.DropSequence(
                name: "REPCAT$_TEMPLATE_PARMS_S");

            migrationBuilder.DropSequence(
                name: "REPCAT$_TEMPLATE_REFGROUPS_S");

            migrationBuilder.DropSequence(
                name: "REPCAT$_TEMPLATE_SITES_S");

            migrationBuilder.DropSequence(
                name: "REPCAT$_USER_AUTHORIZATIONS_S");

            migrationBuilder.DropSequence(
                name: "REPCAT$_USER_PARM_VALUES_S");

            migrationBuilder.DropSequence(
                name: "REPCAT_LOG_SEQUENCE");

            migrationBuilder.DropSequence(
                name: "TEMPLATE$_TARGETS_S");
        }
    }
}
