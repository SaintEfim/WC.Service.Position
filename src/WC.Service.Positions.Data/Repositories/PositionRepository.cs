﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WC.Library.Data.Repository;
using WC.Service.Positions.Data.Models;

namespace WC.Service.Positions.Data.Repositories;

public class PositionRepository<TDbContext> :
    RepositoryBase<PositionRepository<TDbContext>, TDbContext, PositionEntity>,
    IPositionRepository
    where TDbContext : DbContext
{
    protected PositionRepository(TDbContext context, ILogger<PositionRepository<TDbContext>> logger) : base(context,
        logger)
    {
    }
}