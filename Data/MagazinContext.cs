﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Magazin.Models;

namespace Magazin.Data
{
    public class MagazinContext : DbContext
    {
        public MagazinContext (DbContextOptions<MagazinContext> options)
            : base(options)
        {
        }

        public DbSet<Magazin.Models.Produs> Produs { get; set; }

        public DbSet<Magazin.Models.Clienti> Clienti { get; set; }
    }
}
