

using Assignment_Session_3_EF_Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Assignment_Session_1_EF_Core.Models
{
    //Model : Poco Class [Plaing Old CLR Object] - Domain Entity
    [Table("Courses")]
    internal class Course
    {
        //#region By Convention
        //public int Id { get; set; }


        //public decimal Duration { get; set; }

        //public string? Name { get; set; }

        //public string? Description { get; set; }

        ////Foreign Key
        //public int CourseTopicId { get; set; }

        ////Navigation Preoprty For Topic : [One]
        //public Topic? CourseTopic { get; set; }

        //#endregion

        #region By Annontation
        [Key]
        public int CourseId { get; set; } 

        [Column("CourseDuration", TypeName = "decimal(10,2)")]
        public decimal Duration { get; set; }

        [Required]
        [Column("CourseName", TypeName = "VarChar(50)")]
        public string? Name { get; set; }
      

        [Required]
        [Column("CourseDecription", TypeName = "VarChar(50)")]
        public string? Description { get; set; }

        //Navigation Property For Stud_Courses Table [Many]
        [InverseProperty(nameof(Stud_Course.Courses))]
        public virtual ICollection<Stud_Course> stud_Courses { get; set; } = new HashSet<Stud_Course>();


        //Navigation Property For Course_Inst Table [Many]
        [InverseProperty(nameof(Course_Inst.Courses))]
        public virtual ICollection<Course_Inst> course_inst { get; set; } = new HashSet<Course_Inst>();

        #endregion

    }

}
