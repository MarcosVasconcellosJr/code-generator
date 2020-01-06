using Domain.Entities;
using Domain.Mechanism;
using Domain.Repository;
using Domain.SearchParameter;
using Enumerator;
using Exception;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using Util;
 
namespace Domain.Services
{
    public class TerminalService : ITerminalService
    {
        public TerminalService(ITerminalRepository repository) : base(repository)
        {
            
        }

        public override IList<Model.Terminal> GetBySearchParameter(TerminalSearchParameter searchParameter, out Int32 count)
        {
            IList<Model.Terminal> returnList = null;
            Boolean isOrdered = true;

            IQueryable<Terminal> query = Repository.GetByExpression(x => 
                
                 
                 
                && 
                
                 
                 
                 
            );

            #region ORDERBY

            switch (searchParameter.OrderBy.ToUpper())
            {

                case &#34;&amp;{attr.attrName.toUpperCase()}:
                    query = searchParameter.IsDesc ? query.OrderByDescending(x => x.) : query.OrderBy(x => x.);
                    break;

                case &#34;&amp;{attr.attrName.toUpperCase()}:
                    query = searchParameter.IsDesc ? query.OrderByDescending(x => x.) : query.OrderBy(x => x.);
                    break;

                default: isOrdered = false;
                    break;
            }

            #endregion

            returnList = Pagination(query, searchParameter, out count, isOrdered);

            return returnList;
        }
        
        public override Terminal Create(Terminal terminal)
        {
            if (IsValid(terminal))
            {
                String guid = this.Repository.Insert(terminal);
                terminal = this.Repository.Get(guid);
            }

            return terminal;
        }

        public override Terminal Update(Terminal terminal)
        {
            if (IsValid(terminal))
            {
                Terminal savedTerminal = this.Repository.Get(terminal.Id);

                if (savedTerminal == null) { throw new BusinessException(BusinessErrorMessage.TERMINAL_NOT_FOUND); }

                String guid = this.Repository.Update(terminal);
                terminal = this.Repository.Get(guid);
            }

            return terminal;
        }

        #region Private Methods
        private Boolean IsValid(Terminal terminal)
        {   
             
            
             
            
            return true;
        }
        
        #endregion

        #region BASE_METHODS

        public override Entities.Terminal ToEntity(Model.Terminal model)
        {
            return model;
        }

        public override Model.Terminal ToModel(Entities.Terminal entity)
        {
            return entity;
        }

        #endregion
    }
}