// File: Iskedular.Core.Services/ActivityLogService.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iskedular.Data;
using Iskedular.Models;
using Microsoft.EntityFrameworkCore;

namespace Iskedular.Core.Services
{
    public class ActivityLogService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public ActivityLogService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task LogActivityAsync(string activityMessage, string performedBy)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var log = new ActivityLog
                {
                    Message = activityMessage,
                    Timestamp = DateTime.UtcNow,
                    PerformedBy = performedBy
                };
                context.ActivityLogs.Add(log);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<ActivityLog>> GetRecentActivitiesAsync(int count = 10)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return await context.ActivityLogs
                                 .OrderByDescending(log => log.Timestamp)
                                 .Take(count)
                                 .ToListAsync();
            }
        }
    }
}