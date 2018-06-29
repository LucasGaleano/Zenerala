/*
 * Creado por SharpDevelop.
 * Usuario: S.Otero
 * Fecha: 6/7/2018
 * Hora: 12:44 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Zenerala
{
	partial class FormPlayGame
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayGame));
			this.pGame = new System.Windows.Forms.Panel();
			this.pMoves = new System.Windows.Forms.Panel();
			this.lblMoves = new System.Windows.Forms.Label();
			this.btnMoves6 = new System.Windows.Forms.Button();
			this.btnMoves5 = new System.Windows.Forms.Button();
			this.btnMoves4 = new System.Windows.Forms.Button();
			this.btnMoves3 = new System.Windows.Forms.Button();
			this.btnMoves2 = new System.Windows.Forms.Button();
			this.btnMoves1 = new System.Windows.Forms.Button();
			this.pDices = new System.Windows.Forms.Panel();
			this.lblDicesOnTable = new System.Windows.Forms.Label();
			this.btnDice1 = new System.Windows.Forms.Button();
			this.btnDice2 = new System.Windows.Forms.Button();
			this.btnDice5 = new System.Windows.Forms.Button();
			this.btnDice3 = new System.Windows.Forms.Button();
			this.btnDice4 = new System.Windows.Forms.Button();
			this.pPuntuation = new System.Windows.Forms.Panel();
			this.dgvPuntuation = new System.Windows.Forms.DataGridView();
			this.pHeader = new System.Windows.Forms.Panel();
			this.lblCurrentPlayer = new System.Windows.Forms.Label();
			this.lblTurn = new System.Windows.Forms.Label();
			this.pbDiceShaker = new System.Windows.Forms.PictureBox();
			this.pPlayers = new System.Windows.Forms.Panel();
			this.lblPlayers = new System.Windows.Forms.Label();
			this.pb2Players = new System.Windows.Forms.PictureBox();
			this.pGame.SuspendLayout();
			this.pMoves.SuspendLayout();
			this.pDices.SuspendLayout();
			this.pPuntuation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPuntuation)).BeginInit();
			this.pHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDiceShaker)).BeginInit();
			this.pPlayers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb2Players)).BeginInit();
			this.SuspendLayout();
			// 
			// pGame
			// 
			this.pGame.BackColor = System.Drawing.Color.White;
			this.pGame.Controls.Add(this.pMoves);
			this.pGame.Controls.Add(this.pDices);
			this.pGame.Controls.Add(this.pPuntuation);
			this.pGame.Controls.Add(this.pHeader);
			this.pGame.Controls.Add(this.pbDiceShaker);
			this.pGame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pGame.Location = new System.Drawing.Point(0, 0);
			this.pGame.Name = "pGame";
			this.pGame.Size = new System.Drawing.Size(777, 570);
			this.pGame.TabIndex = 2;
			// 
			// pMoves
			// 
			this.pMoves.BackColor = System.Drawing.Color.White;
			this.pMoves.Controls.Add(this.lblMoves);
			this.pMoves.Controls.Add(this.btnMoves6);
			this.pMoves.Controls.Add(this.btnMoves5);
			this.pMoves.Controls.Add(this.btnMoves4);
			this.pMoves.Controls.Add(this.btnMoves3);
			this.pMoves.Controls.Add(this.btnMoves2);
			this.pMoves.Controls.Add(this.btnMoves1);
			this.pMoves.Dock = System.Windows.Forms.DockStyle.Right;
			this.pMoves.Location = new System.Drawing.Point(328, 86);
			this.pMoves.Name = "pMoves";
			this.pMoves.Size = new System.Drawing.Size(199, 348);
			this.pMoves.TabIndex = 11;
			// 
			// lblMoves
			// 
			this.lblMoves.Font = new System.Drawing.Font("Futura Light", 14.25F);
			this.lblMoves.Location = new System.Drawing.Point(30, 21);
			this.lblMoves.Name = "lblMoves";
			this.lblMoves.Size = new System.Drawing.Size(100, 23);
			this.lblMoves.TabIndex = 6;
			this.lblMoves.Text = "Jugadas";
			// 
			// btnMoves6
			// 
			this.btnMoves6.FlatAppearance.BorderSize = 0;
			this.btnMoves6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMoves6.Font = new System.Drawing.Font("Futura Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMoves6.Location = new System.Drawing.Point(31, 245);
			this.btnMoves6.Name = "btnMoves6";
			this.btnMoves6.Size = new System.Drawing.Size(161, 32);
			this.btnMoves6.TabIndex = 5;
			this.btnMoves6.Text = "bMoveSix";
			this.btnMoves6.UseVisualStyleBackColor = true;
			this.btnMoves6.Click += new System.EventHandler(this.BtnMoves6Click);
			// 
			// btnMoves5
			// 
			this.btnMoves5.FlatAppearance.BorderSize = 0;
			this.btnMoves5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMoves5.Font = new System.Drawing.Font("Futura Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMoves5.Location = new System.Drawing.Point(31, 207);
			this.btnMoves5.Name = "btnMoves5";
			this.btnMoves5.Size = new System.Drawing.Size(161, 32);
			this.btnMoves5.TabIndex = 4;
			this.btnMoves5.Text = "bMoveFive";
			this.btnMoves5.UseVisualStyleBackColor = true;
			this.btnMoves5.Click += new System.EventHandler(this.BtnMoves5Click);
			// 
			// btnMoves4
			// 
			this.btnMoves4.FlatAppearance.BorderSize = 0;
			this.btnMoves4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMoves4.Font = new System.Drawing.Font("Futura Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMoves4.Location = new System.Drawing.Point(31, 169);
			this.btnMoves4.Name = "btnMoves4";
			this.btnMoves4.Size = new System.Drawing.Size(161, 32);
			this.btnMoves4.TabIndex = 3;
			this.btnMoves4.Text = "bMoveFour";
			this.btnMoves4.UseVisualStyleBackColor = true;
			this.btnMoves4.Click += new System.EventHandler(this.BtnMoves4Click);
			// 
			// btnMoves3
			// 
			this.btnMoves3.FlatAppearance.BorderSize = 0;
			this.btnMoves3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMoves3.Font = new System.Drawing.Font("Futura Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMoves3.Location = new System.Drawing.Point(31, 131);
			this.btnMoves3.Name = "btnMoves3";
			this.btnMoves3.Size = new System.Drawing.Size(161, 32);
			this.btnMoves3.TabIndex = 2;
			this.btnMoves3.Text = "bMoveThree";
			this.btnMoves3.UseVisualStyleBackColor = true;
			this.btnMoves3.Click += new System.EventHandler(this.BtnMoves3Click);
			// 
			// btnMoves2
			// 
			this.btnMoves2.FlatAppearance.BorderSize = 0;
			this.btnMoves2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMoves2.Font = new System.Drawing.Font("Futura Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMoves2.Location = new System.Drawing.Point(31, 93);
			this.btnMoves2.Name = "btnMoves2";
			this.btnMoves2.Size = new System.Drawing.Size(161, 32);
			this.btnMoves2.TabIndex = 1;
			this.btnMoves2.Text = "bMoveTwo";
			this.btnMoves2.UseVisualStyleBackColor = true;
			this.btnMoves2.Click += new System.EventHandler(this.BtnMoves2Click);
			// 
			// btnMoves1
			// 
			this.btnMoves1.FlatAppearance.BorderSize = 0;
			this.btnMoves1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMoves1.Font = new System.Drawing.Font("Futura Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMoves1.Location = new System.Drawing.Point(31, 55);
			this.btnMoves1.Name = "btnMoves1";
			this.btnMoves1.Size = new System.Drawing.Size(161, 32);
			this.btnMoves1.TabIndex = 0;
			this.btnMoves1.Text = "bMoveOne";
			this.btnMoves1.UseVisualStyleBackColor = true;
			this.btnMoves1.Click += new System.EventHandler(this.BtnMoves1Click);
			// 
			// pDices
			// 
			this.pDices.BackColor = System.Drawing.Color.White;
			this.pDices.Controls.Add(this.lblDicesOnTable);
			this.pDices.Controls.Add(this.btnDice1);
			this.pDices.Controls.Add(this.btnDice2);
			this.pDices.Controls.Add(this.btnDice5);
			this.pDices.Controls.Add(this.btnDice3);
			this.pDices.Controls.Add(this.btnDice4);
			this.pDices.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pDices.Location = new System.Drawing.Point(0, 434);
			this.pDices.Name = "pDices";
			this.pDices.Size = new System.Drawing.Size(527, 136);
			this.pDices.TabIndex = 10;
			// 
			// lblDicesOnTable
			// 
			this.lblDicesOnTable.Font = new System.Drawing.Font("Futura Light", 14.25F);
			this.lblDicesOnTable.Location = new System.Drawing.Point(23, 13);
			this.lblDicesOnTable.Name = "lblDicesOnTable";
			this.lblDicesOnTable.Size = new System.Drawing.Size(187, 23);
			this.lblDicesOnTable.TabIndex = 8;
			this.lblDicesOnTable.Text = "Dados en Mesa";
			// 
			// btnDice1
			// 
			this.btnDice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDice1.Location = new System.Drawing.Point(23, 45);
			this.btnDice1.Name = "btnDice1";
			this.btnDice1.Size = new System.Drawing.Size(64, 64);
			this.btnDice1.TabIndex = 3;
			this.btnDice1.UseVisualStyleBackColor = true;
			this.btnDice1.Click += new System.EventHandler(this.BtnDice1Click);
			// 
			// btnDice2
			// 
			this.btnDice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDice2.Location = new System.Drawing.Point(127, 45);
			this.btnDice2.Name = "btnDice2";
			this.btnDice2.Size = new System.Drawing.Size(64, 64);
			this.btnDice2.TabIndex = 4;
			this.btnDice2.UseVisualStyleBackColor = true;
			this.btnDice2.Click += new System.EventHandler(this.BtnDice2Click);
			// 
			// btnDice5
			// 
			this.btnDice5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDice5.Location = new System.Drawing.Point(439, 45);
			this.btnDice5.Name = "btnDice5";
			this.btnDice5.Size = new System.Drawing.Size(64, 64);
			this.btnDice5.TabIndex = 7;
			this.btnDice5.UseVisualStyleBackColor = true;
			this.btnDice5.Click += new System.EventHandler(this.BtnDice5Click);
			// 
			// btnDice3
			// 
			this.btnDice3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDice3.Location = new System.Drawing.Point(231, 45);
			this.btnDice3.Name = "btnDice3";
			this.btnDice3.Size = new System.Drawing.Size(64, 64);
			this.btnDice3.TabIndex = 5;
			this.btnDice3.UseVisualStyleBackColor = true;
			this.btnDice3.Click += new System.EventHandler(this.BtnDice3Click);
			// 
			// btnDice4
			// 
			this.btnDice4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDice4.Location = new System.Drawing.Point(336, 45);
			this.btnDice4.Name = "btnDice4";
			this.btnDice4.Size = new System.Drawing.Size(64, 64);
			this.btnDice4.TabIndex = 6;
			this.btnDice4.UseVisualStyleBackColor = true;
			this.btnDice4.Click += new System.EventHandler(this.BtnDice4Click);
			// 
			// pPuntuation
			// 
			this.pPuntuation.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pPuntuation.Controls.Add(this.dgvPuntuation);
			this.pPuntuation.Dock = System.Windows.Forms.DockStyle.Right;
			this.pPuntuation.Location = new System.Drawing.Point(527, 86);
			this.pPuntuation.Name = "pPuntuation";
			this.pPuntuation.Size = new System.Drawing.Size(250, 484);
			this.pPuntuation.TabIndex = 9;
			// 
			// dgvPuntuation
			// 
			this.dgvPuntuation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPuntuation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPuntuation.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.dgvPuntuation.Location = new System.Drawing.Point(8, 43);
			this.dgvPuntuation.Name = "dgvPuntuation";
			this.dgvPuntuation.ReadOnly = true;
			this.dgvPuntuation.Size = new System.Drawing.Size(232, 306);
			this.dgvPuntuation.TabIndex = 0;
			// 
			// pHeader
			// 
			this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.pHeader.Controls.Add(this.lblCurrentPlayer);
			this.pHeader.Controls.Add(this.lblTurn);
			this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pHeader.Location = new System.Drawing.Point(0, 0);
			this.pHeader.Name = "pHeader";
			this.pHeader.Size = new System.Drawing.Size(777, 86);
			this.pHeader.TabIndex = 8;
			// 
			// lblCurrentPlayer
			// 
			this.lblCurrentPlayer.Font = new System.Drawing.Font("Futura Light", 14.25F);
			this.lblCurrentPlayer.ForeColor = System.Drawing.Color.White;
			this.lblCurrentPlayer.Location = new System.Drawing.Point(24, 28);
			this.lblCurrentPlayer.Name = "lblCurrentPlayer";
			this.lblCurrentPlayer.Size = new System.Drawing.Size(205, 23);
			this.lblCurrentPlayer.TabIndex = 0;
			this.lblCurrentPlayer.Text = "Nombre Jugador";
			// 
			// lblTurn
			// 
			this.lblTurn.Font = new System.Drawing.Font("Futura Light", 14.25F);
			this.lblTurn.ForeColor = System.Drawing.Color.White;
			this.lblTurn.Location = new System.Drawing.Point(237, 28);
			this.lblTurn.Name = "lblTurn";
			this.lblTurn.Size = new System.Drawing.Size(198, 23);
			this.lblTurn.TabIndex = 1;
			this.lblTurn.Text = "Turno actual";
			// 
			// pbDiceShaker
			// 
			this.pbDiceShaker.BackColor = System.Drawing.Color.Transparent;
			this.pbDiceShaker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pbDiceShaker.Image = ((System.Drawing.Image)(resources.GetObject("pbDiceShaker.Image")));
			this.pbDiceShaker.Location = new System.Drawing.Point(0, 141);
			this.pbDiceShaker.Name = "pbDiceShaker";
			this.pbDiceShaker.Size = new System.Drawing.Size(313, 235);
			this.pbDiceShaker.TabIndex = 2;
			this.pbDiceShaker.TabStop = false;
			this.pbDiceShaker.Click += new System.EventHandler(this.PbDiceShakerClick);
			// 
			// pPlayers
			// 
			this.pPlayers.BackColor = System.Drawing.Color.White;
			this.pPlayers.Controls.Add(this.lblPlayers);
			this.pPlayers.Controls.Add(this.pb2Players);
			this.pPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pPlayers.Location = new System.Drawing.Point(0, 0);
			this.pPlayers.Name = "pPlayers";
			this.pPlayers.Size = new System.Drawing.Size(777, 570);
			this.pPlayers.TabIndex = 3;
			// 
			// lblPlayers
			// 
			this.lblPlayers.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayers.Location = new System.Drawing.Point(0, 0);
			this.lblPlayers.Name = "lblPlayers";
			this.lblPlayers.Size = new System.Drawing.Size(777, 116);
			this.lblPlayers.TabIndex = 1;
			this.lblPlayers.Text = "Seleccione la cantidad de jugadores";
			this.lblPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pb2Players
			// 
			this.pb2Players.BackColor = System.Drawing.Color.White;
			this.pb2Players.Image = ((System.Drawing.Image)(resources.GetObject("pb2Players.Image")));
			this.pb2Players.Location = new System.Drawing.Point(101, 177);
			this.pb2Players.Name = "pb2Players";
			this.pb2Players.Size = new System.Drawing.Size(128, 128);
			this.pb2Players.TabIndex = 0;
			this.pb2Players.TabStop = false;
			this.pb2Players.Click += new System.EventHandler(this.Pb2PlayersClick);
			// 
			// FormPlayGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(777, 570);
			this.Controls.Add(this.pGame);
			this.Controls.Add(this.pPlayers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormPlayGame";
			this.Text = "FormPlayGame";
			this.pGame.ResumeLayout(false);
			this.pMoves.ResumeLayout(false);
			this.pDices.ResumeLayout(false);
			this.pPuntuation.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvPuntuation)).EndInit();
			this.pHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbDiceShaker)).EndInit();
			this.pPlayers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pb2Players)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView dgvPuntuation;
		private System.Windows.Forms.Label lblDicesOnTable;
		private System.Windows.Forms.Label lblMoves;
		private System.Windows.Forms.Button btnMoves1;
		private System.Windows.Forms.Button btnMoves2;
		private System.Windows.Forms.Button btnMoves3;
		private System.Windows.Forms.Button btnMoves4;
		private System.Windows.Forms.Button btnMoves5;
		private System.Windows.Forms.Button btnMoves6;
		private System.Windows.Forms.Panel pHeader;
		private System.Windows.Forms.Panel pPuntuation;
		private System.Windows.Forms.Panel pDices;
		private System.Windows.Forms.Panel pMoves;
		private System.Windows.Forms.PictureBox pb2Players;
		private System.Windows.Forms.Panel pPlayers;
		private System.Windows.Forms.Panel pGame;
		private System.Windows.Forms.PictureBox pbDiceShaker;
		private System.Windows.Forms.Label lblTurn;
		private System.Windows.Forms.Label lblCurrentPlayer;
		private System.Windows.Forms.Button btnDice5;
		private System.Windows.Forms.Button btnDice4;
		private System.Windows.Forms.Button btnDice3;
		private System.Windows.Forms.Button btnDice2;
		private System.Windows.Forms.Button btnDice1;
		private System.Windows.Forms.Label lblPlayers;
	}
}
