using Api.DTO;
using Domain.Model;
using System;

namespace Api.Entities.DTO
{
    public class PrivateTerminalDTO : PrivateBaseDTO<Terminal>
    {   
           { get; set; }
           { get; set; }
        
        // TODO: Remove unecessary fields
        // TODO: Verify other entity Relations
        // Model this by each case

        public PrivateTerminalDTO()
        {
        }

        public PrivateTerminalDTO(Terminal o) : base(o)
        {
            if (o == null) { return; }

            
             = o.;
             = o.;
        }

        public static PrivateTerminalDTO ConvertModelToDTO(Terminal o)
        {
            if (o == null) { return null; }
            return new PrivateTerminalDTO(o);
        }

        public static Terminal ConvertDTOToModel(PrivateTerminalDTO o)
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
