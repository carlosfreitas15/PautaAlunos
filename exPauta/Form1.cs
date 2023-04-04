﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace exPauta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColonizarGrid();
            CalcularMedia();
            CalcularNumNegativas();
        }

        private void ColonizarGrid()
        {
            dgvPauta.Rows.Add("1", "Ana Rita Cunha", "Gualtar", "1997", 'F', "10", "11", "12", "10", "11", "12", "10", "11", "12", "11", "--", "--");
            dgvPauta.Rows.Add("2", "Bela Costa Silva", "Maximinos", "1999", "F", "15", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("3", "Carlos Alberto Costa", "Aveleda", "2000", "M", "10", "11", "12", "10", "11", "12", "10", "19", "12", "12", "--", "--");
            dgvPauta.Rows.Add("4", "Carlos Daniel Ferreira", "Gualtar", "2000", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("5", "Daniel Bastos Gomes", "Maximinos", "2001", "M", "10", "11", "8", "10", "11", "12", "10", "11", "12", "18", "--", "--");
            dgvPauta.Rows.Add("6", "Daniel Silva Ferraz", "Ferreiros", "1997", "M", "20", "11", "12", "20", "20", "12", "7", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("7", "Elvira Gomes Pendes", "Maximinos", "2002", "F", "10", "11", "12", "10", "11", "12", "10", "11", "12", "13", "--", "--");
            dgvPauta.Rows.Add("8", "Fernanda Maria Silva", "Aveleda", "2001", "F", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("9", "Fernando Gomes Barros", "Gualtar", "1997", "M", "7", "11", "12", "10", "9", "12", "10", "11", "12", "16", "--", "--");
            dgvPauta.Rows.Add("10", "Guilherme Alexandre Barros", "Aveleda", "1997", "M", "10", "11", "19", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("11", "Hilda Fonseca Silva", "Maximinos", "1997", "F", "10", "11", "12", "10", "11", "12", "10", "11", "12", "13", "--", "--");
            dgvPauta.Rows.Add("12", "José Manuel Carvalho", "Sé", "2001", "M", "10", "11", "16", "10", "11", "12", "10", "11", "12", "13", "--", "--");
            dgvPauta.Rows.Add("13", "José Alberto Gomes", "Maximinos", "2002", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("14", "Maria Silvéria Bastos", "Lovios", "2001", "F", "10", "11", "12", "16", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("15", "Anabela Bastos Torres", "Ferreiros", "1997", "F", "10", "11", "12", "10", "11", "12", "10", "11", "12", "14", "--", "--");
            dgvPauta.Rows.Add("16", "Rui Vasco Santos", "Maximinos", "2001", "M", "10", "11", "12", "10", "15", "12", "10", "11", "12", "5", "--", "--");
            dgvPauta.Rows.Add("17", "Otávio Ferreira", "Gualtar", "2002", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("18", "Silvério Silva Teixeira", "Ferreiros", "1997", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("19", "Teodoro Armando Matos", "Maximinos", "2004", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("20", "Zacarias Alexandre Sampaio", "Sequeira", "1995", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
        }

        private void CalcularMedia()
        {
            double soma = 0;
            double media = 0;

            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {



                for (int j = 5; j < 15; j++)
                {
                    soma = soma + Convert.ToDouble(dgvPauta.Rows[i].Cells[j].Value);


                }

                media = soma / 10;
                dgvPauta.Rows[i].Cells[15].Value = media;
                soma = 0;
            }
        }

        private void CalcularNumNegativas()
        {
            int contador = 0;

            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                for (int j = 5; j < 15; j++)
                {
                    if (Convert.ToInt64(dgvPauta.Rows[i].Cells[j].Value) < 10)
                    {
                        contador++;
                        //dgvPauta.Rows[i].ForeColor = Color.Red;
                    }
                }

                if (contador > 1)
                {
                    dgvPauta.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                }
                dgvPauta.Rows[i].Cells[16].Value = contador;
                contador = 0;
            }
        }

        private void btnContarRaparigas_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string sexo = "F";

            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                for (int j = 4; j < 5; j++)
                {
                    if (Convert.ToString(dgvPauta.Rows[i].Cells[j].Value) == sexo)
                    {
                        contador++;
                    }
                }
            }

            MessageBox.Show(Convert.ToString(contador));
        }

        private void btnContarRapazesMaximinos_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string localidade = "Maximinos";
            string sexo = "M";

            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {

                if (Convert.ToString(dgvPauta.Rows[i].Cells[2].Value) == localidade && Convert.ToString(dgvPauta.Rows[i].Cells[4].Value) == sexo)
                {

                    contador++;
                }

            }

            MessageBox.Show(Convert.ToString(contador));
        }

        private void btnContarRapazesRaparigas_Click(object sender, EventArgs e)
        {
            int contadorM = 0;
            int contadorF = 0;
            string sexoM = "M";


            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                if (Convert.ToString(dgvPauta.Rows[i].Cells[4].Value) == sexoM)
                {
                    contadorM++;
                }
                else
                {
                    contadorF++;
                }
            }

            if (contadorM > contadorF)
            {
                MessageBox.Show("Há mais Rapazes");
            }
            else
            {
                MessageBox.Show("Há mais Raparigas");
            }
        }

        private void btnEncontrarMaisVelho_Click(object sender, EventArgs e)
        {
            int maisvelho = Convert.ToInt32(dgvPauta.Rows[0].Cells[3].Value);
            string pessoamaisvelha = Convert.ToString(dgvPauta.Rows[0].Cells[1].Value);

            for (int i = 0; i < Convert.ToInt32(dgvPauta.Rows.Count - 1); i++)
            {


                if (Convert.ToInt32(dgvPauta.Rows[i].Cells[3].Value) < maisvelho)
                {
                    maisvelho = Convert.ToInt32(dgvPauta.Rows[i].Cells[3].Value);
                    pessoamaisvelha = Convert.ToString(dgvPauta.Rows[i].Cells[1].Value);
                }
            }

            MessageBox.Show(pessoamaisvelha + maisvelho);
        }

        private void btnContarReprovadosComMediaSuperiorA12_Click(object sender, EventArgs e)
        {
            int contador = 0;

            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dgvPauta.Rows[i].Cells[16].Value) >= 2 && Convert.ToInt32(dgvPauta.Rows[i].Cells[15].Value) > 12)
                {
                    contador++;
                }
            }

            MessageBox.Show(Convert.ToString(contador));
        }

        private void btnEncontrarMelhoresAlunos_Click(object sender, EventArgs e)
        {
            string nomeMelhorAluno = Convert.ToString(dgvPauta.Rows[0].Cells[1].Value);
            string nomeMelhorAluno2 = Convert.ToString(dgvPauta.Rows[0].Cells[1].Value);
            string nomeMelhorAluno3 = Convert.ToString(dgvPauta.Rows[0].Cells[1].Value);

            double mediaMelhorAluno = Convert.ToDouble(dgvPauta.Rows[0].Cells[15].Value);
            double mediaMelhorAluno2 = Convert.ToDouble(dgvPauta.Rows[0].Cells[15].Value);
            double mediaMelhorAluno3 = Convert.ToDouble(dgvPauta.Rows[0].Cells[15].Value);

            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                if (Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value) > mediaMelhorAluno && Convert.ToInt32(dgvPauta.Rows[i].Cells[16].Value) < 2)
                {
                    nomeMelhorAluno = Convert.ToString(dgvPauta.Rows[i].Cells[1].Value);
                    mediaMelhorAluno = Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value);
                }
            }

            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                if (Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value) > mediaMelhorAluno2 && Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value) != mediaMelhorAluno && Convert.ToInt32(dgvPauta.Rows[i].Cells[16].Value) < 2)
                {
              
                        nomeMelhorAluno2 = Convert.ToString(dgvPauta.Rows[i].Cells[1].Value);
                        mediaMelhorAluno2 = Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value);
                   

                }
            }

            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                if (Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value) > mediaMelhorAluno3 && Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value) != mediaMelhorAluno && Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value) != mediaMelhorAluno2 && Convert.ToInt32(dgvPauta.Rows[i].Cells[16].Value) < 2)
                {

                    nomeMelhorAluno3 = Convert.ToString(dgvPauta.Rows[i].Cells[1].Value);
                    mediaMelhorAluno3 = Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value);


                }
            }


           

            MessageBox.Show(Convert.ToString(nomeMelhorAluno + '\n'+ nomeMelhorAluno2 + '\n' + nomeMelhorAluno3));
        }

        private void btnEncontrarApelidos_Click(object sender, EventArgs e)
        {
            List<string> Reprovados = new List<string>(); //INSTANCIACAO DA LISTA (LISTA É UMA CLASSE) REPROVADOS É UM APONTADOR
            string apelidos = "";


            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dgvPauta.Rows[i].Cells[16].Value) > 1) //PROCURA OS REPROVADOS
                {
                    Reprovados.Add(Convert.ToString(dgvPauta.Rows[i].Cells[1].Value)); //ADICIONA À LISTA OS NOMES DOS REPROVADOS
                }
            }

            foreach (string lista in Reprovados)
            {
                int index = lista.IndexOf(' ');
                index = lista.IndexOf(' ', index + 1); //IndexOf identifica o index do primeiro ' '. ao colocar index + 1 é para localizar outro ' '.
                string result = lista.Substring(index); //Substring retira a parte da string que queremos, neste caso so o que esta depois do index (ou seja, do segundo ' ')

                lstReprovados.Items.Add(result);
            }

        }

        private void btnNomesFreguesias_Click(object sender, EventArgs e)
        {
            List<string> nomesMaisFreguesias = new List<string>();



            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                nomesMaisFreguesias.Add(dgvPauta.Rows[i].Cells[1].Value.ToString() + ' ' + '-' + ' ' + dgvPauta.Rows[i].Cells[2].Value.ToString());

            }



            foreach (string formandos in nomesMaisFreguesias)
            {
                lstNomesFreguesias.Items.Add(formandos);
            }
        }
    }
}

    

