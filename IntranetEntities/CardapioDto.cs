using System;

namespace IntranetEntities
{
    public struct CardapioDto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public DateTime data { get; set; }
        public int usuarioId { get; set; }
    }
}