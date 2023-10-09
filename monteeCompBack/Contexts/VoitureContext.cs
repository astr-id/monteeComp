using Microsoft.EntityFrameworkCore;
using System;
using monteeCompBack.Models;

namespace monteeCompBack.Contexts
{

    public class VoitureContext : DbContext
    {
        public VoitureContext(DbContextOptions<VoitureContext> options)
            : base(options)
        {
        }

        public DbSet<Voiture> Voiture { get; set; } = null!;

        public static implicit operator Predicate<object>(VoitureContext v)
        {
            throw new NotImplementedException();
        }
    }



}
