using fil_rouge_api.Models;
using fil_rouge_api.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;
using System.Text;

namespace fil_rouge_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectUser>().HasKey(table => new {
                table.UserId,
                table.ProjectId
            });

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Projects)
                .UsingEntity<ProjectUser>(
                    r => r.HasOne(e => e.User).WithMany().HasForeignKey(e => e.UserId),
                    l => l.HasOne(e => e.Project).WithMany().HasForeignKey(e => e.ProjectId)
                );

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Tasks)
                .WithOne(e => e.Project)
                .HasForeignKey(e => e.ProjectId)
                .IsRequired();

            modelBuilder.Entity<Models.Task>()
                .HasMany(e => e.Comments)
                .WithOne(e => e.Task)
                .HasForeignKey(e => e.TaskId)
                .IsRequired();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Comments)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            List<User> users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Name = "Maxime",
                    Email = "maxime@fil-rouge.com",
                    Password = PasswordService.EncryptPassword("1111")
                },
                new User()
                {
                    Id = 2,
                    Name = "Fred",
                    Email = "fred@fil-rouge.com",
                    Password = PasswordService.EncryptPassword("2222")
                },
                new User()
                {
                    Id = 3,
                    Name = "Avril",
                    Email = "avril@fil-rouge.com",
                    Password = PasswordService.EncryptPassword("333")
                }
            };

            List<Project> projects = new List<Project>()
            {
                new Project()
                {
                    Id = 1,
                    Name = "Projet fil rouge",
                    Description = "Je suis un déscriptif du projet fil rouge"
                },
                new Project()
                {
                    Id = 2,
                    Name = "Un projet test",
                    Description = "La déscription du projet test"
                },
                new Project()
                {
                    Id = 3,
                    Name = "Le projet invisible",
                    Description = "Il ne devrait pas être visible car personne n'est assigné à celui-ci"
                }
            };

            List<ProjectUser> projectUsers = new List<ProjectUser>()
            {
                new ProjectUser()
                {
                    ProjectId = 1,
                    UserId = 1,
                    IsAdmin = true
                },
                new ProjectUser()
                {
                    ProjectId = 1,
                    UserId = 2,
                    IsAdmin = true
                },
                new ProjectUser()
                {
                    ProjectId = 1,
                    UserId = 3,
                    IsAdmin = false
                },
                new ProjectUser()
                {
                    ProjectId = 2,
                    UserId = 1,
                    IsAdmin = false
                },
                new ProjectUser()
                {
                    ProjectId = 2,
                    UserId = 2,
                    IsAdmin = false
                },
                new ProjectUser()
                {
                    ProjectId = 2,
                    UserId = 3,
                    IsAdmin = true
                }
            };

            List<Models.Task> tasks = new List<Models.Task>()
            {
                new Models.Task()
                {
                    Id = 1,
                    ProjectId = 1,
                    Name = "Faire du beau code",
                    Description = "C'est notre boulot"
                },
                new Models.Task()
                {
                    Id = 2,
                    ProjectId = 1,
                    Name = "Déprimer",
                    Description = "Ca on sait faire",
                    Status = Models.TaskStatus.Ongoing
                },
                new Models.Task()
                {
                    Id = 3,
                    ProjectId = 1,
                    Name = "Devenir alcoolique",
                    Description = "La solution à tous les problèmes",
                    Status = Models.TaskStatus.Completed
                },
                new Models.Task()
                {
                    Id = 4,
                    ProjectId = 2,
                    Name = "Faire le projet test",
                    Description = "On y croit"
                },
                new Models.Task()
                {
                    Id = 5,
                    ProjectId = 2,
                    Name = "Comprendre le projet test",
                    Description = "C'est compliqué"
                },
                new Models.Task()
                {
                    Id = 6,
                    ProjectId = 2,
                    Name = "Devenir le projet test",
                    Description = "Ne faire qu'un avec les bugs"
                },
                new Models.Task()
                {
                    Id = 7,
                    ProjectId = 3,
                    Name = "La tâche invisible",
                    Description = "Personne ne va te voir"
                }
            };

            List<Comment> comments = new List<Comment>()
            {
                new Comment() { 
                    Id = 1,
                    UserId = 1,
                    TaskId = 1,
                    Message = "Coucou"
                },
                new Comment() {
                    Id = 2,
                    UserId = 2,
                    TaskId = 1,
                    Message = "salut"
                },
                new Comment() {
                    Id = 3,
                    UserId = 1,
                    TaskId = 1,
                    Message = "Ca va ?"
                },
                new Comment() {
                    Id = 4,
                    UserId = 1,
                    TaskId = 3,
                    Message = "Invisible"
                },
            };

            modelBuilder.Entity<User>()
                .HasData(users);
            modelBuilder.Entity<Project>()
                .HasData(projects);
            modelBuilder.Entity<ProjectUser>()
                .HasData(projectUsers);
            modelBuilder.Entity<Models.Task>()
                .HasData(tasks);
            modelBuilder.Entity<Comment>()
                .HasData(comments);
        }
    }
}
