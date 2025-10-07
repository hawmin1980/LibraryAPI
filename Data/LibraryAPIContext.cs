using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryAPI.Models.Entities;

namespace LibraryAPI.Data
{
    public class LibraryAPIContext : DbContext
    {
        public LibraryAPIContext (DbContextOptions<LibraryAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = default!;
        public DbSet<Employee> Employees { get; set; } = default!;
        public DbSet<Magazine> Magazines { get; set; } = default!;
        public DbSet<AudioBook> AudioBooks { get; set; } = default!;
        public DbSet<Member> Members { get; set; } = default!;
        public DbSet<Country> Countries { get; set; } = default!;
        public DbSet<MediaType> MediaTypes { get; set; } = default!;
        public DbSet<BorrowStatus> BorrowStatuses { get; set; } = default!;
        public DbSet<BorrowRecord> BorrowRecords { get; set; } = default!;
        public DbSet<EmployeeRole> EmployeeRoles { get; set; } = default!;
        public DbSet<Genre> Genres { get; set; } = default!;
        public DbSet<IdType> IdTypes { get; set; } = default!;
        public DbSet<Language> Languages { get; set; } = default!;
        public DbSet<Occupation> Occupations { get; set; } = default!;
        public DbSet<Salutation> Salutations { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Example: Explicit table mapping
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Magazine>().ToTable("Magazine");
            modelBuilder.Entity<AudioBook>().ToTable("AudioBook");
            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<EmployeeRole>().ToTable("EmployeeRole");
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<IdType>().ToTable("IdType");
            modelBuilder.Entity<Language>().ToTable("Language");
            modelBuilder.Entity<Occupation>().ToTable("Occupation");
            modelBuilder.Entity<Salutation>().ToTable("Salutation");
            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<MediaType>().ToTable("MediaType");
            modelBuilder.Entity<BorrowStatus>().ToTable("BorrowStatus");
            modelBuilder.Entity<BorrowRecord>().ToTable("BorrowRecord");

            // Example: Configure primary key
            modelBuilder.Entity<Book>().HasKey(b => b.Id);

            // You can add more configurations here as needed
        }
        public DbSet<LibraryAPI.Models.Entities.Country> Country { get; set; } = default!;
        public DbSet<LibraryAPI.Models.Entities.MediaType> MediaType { get; set; } = default!;
        public DbSet<LibraryAPI.Models.Entities.BorrowStatus> BorrowStatus { get; set; } = default!;
        public DbSet<LibraryAPI.Models.Entities.BorrowRecord> BorrowRecord { get; set; } = default!;
        public DbSet<LibraryAPI.Models.Entities.EmployeeRole> EmployeeRole { get; set; } = default!;
        public DbSet<LibraryAPI.Models.Entities.Genre> Genre { get; set; } = default!;
        public DbSet<LibraryAPI.Models.Entities.IdType> IdType { get; set; } = default!;
        public DbSet<LibraryAPI.Models.Entities.Language> Language { get; set; } = default!;
    }
}
