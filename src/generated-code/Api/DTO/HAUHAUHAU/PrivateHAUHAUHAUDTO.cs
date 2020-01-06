using Api.DTO;
using Domain.Model;
using System;

namespace Api.Entities.DTO
{
    public class PrivateHAUHAUHAUDTO : PrivateBaseDTO<HAUHAUHAU>
    {   
           { get; set; }
        
        // TODO: Remove unecessary fields
        // TODO: Verify other entity Relations
        // Model this by each case

        public PrivateHAUHAUHAUDTO()
        {
        }

        public PrivateHAUHAUHAUDTO(HAUHAUHAU o) : base(o)
        {
            if (o == null) { return; }

            
             = o.;
        }

        public static PrivateHAUHAUHAUDTO ConvertModelToDTO(HAUHAUHAU o)
        {
            if (o == null) { return null; }
            return new PrivateHAUHAUHAUDTO(o);
        }

        public static HAUHAUHAU ConvertDTOToModel(PrivateHAUHAUHAUDTO o)
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
