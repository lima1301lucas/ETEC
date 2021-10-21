using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercícioCheque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string FnDia(int Ndia)
        {
            string[] vDia = {"","01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15",
            "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30",};
            if (Ndia > 0 && Ndia < 30)
                return vDia[Ndia];
            else
                return "invalido";
        }
        private string FnMes(int NMes)
        {
            string[] vMes = { "Inválido", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            if (NMes > 0 && NMes < 13)
                return vMes[NMes];
            else
                return "invalido";
        }
        private string FnAno(int NAno)
        {
            string[] vMes = { "Inválido", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            if (NAno > 0 && NAno < 13)
                return vMes[NAno];
            else
                return "in";
        }

        private string FnExtenso(string ValorSeparado)
        {
            switch (ValorSeparado)
            {
                case "1": return "Um";
                case "2": return "Dois";
                case "3": return "Tres";
                case "4": return "Quatro";
                case "5": return "Cinco";
                case "6": return "Seis";
                case "7": return "Sete";
                case "8": return "Oito";
                case "9": return "Nove";
                case "10": return "Dez";
                case "11": return "Onze";
                case "12": return "Doze";
                case "13": return "Treze";
                case "14": return "Quatorze";
                case "15": return "Quinze";
                case "16": return "Dezesseis";
                case "17": return "Dezessete";
                case "18": return "Dezoito";
                case "19": return "Dezenove";
                case "20": return "Vinte";
                case "30": return "Trinta";
                case "40": return "Quarenta";
                case "50": return "Cinquenta";
                case "60": return "Sessenta";
                case "70": return "Setenta";
                case "80": return "Oitenta";
                case "90": return "Noventa";
                case "100": return "Cem";
                case "200": return "Duzentos";
                case "300": return "Trezentos";
                case "400": return "Quatrocentos";
                case "500": return "Quinhentos";
                case "600": return "Seicentos";
                case "700": return "Setecentos";
                case "800": return "Oitocentos";
                case "900": return "Novecentos";

                default: return "Valor inválido";
            }

            int tamanho, resultado;
            tamanho = ValorSeparado.ToString().Length; // Tamanho do valor do cheque
            resultado = int.Parse(ValorSeparado);

            if (tamanho == 5)
            {
                resultado = int.Parse(ValorSeparado) / 10000;
                resultado = resultado * 10000;
                resultado = int.Parse(ValorSeparado) - resultado;
            }
            if (tamanho == 4)
            {
                resultado = int.Parse(ValorSeparado) / 1000;
                resultado = resultado * 1000;
                resultado = int.Parse(ValorSeparado) - resultado;
            }

            else if (tamanho == 3)
            {
                resultado = int.Parse(ValorSeparado) / 100;
                resultado = resultado * 100;
                resultado = int.Parse(ValorSeparado) - resultado;
            }

            else if (tamanho == 2)
            {
                resultado = int.Parse(ValorSeparado) / 10;
                resultado = resultado * 10;
                resultado = int.Parse(ValorSeparado) - resultado;
            }
        }
        private void Txt_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_valor_KeyUp(object sender, KeyEventArgs e)
        {
            lbl_extenso.Text = FnExtenso(txt_valor.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void Txt_data_TextChanged(object sender, EventArgs e)
        {
        }

        private void Btn_mes_Click(object sender, EventArgs e)
        {
            lbl_mes.Text = FnMes(DateTime.Now.Month);
        }

        private void Btn_dia_Click(object sender, EventArgs e)
        {
            lbl_dia.Text = FnDia(DateTime.Now.Day);
        }

        private void Btn_ano_Click(object sender, EventArgs e)
        {
            lbl_ano.Text = FnAno(DateTime.Now.Year);
        }

    }
}

