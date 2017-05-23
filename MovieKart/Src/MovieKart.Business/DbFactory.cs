using MovieKart.Business;

namespace MovieKart.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HomeCinemaContext _dbContext;

        public HomeCinemaContext Init()
        {
            return _dbContext ?? (_dbContext = new HomeCinemaContext());
        }

        protected override void DisposeCore()
        {
            _dbContext?.Dispose();
        }
    }
}