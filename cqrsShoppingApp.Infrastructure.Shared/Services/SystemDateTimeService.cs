using cqrsShoppingApp.Application.Interfaces.Shared;
using System;

namespace cqrsShoppingApp.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}