﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Memberships.Entities;
using System;

namespace Memberships.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public bool IsActive { get; set; }
        public DateTime Registered { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Observe que o authenticationType deve corresponder àquele definido em CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Adicionar declarações de usuário personalizado aqui
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Section>             Sections             { get; set; }
        public DbSet<Part>                Parts                { get; set; }
        public DbSet<ItemType>            ItemTypes            { get; set; }
        public DbSet<Item>                Items                { get; set; }
        public DbSet<Product>             Products             { get; set; }
        public DbSet<ProductType>         ProductTypes         { get; set; }
        public DbSet<ProductLinkText>     ProductLinkTexts     { get; set; }
        public DbSet<Subscription>        Subscriptions        { get; set; }
        public DbSet<ProductItem>         ProductItem          { get; set; }
        public DbSet<SubscriptionProduct> SubscriptionProducts { get; set; }
        public DbSet<UserSubscription>    UserSubscriptions    { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}