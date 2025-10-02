using System;
namespace ManteHos.Entities
{
    public enum Status : int
    {
        Created,
        Accepted,
        Rejected,
        InProgress,
        Pending,
        Completed,
    }
}