using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using planetnineserver.Models;

namespace planetnineserver.Data
{
    public class planetnineservercontext : DbContext
    {
        public planetnineservercontext (DbContextOptions<planetnineservercontext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!;

        public DbSet<Comment> Comment { get; set; } = default!;

        public DbSet<planetnineserver.Models.Favorite> Favorite { get; set; } = default!;

        public DbSet<planetnineserver.Models.Follower> Follower { get; set; } = default!;

        public DbSet<planetnineserver.Models.Message> Message { get; set; } = default!;

        public DbSet<planetnineserver.Models.MessageComment> MessageComment { get; set; } = default!;

        public DbSet<planetnineserver.Models.Moon> Moon { get; set; } = default!;

        public DbSet<planetnineserver.Models.Planet> Planet { get; set; } = default!;

        public DbSet<planetnineserver.Models.Post> Post { get; set; } = default!;
    }
}
