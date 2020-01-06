using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Repository
{
    public class TerminalRepository : BaseEntityRepository<Domain.Entities.Terminal, Domain.Model.Terminal>, ITerminalRepository
    {
        public TerminalRepository(RepositoryContext context) : base(context, context.Terminal)
        {
            Entity.Include(e => e.CMNCategoryNewList).ThenInclude(x => x.CMNCategory).ToList();
        }

        public override Domain.Model.Terminal ToModel(Domain.Entities.Terminal entity)
        {
            return entity;
        }

        public override Domain.Entities.Terminal ToEntity(Domain.Model.Terminal model)
        {
            return model;
        }
    }
}
