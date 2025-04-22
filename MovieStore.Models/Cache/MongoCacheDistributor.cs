using Microsoft.Extensions.
namespace MovieStore.Models.Cache
{
    public class MongoCacheDistributor : backgr
    {

        // Full load method - read entire collection- GetAllMovies()
        // DiffLoad - read only new or updated records() - GetUpdatedMovies(Datetime Lastused)
        protected override Task ExecuteAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
