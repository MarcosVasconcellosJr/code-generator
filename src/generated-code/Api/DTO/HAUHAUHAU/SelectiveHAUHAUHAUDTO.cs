using Api.DTO;
using Domain.Model;
using System;

namespace Api.Entities.DTO
{
    public class SelectiveHAUHAUHAUDTO : SelectiveBaseDTO<HAUHAUHAU>
    {   
           { get; set; }
        // TODO: Remove unecessary fields
        // TODO: Verify other entity Relations
        // Model this by each case

        public SelectiveHAUHAUHAUDTO()
        {
        }

        public SelectiveHAUHAUHAUDTO(HAUHAUHAU o) : base(o)
        {
            if (o == null) { return; }

            
             = o.;
        }

        public static SelectiveHAUHAUHAUDTO ConvertModelToDTO(HAUHAUHAU o)
        {
            if (o == null) { return null; }
            return new SelectiveHAUHAUHAUDTO(o);
        }

        public static HAUHAUHAU ConvertDTOToModel(SelectiveHAUHAUHAUDTO o)
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
