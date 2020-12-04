using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Repositories.Data
{
    public class ShlidexperienceContext : DbContext
    {
        public ShlidexperienceContext(DbContextOptions<ShlidexperienceContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }

        public DbSet<CycleEntity> Cycles { get; set; }

        public DbSet<CycleEmployeeEntity> CycleEmployees { get; set; }

        public DbSet<CycleReviewerEntity> CycleReviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasQueryFilter(e => !e.IsDeleted);

            modelBuilder
                .Entity<UserEntity>()
                .Property(e => e.UserId)
                .ValueGeneratedNever();
            modelBuilder
                .Entity<CycleEntity>()
                .Property(e => e.Id)
                .ValueGeneratedNever();
            modelBuilder
                .Entity<CycleEmployeeEntity>()
                .Property(e => e.Id)
                .ValueGeneratedNever();
            modelBuilder
                .Entity<CycleReviewerEntity>()
                .Property(e => e.Id)
                .ValueGeneratedNever();
            modelBuilder
                .Entity<CycleReviewerEntity>()
                .HasOne(e => e.User)
                .WithMany(e => e.CycleReviewers)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder
                .Entity<CycleEmployeeEntity>()
                .HasOne(e => e.User)
                .WithMany(e => e.CycleEmployees)
                .OnDelete(DeleteBehavior.Restrict);

            var users = new List<UserEntity>();
            var cycles = new List<CycleEntity>();

            for (int i = 0; i < 10; ++i)
            {
                users.Add(new UserEntity(Guid.NewGuid(), $"{i}@gmail.com", i % 2 == 0));
                cycles.Add(new CycleEntity(Guid.NewGuid(), $"name-{i}"));
            }

            modelBuilder.Entity<UserEntity>().HasData(users);
            modelBuilder.Entity<CycleEntity>().HasData(cycles);

            var employees = new List<CycleEmployeeEntity>()
            {
                new CycleEmployeeEntity(Guid.NewGuid(), users[0].UserId, cycles[0].Id),
                new CycleEmployeeEntity(Guid.NewGuid(), users[1].UserId, cycles[0].Id),
                new CycleEmployeeEntity(Guid.NewGuid(), users[2].UserId, cycles[0].Id),
                new CycleEmployeeEntity(Guid.NewGuid(), users[3].UserId, cycles[0].Id),
                new CycleEmployeeEntity(Guid.NewGuid(), users[4].UserId, cycles[0].Id),
                new CycleEmployeeEntity(Guid.NewGuid(), users[6].UserId, cycles[1].Id),
                new CycleEmployeeEntity(Guid.NewGuid(), users[7].UserId, cycles[1].Id),
                new CycleEmployeeEntity(Guid.NewGuid(), users[1].UserId, cycles[1].Id),
                new CycleEmployeeEntity(Guid.NewGuid(), users[2].UserId, cycles[2].Id),
                new CycleEmployeeEntity(Guid.NewGuid(), users[6].UserId, cycles[2].Id),
                new CycleEmployeeEntity(Guid.NewGuid(), users[4].UserId, cycles[2].Id),
            };

            modelBuilder.Entity<CycleEmployeeEntity>().HasData(employees);

            modelBuilder.Entity<CycleReviewerEntity>().HasData(new CycleReviewerEntity(Guid.NewGuid(), employees[0].Id, users[0].UserId));
        }
    }
}
