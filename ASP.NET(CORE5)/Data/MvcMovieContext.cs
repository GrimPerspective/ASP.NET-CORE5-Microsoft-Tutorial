using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NET_CORE5_.Models;

namespace ASP.NET_CORE5_.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options) : base(options) { }
        public DbSet<ASP.NET_CORE5_.Models.Movie> Movie { get; set; }
    }

}
