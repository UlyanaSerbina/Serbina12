using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Serbina12.EF
{
    public partial class ModelEF : DbContext
    {
        public ModelEF()
            : base("name=ModelEF")
        {
        }

        public virtual DbSet<UsersHash> UsersHash { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
