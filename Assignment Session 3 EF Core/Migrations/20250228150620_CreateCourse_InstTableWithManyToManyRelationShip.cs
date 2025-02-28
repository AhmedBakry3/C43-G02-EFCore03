using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_Session_3_EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class CreateCourse_InstTableWithManyToManyRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course_Inst",
                columns: table => new
                {
                    Inst_ID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    Evaluate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Inst", x => new { x.Inst_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_Course_Inst_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Course_Inst_Instructors_Inst_ID",
                        column: x => x.Inst_ID,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_Inst_Course_ID",
                table: "Course_Inst",
                column: "Course_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course_Inst");
        }
    }
}
