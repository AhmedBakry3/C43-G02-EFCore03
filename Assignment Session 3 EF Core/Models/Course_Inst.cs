using Assignment_Session_1_EF_Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Assignment_Session_3_EF_Core.Models
{
    #region By Data Annotation
    [PrimaryKey(nameof(Inst_ID), nameof(Course_ID))]
    internal class Course_Inst
    {
        [ForeignKey(nameof(instructors))]
        public int Inst_ID { get; set; }
        [ForeignKey(nameof(Courses))]
        public int Course_ID { get; set; }

        public int Evaluate { get; set; }

        //Navigation Property For Student Table [One]
        [InverseProperty(nameof(Instructor.course_Inst))]
        public virtual Instructor instructors { get; set; } = null!;

        //Navigation Property For Course Table [One]
        [InverseProperty(nameof(Course.course_inst))]
        public virtual Course Courses { get; set; } = null!;
    } 
    #endregion
}
