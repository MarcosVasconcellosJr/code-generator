using Api.DTO;
using Domain.Model;
using System;

namespace Api.Entities.DTO
{
    public class PrivatesDTO : PrivateBaseDTO<s>
    {   
           { get; set; }
           { get; set; }
        
        // TODO: Remove unecessary fields
        // TODO: Verify other entity Relations
        // Model this by each case

        public PrivatesDTO()
        {
        }

        public PrivatesDTO(s o) : base(o)
        {
            if (o == null) { return; }

            
             = o.;
             = o.;
        }

        public static PrivatesDTO ConvertModelToDTO(s o)
        {
            if (o == null) { return null; }
            return new PrivatesDTO(o);
        }

        public static s ConvertDTOToModel(PrivatesDTO o)
        {
            if (o == null) { return null; }

            s s = new s()
            {
                
                 = o.,
                 = o.,
            };

            s = o.InitializeInstance(s);

            return s;
        }
    }
}
