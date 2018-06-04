using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertis.BradescoClient.Models.Enumerators
{
    public enum TipoEmissaoPapeleta
    {
        /// <summary>
        ///  Caso a emissão seja feita pelo Banco, poderão incidir custos de emissão e envio. A responsabilidade pela validade do endereço de entrega é do lojista.
        /// </summary>
        BancoEmite = 1,
        /// <summary>
        /// Cliente se reponsabiliza em emitir o boleto e enviar ao cliente.
        /// </summary>
        ClienteEmite = 2
    }
}
