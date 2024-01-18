using Microsoft.EntityFrameworkCore;
using NexaCoreERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexaCoreERP.Application.Common;

public interface IApplicationDbContext
{
    DbSet<Product> Products { get; set; }
    DbSet<Order> Orders { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken=default);
}
