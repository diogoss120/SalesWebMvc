using System;

namespace SalesWebMvc.Models.Emuns
{
    public enum SaleStatus : int
    {
        Pending = 0,
        Billed = 1,
        Canceled = 2
    }
}
