using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TwitterCloneApi.Models;

namespace TwitterCloneApi.Data
{
    public class TwitterCloneApiContext : DbContext
    {
        public TwitterCloneApiContext (DbContextOptions<TwitterCloneApiContext> options)
            : base(options)
        {
        }

        public DbSet<TwitterCloneApi.Models.User> User { get; set; }
    }
}
