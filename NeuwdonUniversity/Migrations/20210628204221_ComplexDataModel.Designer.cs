using System;
using NeuwdonUniversity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace NeuwdonUniversity.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20190327175104_ComplexDataModel")]
    partial class ComplexDataModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NeuwdonUniversity.Models.Course", b =>
            {
                b.Property<int>("CourseID");

                b.Property<int>("Credits");

                b.Property<int>("DepartmentID");

                b.Property<string>("Title")
                    .HasMaxLength(50);

                b.HasKey("CourseID");

                b.HasIndex("DepartmentID");

                b.ToTable("Course");
            });

            modelBuilder.Entity("NeuwdonUniversity.Models.CourseAssignment", b =>
            {
                b.Property<int>("CourseID");

                b.Property<int>("InstructorID");

                b.HasKey("CourseID", "InstructorID");

                b.HasIndex("InstructorID");

                b.ToTable("CourseAssignment");
            });

            modelBuilder.Entity("NeuwdonUniversity.Models.Department", b =>
            {
                b.Property<int>("DepartmentID")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<decimal>("Budget")
                    .HasColumnType("money");

                b.Property<int?>("InstructorID");

                b.Property<string>("Name")
                    .HasMaxLength(50);

                b.Property<DateTime>("StartDate");

                b.HasKey("DepartmentID");

                b.HasIndex("InstructorID");

                b.ToTable("Department");
            });

            modelBuilder.Entity("NeuwdonUniversity.Models.Enrollment", b =>
            {
                b.Property<int>("EnrollmentID")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("CourseID");

                b.Property<int?>("Grade");

                b.Property<int>("StudentID");

                b.HasKey("EnrollmentID");

                b.HasIndex("CourseID");

                b.HasIndex("StudentID");

                b.ToTable("Enrollment");
            });

            modelBuilder.Entity("NeuwdonUniversity.Models.Instructor", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("FirstMidName")
                    .IsRequired()
                    .HasColumnName("FirstName")
                    .HasMaxLength(50);

                b.Property<DateTime>("HireDate");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasMaxLength(50);

                b.HasKey("ID");

                b.ToTable("Instructor");
            });

            modelBuilder.Entity("NeuwdonUniversity.Models.OfficeAssignment", b =>
            {
                b.Property<int>("InstructorID");

                b.Property<string>("Location")
                    .HasMaxLength(50);

                b.HasKey("InstructorID");

                b.ToTable("OfficeAssignment");
            });

            modelBuilder.Entity("NeuwdonUniversity.Models.Student", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("EnrollmentDate");

                b.Property<string>("FirstMidName")
                    .IsRequired()
                    .HasColumnName("FirstName")
                    .HasMaxLength(50);

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasMaxLength(50);

                b.HasKey("ID");

                b.ToTable("Student");
            });

            modelBuilder.Entity("NeuwdonUniversity.Models.Course", b =>
            {
                b.HasOne("NeuwdonUniversity.Models.Department", "Department")
                    .WithMany("Courses")
                    .HasForeignKey("DepartmentID")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("NeuwdonUniversity.Models.CourseAssignment", b =>
            {
                b.HasOne("NeuwdonUniversity.Models.Course", "Course")
                    .WithMany("CourseAssignments")
                    .HasForeignKey("CourseID")
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("NeuwdonUniversity.Models.Instructor", "Instructor")
                    .WithMany("CourseAssignments")
                    .HasForeignKey("InstructorID")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("NeuwdonUniversity.Models.Department", b =>
            {
                b.HasOne("NeuwdonUniversity.Models.Instructor", "Administrator")
                    .WithMany()
                    .HasForeignKey("InstructorID");
            });

            modelBuilder.Entity("NeuwdonUniversity.Models.Enrollment", b =>
            {
                b.HasOne("NeuwdonUniversity.Models.Course", "Course")
                    .WithMany("Enrollments")
                    .HasForeignKey("CourseID")
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("NeuwdonUniversity.Models.Student", "Student")
                    .WithMany("Enrollments")
                    .HasForeignKey("StudentID")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("NeuwdonUniversity.Models.OfficeAssignment", b =>
            {
                b.HasOne("NeuwdonUniversity.Models.Instructor", "Instructor")
                    .WithOne("OfficeAssignment")
                    .HasForeignKey("NeuwdonUniversity.Models.OfficeAssignment", "InstructorID")
                    .OnDelete(DeleteBehavior.Cascade);
            });
#pragma warning restore 612, 618
        }
    }
}