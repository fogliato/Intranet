using System;

namespace IntranetEntities
{
    public struct RamalDto
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public int numero { get; set; }
        public string celular { get; set; }
        public int usuarioId { get; set; }
        public string Departamento { get; set; }
    }
}
