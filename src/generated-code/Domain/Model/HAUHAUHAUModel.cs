using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Model
{
    public class HAUHAUHAU : BaseModel
    {   
           { get; set; }
        
        public HAUHAUHAU() : base()
        {

        }

        public HAUHAUHAU(String id) : base(id)
        {
            
        }

        public HAUHAUHAU(Entities.HAUHAUHAU entity, Boolean includeDeleted = false) : base(entity)
        {
            if (entity != null)
            {
                 
                 = entity.;
            }
        }

        public static implicit operator HAUHAUHAU(Entities.HAUHAUHAU entity)
        {
            if (entity == null)
            {
                return null;
            }

            HAUHAUHAU result = new HAUHAUHAU(entity);
            return result;
        }

        public static implicit operator Entities.HAUHAUHAU(HAUHAUHAU model)
        {
            if (model == null)
            { return null; }

            return new Entities.HAUHAUHAU()
            {
                Id = model.Id,

                
                 = model.,
            };
        }

        public static HAUHAUHAU WithoutEFRelations(Entities.HAUHAUHAU entity)
        {
            if (entity == null)
            { return null; }

            HAUHAUHAU model = new HAUHAUHAU()
            {
                
                 = entity.,
            };

            model.InitializeInstance(entity);

            return model;
        }
    }
}