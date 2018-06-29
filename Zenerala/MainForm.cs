/*
 * Creado por SharpDevelop.
 * Usuario: S.Otero
 * Fecha: 6/7/2018
 * Hora: 7:54 AM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Zenerala
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		int PartidaEnJuego = 0;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			HidePanelButton();
		}
		

		//PARA MOVER VENTANA
		[DllImport("user32.DLL",EntryPoint="ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL",EntryPoint="SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lpParam );
		
		private void OpenSubForm(object subForm)
		{
			if ( this.pMainPanel.Controls.Count > 0)
				this.pMainPanel.Controls.RemoveAt(0);
			
			Form sForm = subForm as Form;
			sForm.TopLevel = false;
			sForm.Dock = DockStyle.Fill;
			this.pMainPanel.Controls.Add(sForm);
			this.pMainPanel.Tag = sForm;
			sForm.Show();
		}
		
		//EVENTS CLICK BUTTON -----------------------------------------------
		void BPlayClick(object sender, EventArgs e)
		{
			/*if (pLateralMenu.Width == 183)
			{
				pLateralMenu.Width = 47;
				lblTime.Left += 136;
			}	
			else
			{
				pLateralMenu.Width = 183;
				lblTime.Left -= 136;
			}*/
			if (PartidaEnJuego == 0)
			{
				OpenSubForm(new FormPlayGame());
				PartidaEnJuego = 1;
				pLateralMenu.Width = 47;
				lblTime.Left += 136;
			}
			else
			{
				DialogResult result;
				result = MessageBox.Show("¿Desea comenzar un nuevo juego?","Nuevo Juego",MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					OpenSubForm(new FormPlayGame());
					PartidaEnJuego = 1;
					pLateralMenu.Width = 47;
					lblTime.Left += 136;
				}
				         
			}
				
			
			//bPlay.Enabled = false;
		}
		
		void BRulesClick(object sender, EventArgs e)
		{
			OpenSubForm(new FormRules());
		}
		
		void BNotationClick(object sender, EventArgs e)
		{
			OpenSubForm(new FormNotation());
		}
		
		void BRecordClick(object sender, EventArgs e)
		{
			OpenSubForm(new FormRecord());
		}

		void BExitClick(object sender, EventArgs e)
		{
			//if (DialogResult == MessageBox.Show("¿Esta seguro que desea salir?","", MessageBoxButtons.YesNo))
				this.Close();
			
			//this.Close();
		}
		
		//FUNCTION HIDE PANEL BUTTON
		void HidePanelButton()
		{
			pBtnRules.Visible = false;
			pBtnNotation.Visible = false;
			pBtnPlay.Visible = false;
			pBtnRecord.Visible = false;
			pBtnExit.Visible = false;
		}
		
		//EVENTS OVER BUTTON
		void BPlayMouseMove(object sender, MouseEventArgs e)
		{
			pBtnPlay.Visible = true;
		}
		
		void BNotationMouseMove(object sender, MouseEventArgs e)
		{
			pBtnNotation.Visible = true;
		}
		
		void BRulesMouseMove(object sender, MouseEventArgs e)
		{
			pBtnRules.Visible = true;
		}
		
		void BRecordMouseMove(object sender, MouseEventArgs e)
		{
			pBtnRecord.Visible = true;
		}
		
		void BExitMouseMove(object sender, MouseEventArgs e)
		{
			pBtnExit.Visible = true;
		}
		
		
		//EVENTS LEAVE BUTTON
		void BPlayMouseLeave(object sender, EventArgs e)
		{
			HidePanelButton();
		}
		
		void BNotationMouseLeave(object sender, EventArgs e)
		{
			HidePanelButton();
		}
		
		void BRulesMouseLeave(object sender, EventArgs e)
		{
			HidePanelButton();
		}
		
		void BRecordMouseLeave(object sender, EventArgs e)
		{
			HidePanelButton();
		}
		
		void BExitMouseLeave(object sender, EventArgs e)
		{
			HidePanelButton();
		}
		
		void PTittleMouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle,0x112,0xf012,0);
		}
		
		//VER LOS TIME TICK
		void Timer1Tick(object sender, EventArgs e)
		{
			//lblTime.Text = DateTime.Now.ToString();
		}
		void TimerDateTick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString();
		}
	}
}
