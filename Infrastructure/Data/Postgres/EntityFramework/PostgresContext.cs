﻿using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data.Postgres.EntityFramework;

public class PostgresContext : DbContext
{
    private readonly IConfiguration _configuration;

    public PostgresContext(DbContextOptions<PostgresContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new CarsConfiguration());
        modelBuilder.ApplyConfiguration(new UserTokenConfiguration());
        modelBuilder.ApplyConfiguration(new CommentConfiguration());
        modelBuilder.ApplyConfiguration(new ContactConfiguration());
        modelBuilder.ApplyConfiguration(new ReservationConfiguration());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        if (_configuration["EnvironmentAlias"] == "DEV")
        {
            optionsBuilder.LogTo(Console.Write);
        }
    }

    public DbSet<User> User => Set<User>();
    public DbSet<Cars> Cars => Set<Cars>();
    public DbSet<Comment> Comment => Set<Comment>();
    public DbSet<Contact> Contact => Set<Contact>();
    public DbSet<Reservations> Reservations => Set<Reservations>();
    public DbSet<UserToken> UserTokens => Set<UserToken>();
}