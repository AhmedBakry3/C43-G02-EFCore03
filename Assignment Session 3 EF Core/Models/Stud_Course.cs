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
    [PrimaryKey(nameof(Stud_ID), nameof(Course_ID))]
    internal class Stud_Course
    {
        #region By Data Annotation
        [ForeignKey(nameof(Students))]
        public int? Stud_ID { get; set; }
        [ForeignKey(nameof(Courses))]
        public int? Course_ID { get; set; }
        public decimal Grade { get; set; }

        //Navigation Property For Student Table [One]
        [InverseProperty(nameof(Student.stud_Courses))]
        public virtual Student Students { get; set; } = null!;

        //Navigation Property For Course Table [One]
        [InverseProperty(nameof(Course.stud_Courses))]
        public virtual Course Courses { get; set; } = null!;
        #endregion
    }
}
