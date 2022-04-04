using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dotnet5_demo
{
    public class Dotnet5Context : DbContext
    {
        public Dotnet5Context(DbContextOptions<Dotnet5Context> options) : base(options) { }
        
    }
}