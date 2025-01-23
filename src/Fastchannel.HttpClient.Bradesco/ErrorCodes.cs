using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastchannel.HttpClient.Bradesco
{
    public static class ErrorCodes
    {
        private static ConcurrentDictionary<int, string> _errorCodes;

        private static ConcurrentDictionary<int, string> Codes => GetErrorCodes();

        private static ConcurrentDictionary<int, string> GetErrorCodes()
        {
            if (_errorCodes != null)
                return _errorCodes;

            _errorCodes = new ConcurrentDictionary<int, string>();

            _errorCodes.TryAdd(0, "Operação realizada com sucesso");
            _errorCodes.TryAdd(-399, "Dados mínimos da requisição não informado (Verifique: merchantid, orderid, codigo do meio de pagamento e chave da loja)");
            _errorCodes.TryAdd(-395, "Formato do campo orderid invalido");
            _errorCodes.TryAdd(-400, "Código da loja não encontrado");
            _errorCodes.TryAdd(-398, "Loja informa um Merchant no corpo da mensagem e outro no header (Authorization)");
            _errorCodes.TryAdd(-518, "A chave informada no header não confere com a chave do meio de pagamento cadastrada na base");
            _errorCodes.TryAdd(-394, "O nosso número informado pertence a outro titulo");
            _errorCodes.TryAdd(-902, "Erro ao realizar a comunicação com a loja (url de confirmação do pedido)");
            _errorCodes.TryAdd(-401, "Código de compra já autorizado");
            _errorCodes.TryAdd(-411, "Loja não encontrada no sistema");
            _errorCodes.TryAdd(-999, "Compra já foi autorizada para este número de pedido");
            _errorCodes.TryAdd(-397, "A ordem de compra existe na orders (esta paga), porém não existe na tb_boletos");
            _errorCodes.TryAdd(-396, "Erro ao recuperar logotipo da loja");
            _errorCodes.TryAdd(-527, "Documento na blacklist CPF/CNPJ");
            _errorCodes.TryAdd(-513, "Erro - O valor da Tag VALOR não pode ser igual a zero ou Nulo");
            _errorCodes.TryAdd(-514, "Erro - A Tag CEDENTE do boleto não foi encontrada ou está malformada");
            _errorCodes.TryAdd(-516, "Erro - A Tag NUMEROAGENCIA do boleto não foi encontrada ou está malformada");
            _errorCodes.TryAdd(-5162, "Erro - O número da agência deve ter no máximo 4 dígitos.");
            _errorCodes.TryAdd(-517, "Erro - A Tag NUMEROCONTA do boleto não foi encontrada ou está malformada");
            _errorCodes.TryAdd(-5163, "Erro - O número da conta deve ter no máximo 7 dígitos.");
            _errorCodes.TryAdd(-5162, "Erro - O número da agência deve ter no máximo 4 dígitos");
            _errorCodes.TryAdd(-519, "Erro - A Tag DATAEMISSAO do Boleto não foi encontrada ou está malformada");
            _errorCodes.TryAdd(-520, "Erro - A Tag DATAPROCESSAMENTO do Boleto não foi encontrada ou está malformada");
            _errorCodes.TryAdd(-521, "Erro - A Tag DATAVENCIMENTO do Boleto não foi encontrada ou não foi encontrada");
            _errorCodes.TryAdd(-522, "Erro - A Tag NOMESACADO do Boleto não foi encontrada ou está malformada");
            _errorCodes.TryAdd(-523, "Erro - A Tag ENDERECOSACADO do Boleto não foi encontrada ou está malformada ");
            _errorCodes.TryAdd(-524, "Erro - A Tag CIDADESACADO do Boleto não foi encontrada ou está malformada");
            _errorCodes.TryAdd(-525, "Erro - A Tag UFSACADO do Boleto não foi encontrada ou está malformada");
            _errorCodes.TryAdd(-526, "Erro - A Tag CEPSACADO do Boleto não foi encontrada ou está malformada");
            _errorCodes.TryAdd(-527, "Erro - A Tag CPFSACADO do Boleto não foi encontrada ou está malformada");
            _errorCodes.TryAdd(-528, "Erro - A Tag NUMEROPEDIDO do Boleto não foi encontrada ou está malformada");
            _errorCodes.TryAdd(-529, "Erro - A Tag VALORDOCUMENTOFORMATADO não foi encontrada ou está malformada");
            _errorCodes.TryAdd(-530, "Erro - A Tag SHOPPINGID não foi encontrada ou está mal-formada");
            _errorCodes.TryAdd(-531, "Erro - A Tag NUMERODOCUMENTO do Boleto não foi encontrada ou está mal formatada");
            _errorCodes.TryAdd(-545, "Valor máximo deve ser R$1,00");
            _errorCodes.TryAdd(-546, "Carteira de cobrança invalida (Diferente de 25/26)");
            _errorCodes.TryAdd(-548, "Falha na comunicação");
            _errorCodes.TryAdd(93005117, "Registro não encontrado nas bases CDDA/CIP");
            _errorCodes.TryAdd(93005118, "Informações de entrada inconsistentes CDDA/CIP");
            _errorCodes.TryAdd(93005119, "Registro efetuado com sucesso - CIP CONFIRMADA");
            _errorCodes.TryAdd(93005120, "Carteira de cobrança não aceita");
            _errorCodes.TryAdd(930051, "REGISTRO EFETUADO COM SUCESSO");
            _errorCodes.TryAdd(930052, "PARAMETROS INVALIDOS");
            _errorCodes.TryAdd(930053, "REGISTRO EFETUADO COM SUCESSO");
            _errorCodes.TryAdd(930054, "TIPO DE PESQUISA INVALIDO");
            _errorCodes.TryAdd(930055, "CODIGO DE USUARIO INVALIDO");
            _errorCodes.TryAdd(930056, "CPF/CNPJ INVALIDO");
            _errorCodes.TryAdd(930057, "NOSSO NUMERO INVALIDO");
            _errorCodes.TryAdd(930058, "CODIGO DA PESSOA JURIDICA DO CONTRATO INVALIDO");
            _errorCodes.TryAdd(930059, "TIPO DO CONTRATO DE NEGOCIO INVALIDO");
            _errorCodes.TryAdd(9300510, "CODIGO DO PRODUTO DE SERVICO DA OPERACAO INVALIDO");
            _errorCodes.TryAdd(9300511, "NOSSO NUMERO INVALIDO");
            _errorCodes.TryAdd(9300512, "CODIGO DO BANCO INVALIDO");
            _errorCodes.TryAdd(9300513, "CODIGO DA AGENCIA CENTRALIZADORA INVALIDA");
            _errorCodes.TryAdd(9300514, "CPF OU CNPJ DO SACADO INVALIDO");
            _errorCodes.TryAdd(9300515, "CODIGO DO PRODUTO INVALIDO");
            _errorCodes.TryAdd(9300516, "NUMERO DE SEQUENCIA DO CONTRATO INVALIDO");
            _errorCodes.TryAdd(9300517, "DATA DE EMISSAO INVALIDA");
            _errorCodes.TryAdd(9300518, "TIPO DE VENCIMENTO INVALIDO");
            _errorCodes.TryAdd(9300519, "REGISTRO DE TITULO NAO PERMITIDO, DE ACORDO COM PARAMETRO NEGOCIADO PARA O CONTRATO");
            _errorCodes.TryAdd(9300520, "VALOR DO TITULO INVALIDO");
            _errorCodes.TryAdd(9300521, "ESPECIE DO TITULO INVALIDA");
            _errorCodes.TryAdd(9300522, "DATA LIMITE OBRIGATORIA PARA BONIFICACAO");
            _errorCodes.TryAdd(9300523, "A SOMATORIA DOS CAMPOS ABATIMENTO, DESCONTO E BONIFICACAO, EXCEDEU O VALOR DO TITULO");
            _errorCodes.TryAdd(9300524, "VALOR DO JUROS/MORA INFORMADO EXCEDEU O PARAMETRO");
            _errorCodes.TryAdd(9300525, "CONTRATO BLOQUEADO POR CLIENTE COM RESTRICOES E/OU IMPEDIMENTOS");
            _errorCodes.TryAdd(9300526, "E-MAIL INVALIDO");
            _errorCodes.TryAdd(9300527, "CODIGO DO CONTRATO INVALIDO");
            _errorCodes.TryAdd(9300528, "DATA DE VENCIMENTO INVALIDA");
            _errorCodes.TryAdd(9300529, "DEVERA SER INFORMADO ALGUM ARGUMENTO");
            _errorCodes.TryAdd(9300530, "INFORMAR APENAS PERCENTUAL OU VALOR DE JUROS");
            _errorCodes.TryAdd(9300531, "INFORMAR APENAS PERCENTUAL OU VALOR DE MULTA");
            _errorCodes.TryAdd(9300532, "DIAS PARA COBRANCA DE MULTA INVALIDO");
            _errorCodes.TryAdd(9300533, "SITUACAO OPERACIONAL DO CONTRATO NAO PERMITE O REGISTRO DO TITULO");
            _errorCodes.TryAdd(9300534, "INFORMAR APENAS PERCENTUAL OU VALOR DO DESCONTO");
            _errorCodes.TryAdd(9300535, "DATA LIMITE DE DESCONTO INVALIDA");
            _errorCodes.TryAdd(9300536, "INFORMAR APENAS PERCENTUAL OU VALOR DA BONIFICACAO");
            _errorCodes.TryAdd(9300537, "DATA LIMITE PARA BONIFICACAO INVALIDA");
            _errorCodes.TryAdd(9300538, "CODIGO DO TIPO DE BOLETO INVALIDO");
            _errorCodes.TryAdd(9300539, "UTILIZAR 3 DESCONTOS OU 2 DESCONTOS E BONIFICACAO");
            _errorCodes.TryAdd(9300540, "DESCONTO - DATA LIMITE 2 IGUAL OU MAIOR QUE DATA LIMITE 3");
            _errorCodes.TryAdd(9300541, "DESCONTO - DATA LIMITE 1 IGUAL OU MAIOR QUE DATA LIMITE 3");
            _errorCodes.TryAdd(9300542, "DESCONTO - DATA LIMITE 1 IGUAL OU MAIOR QUE DATA LIMITE 2");
            _errorCodes.TryAdd(9300543, "CPF/CNPJ OBRIGATORIO PARA DEBITO AUTOMATICO");
            _errorCodes.TryAdd(9300544, "CEP SACADO INVALIDO");
            _errorCodes.TryAdd(9300545, "CEP SACADOR AVALISTA INVALIDO");
            _errorCodes.TryAdd(9300546, "USUARIO NAO AUTORIZADO");
            _errorCodes.TryAdd(9300547, "DATA DESCONTO MENOR OU IGUAL DATA EMISSAO");
            _errorCodes.TryAdd(9300548, "VALOR DESCONTO MAIOR OU IGUAL VALOR TITULO");
            _errorCodes.TryAdd(9300549, "VALOR ABATIMENTO MAIOR OU IGUAL VALOR TITULO");
            _errorCodes.TryAdd(9300550, "CEP INVALIDO");
            _errorCodes.TryAdd(9300551, "DATA EMISSAO INVALIDA");
            _errorCodes.TryAdd(9300552, "DATA VENCIMENTO INVALIDA");
            _errorCodes.TryAdd(9300553, "VALOR IOF MAIOR OU IGUAL VALOR TITULO");
            _errorCodes.TryAdd(9300554, "PERCENTUAL INFORMADO MAIOR OU IGUAL 100,00");
            _errorCodes.TryAdd(9300555, "NUMERO CGC/CPF INVALIDO");
            _errorCodes.TryAdd(9300556, "NEGOCIACAO/CLIENTE BLOQUEADO OU PENDENTE");
            _errorCodes.TryAdd(9300557, "BANCO/AGENCIA DEPOSITARIA INVALIDO");
            _errorCodes.TryAdd(9300558, "ESPECIE DE DOCUMENTO INVALIDO");
            _errorCodes.TryAdd(9300559, "DIAS PARA INSTRUCAO DE PROTESTO INVALIDO");
            _errorCodes.TryAdd(9300560, "DIAS PARA DECURSO DE PRAZO INVALIDO");
            _errorCodes.TryAdd(9300561, "CODIGO PARA DESCONTO INVALIDO");
            _errorCodes.TryAdd(9300562, "CODIGO PARA MULTA INVALIDO");
            _errorCodes.TryAdd(9300563, "CODIGO DA COMISSAO DE PERMANENCIA INVALIDO");
            _errorCodes.TryAdd(9300564, "DATA EMISSAO MAIOR OU IGUAL DATA VENCIMENTO");
            _errorCodes.TryAdd(9300565, "DATA DESCONTO INVALIDA");
            _errorCodes.TryAdd(9300566, "PERCENTUAL MULTA INFORMADO MAIOR QUE O PERMITIDO");
            _errorCodes.TryAdd(9300567, "PERCENTUAL BONIFICACAO INFORMADO MAIOR QUE O PERMITIDO");
            _errorCodes.TryAdd(9300568, "VALOR IOF INCOMPATIVEL COM ID PROD");
            _errorCodes.TryAdd(9300569, "NAO PODE HAVER MAIS DE UMA BONIFICACAO");
            _errorCodes.TryAdd(9300570, "DIGITO INVALIDO");
            _errorCodes.TryAdd(9300571, "CLIENTE INEXISTENTE");
            _errorCodes.TryAdd(9300572, "PERCENTUAL COMISSAO PERMANENCIA INFORMADO MAIOR QUE O PERMITIDO");
            _errorCodes.TryAdd(9300573, "CNPJ/CPF INVALIDO");
            _errorCodes.TryAdd(9300574, "TITULO JA CADASTRADO");
            _errorCodes.TryAdd(9300575, "INFORME A DATA DE VENCIMENTO");
            _errorCodes.TryAdd(9300576, "DATA VENCIMENTO POSTERIOR A 10 ANOS");
            _errorCodes.TryAdd(9300577, "VALOR IOF OBRIGATORIO");
            _errorCodes.TryAdd(9300578, "INFORME TODOS OS CAMPOS P/ ABATIMENTO");
            _errorCodes.TryAdd(9300579, "TIPO INVALIDO");
            _errorCodes.TryAdd(9300580, "INFORME TODOS OS DADOS DO SACADOR AVALISTA");
            _errorCodes.TryAdd(9300581, "REGISTRO ON-LINE NAO PERMITIDO - BANCO-CLIENTE DIFERENTE DE 237");
            _errorCodes.TryAdd(9300582, "INFORME TODOS OS DADOS PARA DESCONTO/BONIFICACAO");
            _errorCodes.TryAdd(9300583, "VL ACUMULADO DESCONTO/BONIFICACAO MAIOR OU IGUAL VL TITULO");
            _errorCodes.TryAdd(9300584, "DATAS DE DESCONTO/BONIFICACAO FORA DE SEQUENCIA");
            _errorCodes.TryAdd(9300585, "INFORME TODOS OS CAMPOS PARA MULTA");
            _errorCodes.TryAdd(9300586, "INFORME TODOS OS CAMPOS PARA COMISSAO DE PERMANENCIA");
            _errorCodes.TryAdd(9300587, "ACESSO NAO AUTORIZADO A ESTA NEGOCIACAO");
            _errorCodes.TryAdd(9300588, "NEGOCIACAO BLOQUEADA");
            _errorCodes.TryAdd(9300589, "CODIGO DO BANCO DIFERENTE DE 237");
            _errorCodes.TryAdd(9300590, "VL ACUMULADO ABAT./DESC./BONIF. MAIOR OU IGUAL VL TITULO");
            _errorCodes.TryAdd(9300591, "NEGOCIACAO NAO PODE REGISTRAR TITULO");
            _errorCodes.TryAdd(9300592, "QUANTIDADE EXCESSIVA DE CASAS DECIMAIS");
            _errorCodes.TryAdd(9300593, "NOSSO NUMERO INFORMADO JA EXISTE NA BASE DE TITULO PENDENTE");
            _errorCodes.TryAdd(9300594, "VALOR DE IOF INVALIDO");
            _errorCodes.TryAdd(9300595, "DATA DE EMISSAO DEVE SER MENOR QUE A DATA DE VENCIMENTO");
            _errorCodes.TryAdd(9300596, "DATA DE EMISSAO DEVE SER MENOR OU IGUAL A DATA DE REGISTRO");
            _errorCodes.TryAdd(9300597, "NAO EXISTE PRACA COBRADORA PARA ESTE TITULO");
            _errorCodes.TryAdd(9300598, "TIPO DE BOLETO E-MAIL, INFORMAR O ENDERECO DE E-MAIL DO SACADO");
            _errorCodes.TryAdd(9300599, "TIPO DE BOLETO SMS, INFORMAR O DDD/CELULAR DO SACADO");
            _errorCodes.TryAdd(93005100, "DIAS DE JUROS INVALIDO");
            _errorCodes.TryAdd(93005101, "VALOR DA MULTA INFORMADO EXCEDEU O PARAMETRO");
            _errorCodes.TryAdd(93005102, "MULTA NAO PERMITIDA PARA BOLETO DE PROPOSTA");
            _errorCodes.TryAdd(93005103, "JUROS NAO PERMITIDO PARA BOLETO DE PROPOSTA");
            _errorCodes.TryAdd(93005104, "CADASTRO DE PROTESTO AUTOMATICO NAO PERMITIDO - BOLETO DE PROPOSTA");
            _errorCodes.TryAdd(93005105, "ESPECIE DO TITULO NAO PERMITIDA - BOLETO DE PROPOSTA NAO CONTRATADO");
            _errorCodes.TryAdd(93005106, "NAO E POSSIVEL REGISTRAR O TITULO");
            _errorCodes.TryAdd(93005107, "DIAS PARA NEGATIVACAO MENOR QUE O PERMITIDO EM CONTRATO");
            _errorCodes.TryAdd(93005108, "ESPECIE DE TITULO NAO PERMITE NEGATIVACAO");
            _errorCodes.TryAdd(93005109, "SOLICITACAO DE SERVICO DE NEGATIVACAO NAO NEGOCIADO");
            _errorCodes.TryAdd(93005110, "DIAS UTEIS PARA NEGATIVACAO NAO PERMITIDO - CONTRATO EM DIAS CORRIDOS");
            _errorCodes.TryAdd(93005111, "DIAS CORRIDOS PARA NEGATIVACAO NAO PERMITIDO - CONTRATO EM DIAS UTEIS");
            _errorCodes.TryAdd(93005112, "DADOS MINIMOS PARA REGISTRO NAO INFORMADOS");
            _errorCodes.TryAdd(93005113, "O CODIGO DA LOJA ENVIADO NA REQUISICAO NAO CONFERE");
            _errorCodes.TryAdd(93005114, "CODIGO DA LOJA NAO ENCONTRADO");
            _errorCodes.TryAdd(93005115, "CHAVE DE ACESSO NAO ENCONTRADA/INVALIDA");
            _errorCodes.TryAdd(93005116, "SISTEMA INDISPONIVEL NO MOMENTO");
            _errorCodes.TryAdd(93005117, "REGISTRO NAO ENCONTRADO NAS BASES CDDA/CIP");
            _errorCodes.TryAdd(93005118, "INFORMACOES DE ENTRADA INCONSISTENTES CDDA/CIP");
            _errorCodes.TryAdd(93005119, "REGISTRO EFETUADO COM SUCESSO - CIP CONFIRMADA");
            _errorCodes.TryAdd(93005120, "CARTEIRA DE COBRANCA NAO ACEITA");

            return _errorCodes;
        }

        public static string GetErrorMessage(int errorCode)
        {
            var messageNotFound = $"Código de Erro {errorCode} não mapeado, é possível que este código em específico não esteja especificado na documentação, favor validar";
            return Codes.TryGetValue(errorCode, out var errorMessage) ? errorMessage : messageNotFound;
        }
    }
}
