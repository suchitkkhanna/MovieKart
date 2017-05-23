using System;
using MovieKart.Business;

namespace MovieKart.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        HomeCinemaContext Init();
    }
}