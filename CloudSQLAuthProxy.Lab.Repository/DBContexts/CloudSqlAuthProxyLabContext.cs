using System;
using System.Collections.Generic;
using CloudSQLAuthProxy.Lab.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudSQLAuthProxy.Lab.Repository.DBContexts;

public partial class CloudSqlAuthProxyLabContext : DbContext
{
    public CloudSqlAuthProxyLabContext(DbContextOptions<CloudSqlAuthProxyLabContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("users", "users");

            entity.HasIndex(e => e.UserId, "newtable_user_id_idx").IsUnique();

            entity.Property(e => e.CreateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Nickname)
                .HasColumnType("character varying")
                .HasColumnName("nickname");
            entity.Property(e => e.Password)
                .HasColumnType("character varying")
                .HasColumnName("password");
            entity.Property(e => e.Sex).HasColumnName("sex");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("update_date");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("nextval('users.newtable_user_id_seq'::regclass)")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasColumnType("character varying")
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
