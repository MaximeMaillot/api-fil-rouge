﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fil_rouge_api.Data;

#nullable disable

namespace fil_rouge_api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230523084821_FixProjectUserForeignKey")]
    partial class FixProjectUserForeignKey
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("fil_rouge_api.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7533),
                            Message = "Coucou",
                            TaskId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7565),
                            Message = "salut",
                            TaskId = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7567),
                            Message = "Ca va ?",
                            TaskId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7568),
                            Message = "Invisible",
                            TaskId = 3,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("fil_rouge_api.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7498),
                            Description = "Je suis un déscriptif du projet fil rouge",
                            Name = "Projet fil rouge"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7502),
                            Description = "La déscription du projet test",
                            Name = "Un projet test"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7504),
                            Description = "Il ne devrait pas être visible car personne n'est assigné à celui-ci",
                            Name = "Le projet invisible"
                        });
                });

            modelBuilder.Entity("fil_rouge_api.Models.ProjectUser", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.HasKey("UserId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectUser");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            ProjectId = 1,
                            IsAdmin = true
                        },
                        new
                        {
                            UserId = 2,
                            ProjectId = 1,
                            IsAdmin = true
                        },
                        new
                        {
                            UserId = 3,
                            ProjectId = 1,
                            IsAdmin = false
                        },
                        new
                        {
                            UserId = 1,
                            ProjectId = 2,
                            IsAdmin = false
                        },
                        new
                        {
                            UserId = 2,
                            ProjectId = 2,
                            IsAdmin = false
                        },
                        new
                        {
                            UserId = 3,
                            ProjectId = 2,
                            IsAdmin = true
                        });
                });

            modelBuilder.Entity("fil_rouge_api.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7512),
                            Description = "C'est notre boulot",
                            Name = "Faire du beau code",
                            ProjectId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7523),
                            Description = "Ca on sait faire",
                            Name = "Déprimer",
                            ProjectId = 1,
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7525),
                            Description = "La solution à tous les problèmes",
                            Name = "Devenir alcoolique",
                            ProjectId = 1,
                            Status = 2
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7526),
                            Description = "On y croit",
                            Name = "Faire le projet test",
                            ProjectId = 2,
                            Status = 0
                        },
                        new
                        {
                            Id = 5,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7528),
                            Description = "C'est compliqué",
                            Name = "Comprendre le projet test",
                            ProjectId = 2,
                            Status = 0
                        },
                        new
                        {
                            Id = 6,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7530),
                            Description = "Ne faire qu'un avec les bugs",
                            Name = "Devenir le projet test",
                            ProjectId = 2,
                            Status = 0
                        },
                        new
                        {
                            Id = 7,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7531),
                            Description = "Personne ne va te voir",
                            Name = "La tâche invisible",
                            ProjectId = 3,
                            Status = 0
                        });
                });

            modelBuilder.Entity("fil_rouge_api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7417),
                            Email = "maxime@fil-rouge.com",
                            Name = "Maxime",
                            Password = "MTExMUxhIHB1aXNzYW5jZSBkZSBsYSBzZWNyZXQga2V5"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7476),
                            Email = "fred@fil-rouge.com",
                            Name = "Fred",
                            Password = "MjIyMkxhIHB1aXNzYW5jZSBkZSBsYSBzZWNyZXQga2V5"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7485),
                            Email = "avril@fil-rouge.com",
                            Name = "Avril",
                            Password = "MzMzTGEgcHVpc3NhbmNlIGRlIGxhIHNlY3JldCBrZXk="
                        });
                });

            modelBuilder.Entity("fil_rouge_api.Models.Comment", b =>
                {
                    b.HasOne("fil_rouge_api.Models.Task", "Task")
                        .WithMany("Comments")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fil_rouge_api.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("User");
                });

            modelBuilder.Entity("fil_rouge_api.Models.ProjectUser", b =>
                {
                    b.HasOne("fil_rouge_api.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fil_rouge_api.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("fil_rouge_api.Models.Task", b =>
                {
                    b.HasOne("fil_rouge_api.Models.Project", "Project")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("fil_rouge_api.Models.Project", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("fil_rouge_api.Models.Task", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("fil_rouge_api.Models.User", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
