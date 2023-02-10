/* Projeto: Etiqueta Testes de Cor
 * Autora: Izabela Leme
 * Data: 10/02/2023
 * */

using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Collections.Generic;



namespace ETQ
{
    public partial class Frm000100EtqTestesCor : Form
    {

        #region  Atributos

        private ToolStripButton btnImprimir;
        string cfg_file_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TIPlasutil\\impressao_etq_cfg.dat";
        Etiqueta_Template etiqueta = new Etiqueta_Template(E_TIPO_IMPRESSORA.Zebra);

        private int intQuantidade = 0;
        private string strPigmento = string.Empty;
        private string strCodCor = string.Empty;
        private string strConcentracao = string.Empty;
        private string strFornecedor = string.Empty;
        private string strResina = string.Empty;

        #endregion


        #region  Construtores

        #endregion


        #region  Métodos

        #endregion


        #region  Eventos

        #endregion


        public Frm000100EtqTestesCor()
        {
            InitializeComponent();
        }
    }
}