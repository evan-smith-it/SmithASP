﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmithASP.Models.DbContexts;

namespace SmithASP.Migrations.Workout
{
    [DbContext(typeof(WorkoutContext))]
    [Migration("20190905214611_InitialWorkoutMigration")]
    partial class InitialWorkoutMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmithASP.Models.Workout.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("SmithASP.Models.Workout.ExerciseMuscleGroup", b =>
                {
                    b.Property<int>("ExerciseId");

                    b.Property<int>("MuscleGroupId");

                    b.HasKey("ExerciseId", "MuscleGroupId");

                    b.ToTable("ExerciseMuscleGroups");
                });

            modelBuilder.Entity("SmithASP.Models.Workout.MuscleGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ExerciseId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.ToTable("MuscleGroups");
                });

            modelBuilder.Entity("SmithASP.Models.Workout.MuscleGroup", b =>
                {
                    b.HasOne("SmithASP.Models.Workout.Exercise")
                        .WithMany("MuscleGroups")
                        .HasForeignKey("ExerciseId");
                });
#pragma warning restore 612, 618
        }
    }
}
