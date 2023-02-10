using System;
using System.IO;
using System.Text;
using static ETQResources.EnumeradoresETQ;

namespace ETQResources
{
    class Etiqueta_Template
    {
        #region  Atributos

        private string diretorio = "C:\\";      // Diretório onde estão os modelos de etiqueta
        private string arquivo;     // Nome do arquivo que contém o modelo de etiqueta
        private char delimitador = '%';     // Caracteres que delimitam as tags do template
        private E_TIPO_IMPRESSORA tipoImpressora = E_TIPO_IMPRESSORA.Zebra;     // Tipo de impressora
        private StringBuilder codigoEtiqueta;   // Código da etiqueta
        private StringBuilder codigoArquivo;    // Armazena o código lido do arquivo. Não pode ser alterado
        private StreamReader input; // Stream de leitura do arquivo
        private int numCopias = 1;  // Numero de copias da etiqueta.

        #endregion

        #region Properties

        public string Diretorio
        {
            get { return this.diretorio; }
            set { this.diretorio = value; }
        }

        public string Arquivo
        {
            get { return this.arquivo; }
            set
            {
                this.arquivo = value;

                if (this.tipoImpressora == E_TIPO_IMPRESSORA.Zebra)
                    this.arquivo += "_zebra.cpd";
                else
                    if (this.tipoImpressora == E_TIPO_IMPRESSORA.Datamax)
                    this.arquivo += "_datamax.cpd";

            }
        }

        public char Delimitador
        {
            get { return this.delimitador; }
            set { this.delimitador = value; }
        }

        public StringBuilder CodigoEtiqueta
        {
            get { return this.codigoEtiqueta; }
            set { this.codigoEtiqueta = value; }
        }

        public StringBuilder CodigoArquivo
        {
            get { return this.codigoArquivo; }
        }

        #endregion

        #region  Métodos

        public string SubstituiAcento(string codigo)
        {
            //O trecho abaixo trata de acentuação; os códigos comentados à direita em cada linha mostram o código ASCII do caractere tratado em cada linha
            codigo = codigo.Replace("Ç", "_80"); //128
            codigo = codigo.Replace("ü", "_81"); //129
            codigo = codigo.Replace("é", "_82"); //130
            codigo = codigo.Replace("â", "_83"); //131
            codigo = codigo.Replace("ä", "_84"); //132
            codigo = codigo.Replace("à", "_85"); //133
            codigo = codigo.Replace("ç", "_87"); //135
            codigo = codigo.Replace("ê", "_88"); //136
            codigo = codigo.Replace("ë", "_89"); //137
            codigo = codigo.Replace("è", "_8A"); //138
            codigo = codigo.Replace("ï", "_8B"); //139
            codigo = codigo.Replace("î", "_8C"); //140
            codigo = codigo.Replace("ì", "_8D"); //141
            codigo = codigo.Replace("Ä", "_8E"); //142
            codigo = codigo.Replace("É", "_90"); //144
            codigo = codigo.Replace("ô", "_93"); //147
            codigo = codigo.Replace("ö", "_94"); //148
            codigo = codigo.Replace("ò", "_95"); //149
            codigo = codigo.Replace("û", "_96"); //150
            codigo = codigo.Replace("ù", "_97"); //151
            codigo = codigo.Replace("ÿ", "_98"); //152
            codigo = codigo.Replace("Ö", "_99"); //153
            codigo = codigo.Replace("Ü", "_9A"); //154
            codigo = codigo.Replace("Ø", "_9D"); //157
            codigo = codigo.Replace("á", "_A0"); //160
            codigo = codigo.Replace("í", "_A1"); //161
            codigo = codigo.Replace("ó", "_A2"); //162
            codigo = codigo.Replace("ú", "_A3"); //163
            codigo = codigo.Replace("ñ", "_A4"); //164
            codigo = codigo.Replace("Ñ", "_A5"); //165
            codigo = codigo.Replace("²", "_FD"); //253 (OU 178 - B2(HEX))
            codigo = codigo.Replace("³", "_FC"); //252 (OU 179 - B3(HEX))
            codigo = codigo.Replace("Á", "_B5"); //181
            codigo = codigo.Replace("Â", "_B6"); //182
            codigo = codigo.Replace("À", "_B7"); //183
            codigo = codigo.Replace("ã", "_C6"); //198
            codigo = codigo.Replace("Ã", "_C7"); //199
            codigo = codigo.Replace("Ê", "_D2"); //210
            codigo = codigo.Replace("Ë", "_D3"); //211
            codigo = codigo.Replace("È", "_D4"); //212
            codigo = codigo.Replace("Í", "_D6"); //214
            codigo = codigo.Replace("Î", "_D7"); //215
            codigo = codigo.Replace("Ï", "_D8"); //216
            codigo = codigo.Replace("Ì", "_DE"); //222
            codigo = codigo.Replace("Ó", "_E0"); //224
            codigo = codigo.Replace("Ô", "_E2"); //226
            codigo = codigo.Replace("Ò", "_E3"); //227
            codigo = codigo.Replace("õ", "_E4"); //228
            codigo = codigo.Replace("Õ", "_E5"); //229
            codigo = codigo.Replace("Ú", "_E9"); //233
            codigo = codigo.Replace("Û", "_EA"); //234
            codigo = codigo.Replace("Ù", "_EB"); //235
            codigo = codigo.Replace("ý", "_EC"); //236
            codigo = codigo.Replace("Ý", "_ED"); //237
            codigo = codigo.Replace("°", "_a7"); //167

            return codigo;
        }
        
        public Etiqueta_Template(E_TIPO_IMPRESSORA tipo)
        {
            this.codigoArquivo = new StringBuilder();
            this.codigoEtiqueta = new StringBuilder();

            this.tipoImpressora = tipo;
        }

        public Etiqueta_Template(string diretorio, string arquivo, E_TIPO_IMPRESSORA tipo)
        {
            this.tipoImpressora = tipo;
            Diretorio = diretorio;

            Arquivo = arquivo;
        }

        public Etiqueta_Template(string diretorio, string arquivo, E_TIPO_IMPRESSORA tipo, char delimitador)
        {
            Diretorio = diretorio;
            this.tipoImpressora = tipo;
            Delimitador = delimitador;

            Arquivo = arquivo;
        }

        #endregion

    }
}
