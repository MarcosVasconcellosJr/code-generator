using Api.DTO;
using Domain.Model;
using System;

namespace Api.Entities.DTO
{
    public class PublicsDTO : PublicBaseDTO<s>
    {   
           { get; set; }
           { get; set; }
        
        // TODO: Remove unecessary fields
        // TODO: Verify other entity Relations
        // Model this by each case

        public PublicsDTO()
        {
        }

        public PublicsDTO(s o) : base(o)
        {
            if (o == null) { return; }

            
             = o.;
             = o.;
        }

        public static PublicsDTO ConvertModelToDTO(s o)
        {
            if (o == null) { return null; }
            return new PublicsDTO(o);
        }

        public static s ConvertDTOToModel(PublicsDTO o)
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
