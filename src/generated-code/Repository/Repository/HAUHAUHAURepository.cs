using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Repository
{
    public class HAUHAUHAURepository : BaseEntityRepository<Domain.Entities.HAUHAUHAU, Domain.Model.HAUHAUHAU>, IHAUHAUHAURepository
    {
        public HAUHAUHAURepository(RepositoryContext context) : base(context, context.HAUHAUHAU)
        {
            Entity.Include(e => e.CMNCategoryNewList).ThenInclude(x => x.CMNCategory).ToList();
        }

        public override Domain.Model.HAUHAUHAU ToModel(Domain.Entities.HAUHAUHAU entity)
        {
            return entity;
        }

        public override Domain.Entities.HAUHAUHAU ToEntity(Domain.Model.HAUHAUHAU model)
        {
            return model;
        }
    }
}
