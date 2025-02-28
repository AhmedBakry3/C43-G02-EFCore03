using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_Session_3_EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class CreateStud_CoursesTableWithManyToManyRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseDuration = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CourseName = table.Column<string>(type: "VarChar(50)", nullable: false),
                    CourseDecription = table.Column<string>(type: "VarChar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstructorName = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    InstructorBouns = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    InstructorSalary = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    InstructorAddress = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: false),
                    InstructorHourRate = table.Column<decimal>(type: "decimal(17,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentFirstName = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    StudentLastName = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    StudentAddress = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stud_Course",
                columns: table => new
                {
                    Stud_ID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stud_Course", x => new { x.Stud_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_Stud_Course_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stud_Course_Students_Stud_ID",
                        column: x => x.Stud_ID,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_Course_ID",
                table: "Stud_Course",
                column: "Course_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Stud_Course");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
