using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Model
{
    public class Terminal : BaseModel
    {   
           { get; set; }
           { get; set; }
        
        public Terminal() : base()
        {

        }

        public Terminal(String id) : base(id)
        {
            
        }

        public Terminal(Entities.Terminal entity, Boolean includeDeleted = false) : base(entity)
        {
            if (entity != null)
            {
                 
                 = entity.; 
                 = entity.;
            }
        }

        public static implicit operator Terminal(Entities.Terminal entity)
        {
            if (entity == null)
            {
                return null;
            }

            Terminal result = new Terminal(entity);
            return result;
        }

        public static implicit operator Entities.Terminal(Terminal model)
        {
            if (model == null)
            { return null; }

            return new Entities.Terminal()
            {
                Id = model.Id,

                
                 = model.,
                 = model.,
            };
        }

        public static Terminal WithoutEFRelations(Entities.Terminal entity)
        {
            if (entity == null)
            { return null; }

            Terminal model = new Terminal()
            {
                
                 = entity.,
                 = entity.,
            };

            model.InitializeInstance(entity);

            return model;
        }
    }
}