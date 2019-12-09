using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorForm.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorForm.Data
{
    public class BlazorFormContext : DbContext
    {
        public DbSet<ApplicationForm> ApplicationForms { get; set; }
    }
}
