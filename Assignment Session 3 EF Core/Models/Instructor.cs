
using Assignment_Session_3_EF_Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Assignment_Session_1_EF_Core.Models
{
    
    internal class Instructor
    {

        //#region By Convention
        //public int Id { get; set; } 

        //public string? Name { get; set; }

        //public decimal Bouns { get; set; }

        //public decimal Salary { get; set; }

        //public string? Address { get; set; }


        //public decimal HourRate { get; set; }


        //public int WorksInInstructorDepartmentId { get; set; }

        ////Navigation Property For WorksIn RelationShip [One]
        //public Department? WorksInInstructorDepartment { get; set; }
        //#endregion

        ////Navigation Property For WorksIn RelationShip [One]
        //public Department? ManagesInstDept { get; set; }

        #region By Annonation
        [Key]
        public int Id { get; set; } //Pk with identity Constraint [1,1]



        [Required]
        [Column("InstructorName", TypeName = "VarChar")]
        [StringLength(50, MinimumLength = 3)] //Since that Min is an Application Validation , It will not be Mapped
        //Only Max (50) Will be Mapped
        public string? Name { get; set; }


        [Column("InstructorBouns", TypeName = "decimal(11,2)")]
        public decimal Bouns { get; set; }

        [Column("InstructorSalary", TypeName = "decimal(9,2)")]
        public decimal Salary { get; set; }

        [Required]
        [Column("InstructorAddress", TypeName = "VarChar")]
        [StringLength(100, MinimumLength = 3)] //Since that Min is an Application Validation , It will not be Mapped

        public string Address { get; set; }


        [Column("InstructorHourRate", TypeName = "decimal(17,2)")]
        public decimal HourRate { get; set; }


        //Navigation Property For Course_Inst Table [Many]
        [InverseProperty(nameof(Course_Inst.instructors))]
        public virtual ICollection<Course_Inst> course_Inst { get; set; } = new HashSet<Course_Inst>();

        #endregion
    }
}
