/*
 * Creado por SharpDevelop.
 * Usuario: S.Otero
 * Fecha: 6/8/2018
 * Hora: 8:55 AM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Zenerala
{
	/// <summary>
	/// Description of ClassPlayer.
	/// </summary>
	public class ClassPlayer
	{
		int numberMoves = 11;
		int numberTurn = 1;
		private string nombre;
		public ClassPuntuation Puntuation = new ClassPuntuation();
		
		public ClassPlayer(string x)
		{
			Nombre = x;
		}
		
		public string Nombre
		{
			get
			{
				return nombre;
			}
			set
			{
				nombre = value;
			}
		}
		
		public int NumberTurn
		{
			get
			{
				return numberTurn;
			}
			set
			{
				numberTurn = value;
			}
		}
		

		
	}
}
