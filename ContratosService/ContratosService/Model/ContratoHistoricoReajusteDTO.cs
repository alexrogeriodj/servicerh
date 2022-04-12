using System;
using System.Text;
using System.Collections.Generic;


namespace ContratosService.Model {
    
    public class ContratoHistoricoReajusteDTO {
        public ContratoHistoricoReajusteDTO() { }
        public int? Id { get; set; }
        public int? IdContrato { get; set; }
        public System.Nullable<decimal> Indice { get; set; }
        public System.Nullable<decimal> ValorAnterior { get; set; }
        public System.Nullable<decimal> ValorAtual { get; set; }
        public System.Nullable<System.DateTime> DataReajuste { get; set; }
        public string Observacao { get; set; }
    }
}
