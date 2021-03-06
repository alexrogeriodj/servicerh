using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OrcamentoService.Model
{
    [DataContract(IsReference = true)]
    public class ContaCaixaDTO
    {
        [DataMember]
        public int? id { get; set; }
        [DataMember]
        public int? idEmpresa { get; set; }
        [DataMember]
        public int? idAgenciaBanco { get; set; }
        [DataMember]
        public string codigo { get; set; }
        [DataMember]
        public string nome { get; set; }
        [DataMember]
        public string descricao { get; set; }
        [DataMember]
        public char? tipo { get; set; }
    }
}