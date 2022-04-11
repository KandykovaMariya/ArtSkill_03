#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArtSkill_03.Models;

namespace ArtSkill_03.Data
{
    public class ArtSkill_03Context : DbContext
    {
        public ArtSkill_03Context (DbContextOptions<ArtSkill_03Context> options)
            : base(options)
        {
        }

        public DbSet<ArtSkill_03.Models.IllustrationModel> IllustrationModel { get; set; }
    }
}
