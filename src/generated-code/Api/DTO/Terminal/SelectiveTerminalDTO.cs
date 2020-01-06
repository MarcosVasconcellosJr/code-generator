using Api.DTO;
using Domain.Model;
using System;

namespace Api.Entities.DTO
{
    public class SelectiveTerminalDTO : SelectiveBaseDTO<Terminal>
    {   
           { get; set; }
           { get; set; }
        // TODO: Remove unecessary fields
        // TODO: Verify other entity Relations
        // Model this by each case

        public SelectiveTerminalDTO()
        {
        }

        public SelectiveTerminalDTO(Terminal o) : base(o)
        {
            if (o == null) { return; }

            
             = o.;
             = o.;
        }

        public static SelectiveTerminalDTO ConvertModelToDTO(Terminal o)
        {
            if (o == null) { return null; }
            return new SelectiveTerminalDTO(o);
        }

        public static Terminal ConvertDTOToModel(SelectiveTerminalDTO o)
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
