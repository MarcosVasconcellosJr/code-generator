using Api.DTO;
using Domain.Model;
using System;

namespace Api.Entities.DTO
{
    public class PublicHAUHAUHAUDTO : PublicBaseDTO<HAUHAUHAU>
    {   
           { get; set; }
        
        // TODO: Remove unecessary fields
        // TODO: Verify other entity Relations
        // Model this by each case

        public PublicHAUHAUHAUDTO()
        {
        }

        public PublicHAUHAUHAUDTO(HAUHAUHAU o) : base(o)
        {
            if (o == null) { return; }

            
             = o.;
        }

        public static PublicHAUHAUHAUDTO ConvertModelToDTO(HAUHAUHAU o)
        {
            if (o == null) { return null; }
            return new PublicHAUHAUHAUDTO(o);
        }

        public static HAUHAUHAU ConvertDTOToModel(PublicHAUHAUHAUDTO o)
        {
            if (o == null) { return null; }

            HAUHAUHAU HAUHAUHAU = new HAUHAUHAU()
            {
                
                 = o.,
            };

            HAUHAUHAU = o.InitializeInstance(HAUHAUHAU);

            return HAUHAUHAU;
        }
    }
}
