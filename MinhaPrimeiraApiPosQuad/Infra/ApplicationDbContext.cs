using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraApiPosQuad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraApiPosQuad.Infra
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AnimalModels> Animal { get; set; }
    }
}
