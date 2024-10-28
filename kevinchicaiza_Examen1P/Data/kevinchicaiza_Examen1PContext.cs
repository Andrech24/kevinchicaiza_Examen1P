using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using kevinchicaiza_Examen1P.Models;

namespace kevinchicaiza_Examen1P.Data
{
    public class kevinchicaiza_Examen1PContext : DbContext
    {
        public kevinchicaiza_Examen1PContext (DbContextOptions<kevinchicaiza_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<kevinchicaiza_Examen1P.Models.KcGymshark> KcGymshark { get; set; } = default!;
    }
}
