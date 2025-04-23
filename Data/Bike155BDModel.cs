using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bike155.Models;

    public class Bike155BDModel : DbContext
    {
        public Bike155BDModel (DbContextOptions<Bike155BDModel> options)
            : base(options)
        {
        }

        public DbSet<Bike155.Models.Usuario> Usuario { get; set; } = default!;

public DbSet<Bike155.Models.Bike> Bike { get; set; } = default!;

public DbSet<Bike155.Models.Ruta> Ruta { get; set; } = default!;
    }
