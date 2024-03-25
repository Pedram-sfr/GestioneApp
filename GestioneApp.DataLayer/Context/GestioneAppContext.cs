using GestioneApp.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneApp.DataLayer.Context
{
     public class GestioneAppContext:DbContext
    {
        public GestioneAppContext(DbContextOptions<GestioneAppContext> options):base(options)
        {


        }

        #region Tebla
        
        public DbSet<tb_LegislativeAudit> tb_LegislativeAudits { get; set; }
        #endregion
    }
}
