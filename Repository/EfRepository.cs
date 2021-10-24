namespace Repository
{
    public class EfRepository
    {
        protected readonly IEfContext Context;

        protected EfRepository(IEfContext context)
        {
            Context = context;
        }
    }
}