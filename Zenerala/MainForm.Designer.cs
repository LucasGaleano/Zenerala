/*
 * Creado por SharpDevelop.
 * Usuario: S.Otero
 * Fecha: 6/7/2018
 * Hora: 7:54 AM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Zenerala
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pLateralMenu = new System.Windows.Forms.Panel();
			this.pBtnExit = new System.Windows.Forms.Panel();
			this.bExit = new System.Windows.Forms.Button();
			this.pBtnNotation = new System.Windows.Forms.Panel();
			this.bNotation = new System.Windows.Forms.Button();
			this.pBtnRecord = new System.Windows.Forms.Panel();
			this.bRecord = new System.Windows.Forms.Button();
			this.pBtnRules = new System.Windows.Forms.Panel();
			this.bRules = new System.Windows.Forms.Button();
			this.pBtnPlay = new System.Windows.Forms.Panel();
			this.bPlay = new System.Windows.Forms.Button();
			this.pTittle = new System.Windows.Forms.Panel();
			this.lblTime = new System.Windows.Forms.Label();
			this.pMainPanel = new System.Windows.Forms.Panel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timerDate = new System.Windows.Forms.Timer(this.components);
			this.pLateralMenu.SuspendLayout();
			this.pTittle.SuspendLayout();
			this.SuspendLayout();
			// 
			// pLateralMenu
			// 
			this.pLateralMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.pLateralMenu.Controls.Add(this.pBtnExit);
			this.pLateralMenu.Controls.Add(this.bExit);
			this.pLateralMenu.Controls.Add(this.pBtnNotation);
			this.pLateralMenu.Controls.Add(this.bNotation);
			this.pLateralMenu.Controls.Add(this.pBtnRecord);
			this.pLateralMenu.Controls.Add(this.bRecord);
			this.pLateralMenu.Controls.Add(this.pBtnRules);
			this.pLateralMenu.Controls.Add(this.bRules);
			this.pLateralMenu.Controls.Add(this.pBtnPlay);
			this.pLateralMenu.Controls.Add(this.bPlay);
			this.pLateralMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pLateralMenu.Location = new System.Drawing.Point(0, 0);
			this.pLateralMenu.Name = "pLateralMenu";
			this.pLateralMenu.Size = new System.Drawing.Size(183, 600);
			this.pLateralMenu.TabIndex = 0;
			// 
			// pBtnExit
			// 
			this.pBtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.pBtnExit.Location = new System.Drawing.Point(0, 554);
			this.pBtnExit.Name = "pBtnExit";
			this.pBtnExit.Size = new System.Drawing.Size(6, 46);
			this.pBtnExit.TabIndex = 9;
			// 
			// bExit
			// 
			this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bExit.FlatAppearance.BorderSize = 0;
			this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bExit.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bExit.ForeColor = System.Drawing.Color.White;
			this.bExit.Image = ((System.Drawing.Image)(resources.GetObject("bExit.Image")));
			this.bExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bExit.Location = new System.Drawing.Point(6, 554);
			this.bExit.Name = "bExit";
			this.bExit.Size = new System.Drawing.Size(177, 46);
			this.bExit.TabIndex = 8;
			this.bExit.Text = "Salir";
			this.bExit.UseVisualStyleBackColor = true;
			this.bExit.Click += new System.EventHandler(this.BExitClick);
			this.bExit.MouseLeave += new System.EventHandler(this.BExitMouseLeave);
			this.bExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BExitMouseMove);
			// 
			// pBtnNotation
			// 
			this.pBtnNotation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.pBtnNotation.Location = new System.Drawing.Point(0, 183);
			this.pBtnNotation.Name = "pBtnNotation";
			this.pBtnNotation.Size = new System.Drawing.Size(6, 46);
			this.pBtnNotation.TabIndex = 7;
			// 
			// bNotation
			// 
			this.bNotation.FlatAppearance.BorderSize = 0;
			this.bNotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bNotation.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bNotation.ForeColor = System.Drawing.Color.White;
			this.bNotation.Image = ((System.Drawing.Image)(resources.GetObject("bNotation.Image")));
			this.bNotation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bNotation.Location = new System.Drawing.Point(6, 183);
			this.bNotation.Name = "bNotation";
			this.bNotation.Size = new System.Drawing.Size(177, 46);
			this.bNotation.TabIndex = 6;
			this.bNotation.Text = "Notacion";
			this.bNotation.UseVisualStyleBackColor = true;
			this.bNotation.Click += new System.EventHandler(this.BNotationClick);
			this.bNotation.MouseLeave += new System.EventHandler(this.BNotationMouseLeave);
			this.bNotation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BNotationMouseMove);
			// 
			// pBtnRecord
			// 
			this.pBtnRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.pBtnRecord.Location = new System.Drawing.Point(0, 287);
			this.pBtnRecord.Name = "pBtnRecord";
			this.pBtnRecord.Size = new System.Drawing.Size(6, 46);
			this.pBtnRecord.TabIndex = 5;
			// 
			// bRecord
			// 
			this.bRecord.FlatAppearance.BorderSize = 0;
			this.bRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bRecord.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bRecord.ForeColor = System.Drawing.Color.White;
			this.bRecord.Image = ((System.Drawing.Image)(resources.GetObject("bRecord.Image")));
			this.bRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bRecord.Location = new System.Drawing.Point(6, 287);
			this.bRecord.Name = "bRecord";
			this.bRecord.Size = new System.Drawing.Size(177, 46);
			this.bRecord.TabIndex = 4;
			this.bRecord.Text = "Record";
			this.bRecord.UseVisualStyleBackColor = true;
			this.bRecord.Click += new System.EventHandler(this.BRecordClick);
			this.bRecord.MouseLeave += new System.EventHandler(this.BRecordMouseLeave);
			this.bRecord.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BRecordMouseMove);
			// 
			// pBtnRules
			// 
			this.pBtnRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.pBtnRules.Location = new System.Drawing.Point(0, 235);
			this.pBtnRules.Name = "pBtnRules";
			this.pBtnRules.Size = new System.Drawing.Size(6, 46);
			this.pBtnRules.TabIndex = 3;
			// 
			// bRules
			// 
			this.bRules.FlatAppearance.BorderSize = 0;
			this.bRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bRules.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bRules.ForeColor = System.Drawing.Color.White;
			this.bRules.Image = ((System.Drawing.Image)(resources.GetObject("bRules.Image")));
			this.bRules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bRules.Location = new System.Drawing.Point(6, 235);
			this.bRules.Name = "bRules";
			this.bRules.Size = new System.Drawing.Size(177, 46);
			this.bRules.TabIndex = 2;
			this.bRules.Text = "Reglas";
			this.bRules.UseVisualStyleBackColor = true;
			this.bRules.Click += new System.EventHandler(this.BRulesClick);
			this.bRules.MouseLeave += new System.EventHandler(this.BRulesMouseLeave);
			this.bRules.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BRulesMouseMove);
			// 
			// pBtnPlay
			// 
			this.pBtnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.pBtnPlay.Location = new System.Drawing.Point(0, 131);
			this.pBtnPlay.Name = "pBtnPlay";
			this.pBtnPlay.Size = new System.Drawing.Size(6, 46);
			this.pBtnPlay.TabIndex = 1;
			// 
			// bPlay
			// 
			this.bPlay.FlatAppearance.BorderSize = 0;
			this.bPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bPlay.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bPlay.ForeColor = System.Drawing.Color.White;
			this.bPlay.Image = ((System.Drawing.Image)(resources.GetObject("bPlay.Image")));
			this.bPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bPlay.Location = new System.Drawing.Point(6, 131);
			this.bPlay.Name = "bPlay";
			this.bPlay.Size = new System.Drawing.Size(177, 46);
			this.bPlay.TabIndex = 0;
			this.bPlay.Text = "Jugar";
			this.bPlay.UseVisualStyleBackColor = true;
			this.bPlay.Click += new System.EventHandler(this.BPlayClick);
			this.bPlay.MouseLeave += new System.EventHandler(this.BPlayMouseLeave);
			this.bPlay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BPlayMouseMove);
			// 
			// pTittle
			// 
			this.pTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.pTittle.Controls.Add(this.lblTime);
			this.pTittle.Dock = System.Windows.Forms.DockStyle.Top;
			this.pTittle.Location = new System.Drawing.Point(183, 0);
			this.pTittle.Name = "pTittle";
			this.pTittle.Size = new System.Drawing.Size(777, 30);
			this.pTittle.TabIndex = 1;
			this.pTittle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PTittleMouseDown);
			// 
			// lblTime
			// 
			this.lblTime.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblTime.ForeColor = System.Drawing.Color.White;
			this.lblTime.Location = new System.Drawing.Point(578, 4);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(196, 23);
			this.lblTime.TabIndex = 0;
			// 
			// pMainPanel
			// 
			this.pMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMainPanel.Location = new System.Drawing.Point(183, 30);
			this.pMainPanel.Name = "pMainPanel";
			this.pMainPanel.Size = new System.Drawing.Size(777, 570);
			this.pMainPanel.TabIndex = 2;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// timerDate
			// 
			this.timerDate.Enabled = true;
			this.timerDate.Tick += new System.EventHandler(this.TimerDateTick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(960, 600);
			this.Controls.Add(this.pMainPanel);
			this.Controls.Add(this.pTittle);
			this.Controls.Add(this.pLateralMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Zenerala";
			this.pLateralMenu.ResumeLayout(false);
			this.pTittle.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel pBtnExit;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Button bExit;
		private System.Windows.Forms.Button bRecord;
		private System.Windows.Forms.Button bRules;
		private System.Windows.Forms.Panel pBtnRules;
		private System.Windows.Forms.Panel pBtnRecord;
		private System.Windows.Forms.Button bNotation;
		private System.Windows.Forms.Panel pBtnNotation;
		private System.Windows.Forms.Panel pBtnPlay;
		private System.Windows.Forms.Button bPlay;
		private System.Windows.Forms.Panel pMainPanel;
		private System.Windows.Forms.Panel pTittle;
		private System.Windows.Forms.Panel pLateralMenu;
		private System.Windows.Forms.Timer timerDate;
	}
}
