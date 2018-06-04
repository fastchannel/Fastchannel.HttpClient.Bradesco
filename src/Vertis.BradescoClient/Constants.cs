using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertis.BradescoClient
{
    public static class Constants
    {
        internal const string DATE_FORMAT = "yyyy-MM-dd";
        internal const string PERCENTUAL_FORMAT_NNNDDDDD = "000.00000";
        internal const int DEFAULT_ERROR_CODE = -999999;

        internal const string INVALID_OPERATION_CONTEXT = "Não é possível realizar a validação do retorno da chamada para o Bradesco porque o contexto de execução do pagamento é nulo";
        internal const string UNAUTHORIZED_OPERATION = "Processamento não autorizado, verifique nas configurações do meio de pagamento se os dados de acesso estão corretos";
        internal const string INVALID_RESPONSE = "Retorno inesperado do serviço do bradesco";
        internal const string SUCCESSFULLY_OPERATION = "Executado com sucesso";
        internal static string UNSUPPORTED_MEDIA_TYPE = "Tipo de mídia não suportado, é esperado (application/json) ou (application/xml)";
        internal static string INVALID_REQUEST = "Requisição inválida";
        internal static string SERVICE_UNAVAILABLE = "Serviço indisponível, favor contatar o suporte da Scopus";
    }
}
