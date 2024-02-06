﻿using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories;

public class RockeseatAuctionDbContext : DbContext {
    public DbSet<Auction> Auctions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlite("Data Source=C:\\VisualCode\\rocketseat\\NWL-Expert-CSharp\\db\\leilaoDbNLW.db");
    }
}