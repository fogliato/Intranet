using System;

namespace IntranetEntities
{
    public struct AcessosDto
    {
        public int id { get; set; }
        
        public bool cardapio { get; set; }
        public bool ramais { get; set; }
        public int usuarioId { get; set; }

    }
}
