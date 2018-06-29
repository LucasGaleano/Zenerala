/*
 * Creado por SharpDevelop.
 * Usuario: S.Otero
 * Fecha: 6/8/2018
 * Hora: 11:12 AM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zenerala
{
	/// <summary>
	/// Description of FormCreatePlayer.
	/// </summary>
	public partial class FormCreatePlayer : Form
	{
		private string nombre;
		
		public FormCreatePlayer()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public string Nombre
		{
			set
			{
				nombre = value;
			}
			get
			{
				return nombre;
			}
		}
		void BtnNuevoJugadorClick(object sender, EventArgs e)
		{
			nombre = txtNewPlayer.Text.ToString();
			DialogResult = DialogResult.OK;
			this.Close();
		}
		

	}
}
