using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cronometro
{
	public partial class Form1 : Form
	{
		Stopwatch cronometro = new Stopwatch();
		int vezParcial = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnIniciar_Click(object sender, EventArgs e)
		{
			//zerar o cronometro
			cronometro.Reset();

			//iniciar o cronometro
			cronometro.Start();

			//zerar as variaveis
			tbParcial.Text = null;
			vezParcial = 0;

			//desativar botão iniciar e ativar os de parada
			btnParcial.Enabled = true;
			btnParar.Enabled = true;
			btnIniciar.Enabled = false;
		}

		private void btnParar_Click(object sender, EventArgs e)
		{
			//para o cronômetro
			cronometro.Stop();
			
			//desativar botões de paradas e ativar o de início
			btnParcial.Enabled = false;
			btnParar.Enabled = false;
			btnIniciar.Enabled = true;
		}

		private void btnParcial_Click(object sender, EventArgs e)
		{
			vezParcial++;
			//jogar parcial no textbox e pular uma linha
			tbParcial.Text += vezParcial + "- " + lblTempo.Text + Environment.NewLine;
			//ir para a última linha do textbox
			tbParcial.SelectionStart = tbParcial.TextLength;
			tbParcial.ScrollToCaret();
		}

		private void tmrCronometro_Tick(object sender, EventArgs e)
		{			
			lblTempo.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", cronometro.Elapsed.Hours, cronometro.Elapsed.Minutes, cronometro.Elapsed.Seconds, cronometro.Elapsed.Milliseconds/10);
		}
	}
}