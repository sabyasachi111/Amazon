using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataContext
{
    public  class AmazonDbContext : DbContext
    {
        public AmazonDbContext(DbContextOptions<AmazonDbContext> options):base(options)
        {

        }

    }
}
