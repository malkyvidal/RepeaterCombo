using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepeterWithCombo.Models
{
    public class PostulacionPlaza
    {
        public int IdPlaza { get; set; }
        public int IdConvocatoria { get; set; }
        public int IdUni { get; set; }
        public string NombrePrograna { get; set; }
        public string NombreUni { get; set; }
        public int IdPrograma { get; set; }
    }
}