using Api.DTO;
using Domain.Model;
using System;

namespace Api.Entities.DTO
{
    public class PublicTerminalDTO : PublicBaseDTO<Terminal>
    {   
           { get; set; }
           { get; set; }
        
        // TODO: Remove unecessary fields
        // TODO: Verify other entity Relations
        // Model this by each case

        public PublicTerminalDTO()
        {
        }

        public PublicTerminalDTO(Terminal o) : base(o)
        {
            if (o == null) { return; }

            
             = o.;
             = o.;
        }

        public static PublicTerminalDTO ConvertModelToDTO(Terminal o)
        {
            if (o == null) { return null; }
            return new PublicTerminalDTO(o);
        }

        public static Terminal ConvertDTOToModel(PublicTerminalDTO o)
        {
            if (o == null) { return null; }

            Terminal Terminal = new Terminal()
            {
                
                 = o.,
                 = o.,
            };

            Terminal = o.InitializeInstance(Terminal);

            return Terminal;
        }
    }
}
