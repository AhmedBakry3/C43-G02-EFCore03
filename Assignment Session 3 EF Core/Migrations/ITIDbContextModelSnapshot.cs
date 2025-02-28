﻿// <auto-generated />
using Assignment_Session_1_EF_Core.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment_Session_3_EF_Core.Migrations
{
    [DbContext(typeof(ITIDbContext))]
    partial class ITIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignment_Session_1_EF_Core.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VarChar(50)")
                        .HasColumnName("CourseDecription");

                    b.Property<decimal>("Duration")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("CourseDuration");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VarChar(50)")
                        .HasColumnName("CourseName");

                    b.HasKey("CourseId");

                    b.ToTable("Courses", (string)null);
                });

            modelBuilder.Entity("Assignment_Session_1_EF_Core.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VarChar")
                        .HasColumnName("InstructorAddress");

                    b.Property<decimal>("Bouns")
                        .HasColumnType("decimal(11,2)")
                        .HasColumnName("InstructorBouns");

                    b.Property<decimal>("HourRate")
                        .HasColumnType("decimal(17,2)")
                        .HasColumnName("InstructorHourRate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar")
                        .HasColumnName("InstructorName");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(9,2)")
                        .HasColumnName("InstructorSalary");

                    b.HasKey("Id");

                    b.ToTable("Instructors", (string)null);
                });

            modelBuilder.Entity("Assignment_Session_1_EF_Core.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar")
                        .HasColumnName("StudentAddress");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar")
                        .HasColumnName("StudentFirstName");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar")
                        .HasColumnName("StudentLastName");

                    b.HasKey("Id");

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("Assignment_Session_3_EF_Core.Models.Course_Inst", b =>
                {
                    b.Property<int>("Inst_ID")
                        .HasColumnType("int");

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("Evaluate")
                        .HasColumnType("int");

                    b.HasKey("Inst_ID", "Course_ID");

                    b.HasIndex("Course_ID");

                    b.ToTable("Course_Inst", (string)null);
                });

            modelBuilder.Entity("Assignment_Session_3_EF_Core.Models.Stud_Course", b =>
                {
                    b.Property<int>("Stud_ID")
                        .HasColumnType("int");

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<decimal>("Grade")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Stud_ID", "Course_ID");

                    b.HasIndex("Course_ID");

                    b.ToTable("Stud_Course", (string)null);
                });

            modelBuilder.Entity("Assignment_Session_3_EF_Core.Models.Course_Inst", b =>
                {
                    b.HasOne("Assignment_Session_1_EF_Core.Models.Course", "Courses")
                        .WithMany("course_inst")
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment_Session_1_EF_Core.Models.Instructor", "instructors")
                        .WithMany("course_Inst")
                        .HasForeignKey("Inst_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");

                    b.Navigation("instructors");
                });

            modelBuilder.Entity("Assignment_Session_3_EF_Core.Models.Stud_Course", b =>
                {
                    b.HasOne("Assignment_Session_1_EF_Core.Models.Course", "Courses")
                        .WithMany("stud_Courses")
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment_Session_1_EF_Core.Models.Student", "Students")
                        .WithMany("stud_Courses")
                        .HasForeignKey("Stud_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Assignment_Session_1_EF_Core.Models.Course", b =>
                {
                    b.Navigation("course_inst");

                    b.Navigation("stud_Courses");
                });

            modelBuilder.Entity("Assignment_Session_1_EF_Core.Models.Instructor", b =>
                {
                    b.Navigation("course_Inst");
                });

            modelBuilder.Entity("Assignment_Session_1_EF_Core.Models.Student", b =>
                {
                    b.Navigation("stud_Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
