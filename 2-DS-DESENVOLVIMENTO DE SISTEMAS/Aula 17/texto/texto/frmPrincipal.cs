using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace texto
{
    public partial class frmPrincipal : Form
    {
      
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void brnCarregarArquivo_Click(object sender, EventArgs e)
        {
            //ESSA APLICAÇÃO LÊ UM ARQUIVO TEXTO
            System.IO.StreamReader arquivo = new System.IO.StreamReader("D:\\dados\\info"); //CAMINHO DO ARQUIVO VARIÁVEL STREAMREADER -> FLUXO DE DADOS \N É UM CARACTER DE ESCAPE \T TABULAÇÃO \A BIP PARA O USUARIO \\ IGNORA A PRIMEIRA BARRA E USA A SEGUNDA COMO TEXTO
            string linha;
              

            
            while ((linha = arquivo.ReadLine()) != null)
            {
                string[] campo = linha.Split(';'); //VARIÁVEL COM VETOR

                //PEGA O QUE TEM ANTES DO PONTO E VÍRGULA, APÓS ISSO ELE DIVIDE O TEXTO E COLOCA NA MESSAGE BOX 
                // MessageBox.Show(campo[0]);
                /*oComando.CommandText = "INSERT INTO CADASTRO (CDSNOME, CDSTEL, CDSCPF) VALUES (@NOME, @TEL, @CPF)";
                oinstrucaoSQL.parameters.add("@NOME" MYSQLDBTYPE.STRING)Value = campo[0].TEXT;
                oinstrucaoSQL.parameters.add("@TEL" MYSQLDBTYPE.STRING)Value = campo[1].TEXT;
                oinstrucaoSQL.parameters.add("@CPF" MYSQLDBTYPE.STRING)Value = campo[2].TEXT;*/

                if(campo[0] !="")
                {
                    MessageBox.Show(String.Format("INSERT INTO CADASTRO (CDSNOME, CDSTEL, CDSCPF) VALUES ('{0}, {1}, {2}'", campo[0], campo[1], campo[2]));
                }
                else
                {
                    MessageBox.Show("ERRORR404");
                }
                
            }
            arquivo.Close();
        }
    }
}
