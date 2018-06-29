/*
 * Creado por SharpDevelop.
 * Usuario: S.Otero
 * Fecha: 6/8/2018
 * Hora: 9:03 AM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Zenerala
{
	/// <summary>
	/// Description of ClassMoveAvailable.
	/// </summary>
	public class ClassMoveAvailable
	{
		int[] Amount = new int[7] {0,0,0,0,0,0,0};
		
			
		public ClassMoveAvailable()
		{
		}
		
		//OBTIENE CUANTOS NUMEROS DE CADA POSIBILIDAD SALIERON
		public void fiveDices(ClassTable Table)
		{
			for (int j = 1 ; j < 7 ; j++)
			{
				Amount[j] = 0;
			}
			
			for (int i = 1 ; i < 6 ; i++)
			{
				foreach (ClassDice x in Table.lstDiceInTable)
				{
					if (x.NumDice == i)
					{
						Amount[i]++;
					}
				}
			}
		}
		
		public int MoveOne()
		{
			return Amount[1];
		}
		
		public int MoveTwo()
		{
			return Amount[2];
		}
		
		public int MoveThree()
		{
			return Amount[3];
		}
		
		public int MoveFour()
		{
			return Amount[4];
		}
		
		public int MoveFive()
		{
			return Amount[5];
		}
		
		public int MoveSix()
		{
			return Amount[6];
		}
		
		/*public bool MoveStair()
		{
			/// <summary>
			///  12345
			///  1234 6
			///  123 56
			///  12 456
			///  1 3456
			///   23456
			/// 
			///  busca 1
			/// 	busca 
			/// sino
			/// busca 6
			///  12 345
			///   2 345 6
			///  1  345 6
			/// </summary>
			/// <returns></returns>
		}*/
		
		public bool MoveFull()
		{
			foreach (int j in Amount)
			{
				if (j == 3)
				{
					foreach (int i in Amount)
					{
						if (i == 2)
							return true;
					}
					return false;
				}
			}
			return false;
		}
		
		public bool MovePoker()
		{
			foreach (int j in Amount)
			{
				if (j == 4)
					return true;
			}
			return false;
		}
		
		public bool MoveGenerala()
		{
			foreach (int j in Amount)
			{
				if (j == 5)
					return true;
			}
			return false;
		}
	}
}
