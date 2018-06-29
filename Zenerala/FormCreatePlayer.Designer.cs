/*
 * Creado por SharpDevelop.
 * Usuario: S.Otero
 * Fecha: 6/8/2018
 * Hora: 11:12 AM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Zenerala
{
	partial class FormCreatePlayer
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pNewPlayer = new System.Windows.Forms.Panel();
			this.btnNuevoJugador = new System.Windows.Forms.Button();
			this.lblNewPlayer = new System.Windows.Forms.Label();
			this.txtNewPlayer = new System.Windows.Forms.TextBox();
			this.pNewPlayer.SuspendLayout();
			this.SuspendLayout();
			// 
			// pNewPlayer
			// 
			this.pNewPlayer.Controls.Add(this.btnNuevoJugador);
			this.pNewPlayer.Controls.Add(this.lblNewPlayer);
			this.pNewPlayer.Controls.Add(this.txtNewPlayer);
			this.pNewPlayer.Dock = System.Windows.Forms.DockStyle.Top;
			this.pNewPlayer.Location = new System.Drawing.Point(0, 0);
			this.pNewPlayer.Name = "pNewPlayer";
			this.pNewPlayer.Size = new System.Drawing.Size(284, 165);
			this.pNewPlayer.TabIndex = 0;
			// 
			// btnNuevoJugador
			// 
			this.btnNuevoJugador.Location = new System.Drawing.Point(140, 108);
			this.btnNuevoJugador.Name = "btnNuevoJugador";
			this.btnNuevoJugador.Size = new System.Drawing.Size(75, 23);
			this.btnNuevoJugador.TabIndex = 2;
			this.btnNuevoJugador.Text = "Ingresar";
			this.btnNuevoJugador.UseVisualStyleBackColor = true;
			this.btnNuevoJugador.Click += new System.EventHandler(this.BtnNuevoJugadorClick);
			// 
			// lblNewPlayer
			// 
			this.lblNewPlayer.Location = new System.Drawing.Point(21, 20);
			this.lblNewPlayer.Name = "lblNewPlayer";
			this.lblNewPlayer.Size = new System.Drawing.Size(100, 23);
			this.lblNewPlayer.TabIndex = 1;
			this.lblNewPlayer.Text = "Ingrese Jugador:";
			// 
			// txtNewPlayer
			// 
			this.txtNewPlayer.Location = new System.Drawing.Point(21, 75);
			this.txtNewPlayer.Name = "txtNewPlayer";
			this.txtNewPlayer.Size = new System.Drawing.Size(100, 20);
			this.txtNewPlayer.TabIndex = 0;
			// 
			// FormCreatePlayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.pNewPlayer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormCreatePlayer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nuevo Jugador";
			this.pNewPlayer.ResumeLayout(false);
			this.pNewPlayer.PerformLayout();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.TextBox txtNewPlayer;
		private System.Windows.Forms.Label lblNewPlayer;
		private System.Windows.Forms.Button btnNuevoJugador;
		private System.Windows.Forms.Panel pNewPlayer;
	}
}
