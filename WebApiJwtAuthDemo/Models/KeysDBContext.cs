using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApiJwtAuthDemo.Models
{
    public partial class KeysDBContext : DbContext
    {
        public virtual DbSet<TblKeys> TblKeys { get; set; }
        public virtual DbSet<TblUser> TblUser { get; set; }

        public KeysDBContext(DbContextOptions<KeysDBContext> options)
    : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblKeys>(entity =>
            {
                entity.HasKey(e => e.KeyId)
                    .HasName("PK__tbl_Keys__21F5BE476ABBA85D");

                entity.ToTable("tbl_Keys");

                entity.Property(e => e.KeyName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.KeyValue)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tbl_User__1788CC4C3DA2369F");

                entity.ToTable("tbl_User");

                entity.Property(e => e.Password).HasColumnType("nchar(10)");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserSalt)
                    .IsRequired()
                    .HasColumnType("char(10)");
            });
        }
    }
}