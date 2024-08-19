using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrdemProducao
    {
        public Guid Id { get; set; }
        public Pedido Pedido { get; set; }
        public StatusProducao StatusProducao { get; set; }
        public RelacaoProducao RelacaoProducao { get;set;}
    }
}
