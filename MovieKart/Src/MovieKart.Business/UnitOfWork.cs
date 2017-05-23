using MovieKart.Business;

namespace MovieKart.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
    
        private HomeCinemaContext _homeCinemaContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public void Commit()
        {
            DbContext.Commit();
        }

        public HomeCinemaContext DbContext => _homeCinemaContext ?? (_homeCinemaContext = _dbFactory.Init());
    }
}