namespace Cronometro
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblTempo = new System.Windows.Forms.Label();
			this.btnIniciar = new System.Windows.Forms.Button();
			this.btnParcial = new System.Windows.Forms.Button();
			this.btnParar = new System.Windows.Forms.Button();
			this.tbParcial = new System.Windows.Forms.TextBox();
			this.tmrCronometro = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lblTempo
			// 
			this.lblTempo.AutoSize = true;
			this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTempo.Location = new System.Drawing.Point(22, 49);
			this.lblTempo.Name = "lblTempo";
			this.lblTempo.Size = new System.Drawing.Size(216, 42);
			this.lblTempo.TabIndex = 0;
			this.lblTempo.Text = "00:00:00:00";
			this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnIniciar
			// 
			this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIniciar.Location = new System.Drawing.Point(12, 138);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new System.Drawing.Size(242, 58);
			this.btnIniciar.TabIndex = 1;
			this.btnIniciar.Text = "Iniciar";
			this.btnIniciar.UseVisualStyleBackColor = true;
			this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
			// 
			// btnParcial
			// 
			this.btnParcial.Enabled = false;
			this.btnParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnParcial.Location = new System.Drawing.Point(10, 202);
			this.btnParcial.Name = "btnParcial";
			this.btnParcial.Size = new System.Drawing.Size(119, 58);
			this.btnParcial.TabIndex = 2;
			this.btnParcial.Text = "Parcial";
			this.btnParcial.UseVisualStyleBackColor = true;
			this.btnParcial.Click += new System.EventHandler(this.btnParcial_Click);
			// 
			// btnParar
			// 
			this.btnParar.Enabled = false;
			this.btnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnParar.Location = new System.Drawing.Point(135, 202);
			this.btnParar.Name = "btnParar";
			this.btnParar.Size = new System.Drawing.Size(119, 58);
			this.btnParar.TabIndex = 3;
			this.btnParar.Text = "Parar";
			this.btnParar.UseVisualStyleBackColor = true;
			this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
			// 
			// tbParcial
			// 
			this.tbParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbParcial.Location = new System.Drawing.Point(260, 12);
			this.tbParcial.Multiline = true;
			this.tbParcial.Name = "tbParcial";
			this.tbParcial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbParcial.Size = new System.Drawing.Size(222, 248);
			this.tbParcial.TabIndex = 4;
			// 
			// tmrCronometro
			// 
			this.tmrCronometro.Enabled = true;
			this.tmrCronometro.Interval = 1;
			this.tmrCronometro.Tick += new System.EventHandler(this.tmrCronometro_Tick);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnIniciar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 272);
			this.Controls.Add(this.tbParcial);
			this.Controls.Add(this.btnParar);
			this.Controls.Add(this.btnParcial);
			this.Controls.Add(this.btnIniciar);
			this.Controls.Add(this.lblTempo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cronômetro";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTempo;
		private System.Windows.Forms.Button btnIniciar;
		private System.Windows.Forms.Button btnParcial;
		private System.Windows.Forms.Button btnParar;
		private System.Windows.Forms.TextBox tbParcial;
		private System.Windows.Forms.Timer tmrCronometro;
	}
}

