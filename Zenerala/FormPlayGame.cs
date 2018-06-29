/*
 * Creado por SharpDevelop.
 * Usuario: S.Otero
 * Fecha: 6/7/2018
 * Hora: 12:44 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Zenerala
{
	/// <summary>
	/// Description of FormPlayGame.
	/// </summary>
	public partial class FormPlayGame : Form
	{
		//CREA MESA DE JUEGO
		public ClassTable TableGame = new ClassTable();
		//CREA CUBILETE CON DADOS
		public ClassDiceShaker DiceShaker = new ClassDiceShaker();
		//JUGADAS POSIBLES
		public ClassMoveAvailable MoveAvailable = new ClassMoveAvailable();
		//LISTA DE JUGADORES
		public List<ClassPlayer> lstPlayer = new List<ClassPlayer>();
		//
		int currentPlayer = 1;
		int numberTurn = 1;
		int numberRound = 1;
		
		public FormPlayGame()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			pGame.SendToBack();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		int numbrePlayers;
		
		void Pb2PlayersClick(object sender, EventArgs e)
		{
			pPlayers.BringToFront();
			numbrePlayers = 2;
			CreatePlayers();  
		}
		
		void CreatePlayers()
		{
			dgvPuntuation.ColumnCount = numbrePlayers+1;
			dgvPuntuation.RowCount = 13;
			for (int i=0 ; i<numbrePlayers ; i++)
			{
				FormCreatePlayer CreatePlayer = new FormCreatePlayer();
				if (CreatePlayer.ShowDialog() == DialogResult.OK)
				{
					string name = CreatePlayer.Nombre;
					ClassPlayer player = new ClassPlayer(name);
					lstPlayer.Add(player);
					//crear puntuacion y agregarselo
					dgvPuntuation.Rows[0].Cells[i+1].Value = name;
				}	
			}
			
			//datos tabla puntuacion
			dgvPuntuation.Rows[0].Cells[0].Value = "Jugadas";
			dgvPuntuation.Rows[1].Cells[0].Value = "Uno";
			dgvPuntuation.Rows[2].Cells[0].Value = "Dos";
			dgvPuntuation.Rows[3].Cells[0].Value = "Tres";
			dgvPuntuation.Rows[4].Cells[0].Value = "Cuatro";
			dgvPuntuation.Rows[5].Cells[0].Value = "Cinco";
			dgvPuntuation.Rows[6].Cells[0].Value = "Seis";
			dgvPuntuation.Rows[7].Cells[0].Value = "Escalera";
			dgvPuntuation.Rows[8].Cells[0].Value = "Full";
			dgvPuntuation.Rows[9].Cells[0].Value = "Poker";
			dgvPuntuation.Rows[10].Cells[0].Value = "Generala";
			dgvPuntuation.Rows[11].Cells[0].Value = "Generala D";
			dgvPuntuation.Rows[12].Cells[0].Value = "Puntuacion";
			//dgvPuntuation.Columns(0).Width = 30;
			//dgvPuntuation.RowHeadersWidth = 60;
			
			pPlayers.SendToBack();
			
			RefreshGameScreen();
				
			//Load Currente Player & Current Turn
			RefreshHeader();
		}
		
		void RefreshHeader()
		{
			lblCurrentPlayer.Text = "Jugador Actual: "+lstPlayer[currentPlayer-1].Nombre+".";
			lblTurn.Text ="Tirada "+numberTurn.ToString();
		}
		
		void RefreshGameScreen()
		{
			//RESET BUTTONS TO CLICK MOVE
			btnMoves1.Visible = false;
			btnMoves2.Visible = false;
			btnMoves3.Visible = false;
			btnMoves4.Visible = false;
			btnMoves5.Visible = false;
			btnMoves6.Visible = false;
			
			btnDice1.Enabled = false;
			btnDice2.Enabled = false;
			btnDice3.Enabled = false;
			btnDice4.Enabled = false;
			btnDice5.Enabled = false;
			
			btnDice1.Visible = false;
			btnDice2.Visible = false;
			btnDice3.Visible = false;
			btnDice4.Visible = false;
			btnDice5.Visible = false;
		}
		
		void PbDiceShakerClick(object sender, EventArgs e)
		{
			RefreshHeader();
			numberTurn++;
				
			DiceShaker.ShakerRollDice(TableGame);
			
			//cargar dados en mesa
			btnDice1.Enabled = true;
			btnDice2.Enabled = true;
			btnDice3.Enabled = true;
			btnDice4.Enabled = true;
			btnDice5.Enabled = true;
			
			//cargar dados en mesa
			btnDice1.Visible = true;
			btnDice2.Visible = true;
			btnDice3.Visible = true;
			btnDice4.Visible = true;
			btnDice5.Visible = true;
			
			
			
			LoadDiceInTable();
			
			//cargar botoes de posibles jugadas
			MoveAvailable.fiveDices(TableGame);
			CreateBtnMoves();
			//Moves, segun el resultado de cada metodo, crea boton
			
			//GENERALA DOBLE
			
			//ALCANZADO EL TURNO 3, LOS DADOS QUEDAN INHABILITADOS. SOLO SE PUEDE
			//SELECCIONAR PUNTOS
			if (numberTurn >= 4)
			{
				btnDice1.Enabled = false;
				btnDice2.Enabled = false;
				btnDice3.Enabled = false;
				btnDice4.Enabled = false;
				btnDice5.Enabled = false;
				
				/*btnDice1.Visible = false;
				btnDice2.Visible = false;
				btnDice3.Visible = false;
				btnDice4.Visible = false;
				btnDice5.Visible = false;*/
				
				pbDiceShaker.Enabled = false;
			}

		}
		
		/// <summary>
		/// JUGAR AL 1: 2 PUNTOS
		/// JUGAR AL 6: 6 PUNTOS
		/// JUGAR A LA ESCALERA: 20
		/// JUGAR AL FULL
		/// JUGAR AL POKER
		/// JUGAR A LA GENERALA
		/// JUGAR A LA GENERALA DOBLE: 50 PUNTOS
		/// </summary>
		/// 
		void CreateBtnMoves()
		{
			//INDICA LA CANTIDAD DE BOTONES QUE SE VAN CREANDO
			int countBtn = 1;
			if (MoveAvailable.MoveOne() != 0 && lstPlayer[currentPlayer-1].Puntuation.MoveOne == 0 )
			{
				BtnMoves("Jugar al 1: ", MoveAvailable.MoveOne()*1, countBtn);
				countBtn++;
			}
			
			if (MoveAvailable.MoveTwo() != 0 && lstPlayer[currentPlayer-1].Puntuation.MoveTwo == 0 )
			{
				BtnMoves("Jugar al 2: ", MoveAvailable.MoveTwo()*2, countBtn);
				countBtn++;
			}
			
			if (MoveAvailable.MoveThree() != 0 && lstPlayer[currentPlayer-1].Puntuation.MoveThree == 0 )
			{
				BtnMoves("Jugar al 3: ", MoveAvailable.MoveThree()*3, countBtn);
				countBtn++;
			}
			
			if (MoveAvailable.MoveFour() != 0 && lstPlayer[currentPlayer-1].Puntuation.MoveFour == 0 )
			{
				BtnMoves("Jugar al 4: ", MoveAvailable.MoveFour()*4, countBtn);
				countBtn++;
			}
			
			if (MoveAvailable.MoveFive() != 0 && lstPlayer[currentPlayer-1].Puntuation.MoveFive == 0 )
			{
				BtnMoves("Jugar al 5: ", MoveAvailable.MoveFive()*5, countBtn);
				countBtn++;
			}
			
			if (MoveAvailable.MoveSix() != 0 && lstPlayer[currentPlayer-1].Puntuation.MoveSix == 0 )
			{
				BtnMoves("Jugar al 6: ", MoveAvailable.MoveSix()*6, countBtn);
				countBtn++;
			}
			/*
			if (MoveAvailable.MoveStair() != 0 && lstPlayer[currentPlayer-1].Puntuation.MoveStair == 0 )
			{
				
			}
			*/
			if (MoveAvailable.MoveFull() == true && lstPlayer[currentPlayer-1].Puntuation.MoveFull == 0 )
			{
				BtnMoves("Jugar al full: ", 30, countBtn);
			}
			
			if (MoveAvailable.MovePoker() == true && lstPlayer[currentPlayer-1].Puntuation.MovePoker == 0 )
			{
				BtnMoves("Jugar al poker: ", 40, countBtn);
			}
			
			if (MoveAvailable.MoveGenerala() == true && lstPlayer[currentPlayer-1].Puntuation.MoveGenerala == 0 )
			{
				BtnMoves("Jugar al generala: ", 50, countBtn);
			}	
		}
		
		
		//UNA VEZ QUE ANOTO PUNTUACION
		public void fin()
		{
			pbDiceShaker.Enabled = Enabled;
			//SI YA JUGARON TODOS LOS JUGADORES:
			if (lstPlayer.Count == currentPlayer)
			{
				numberRound++;
				currentPlayer = 1;
				numberTurn = 1;
			}
			else
			{
				currentPlayer++;
				numberTurn = 1;
			}
			
			//PRUBAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
			//PUT THE DICE IN SHAKER
			DiceShaker.PutDieInShaker(TableGame.lstDiceInTable[0]);
			DiceShaker.PutDieInShaker(TableGame.lstDiceInTable[1]);
			DiceShaker.PutDieInShaker(TableGame.lstDiceInTable[2]);
			DiceShaker.PutDieInShaker(TableGame.lstDiceInTable[3]);
			DiceShaker.PutDieInShaker(TableGame.lstDiceInTable[4]);
			
			//REMOVE THE DICE FROM TABLE
			TableGame.lstDiceInTable.RemoveAt(0);
			TableGame.lstDiceInTable.RemoveAt(0);
			TableGame.lstDiceInTable.RemoveAt(0);
			TableGame.lstDiceInTable.RemoveAt(0);
			TableGame.lstDiceInTable.RemoveAt(0);
			
			
			//borra jugadas y deshabilita dados
			RefreshGameScreen();
			//Load Currente Player & Current Turn
			RefreshHeader();
		}
		
		
		void BtnMoves(string game, int points, int btn)
		{
			switch (btn)
			{
				case 1: 
					btnMoves1.Visible = true;
					btnMoves1.Text = game+points.ToString()+" puntos.";
					break;
				case 2:	
					btnMoves2.Visible = true;
					btnMoves2.Text = game+points.ToString()+" puntos.";
					break;
				case 3:	
					btnMoves3.Visible = true;
					btnMoves3.Text = game+points.ToString()+" puntos.";
					break;
				case 4:	
					btnMoves4.Visible = true;
					btnMoves4.Text = game+points.ToString()+" puntos.";
					break;
				case 5:	
					btnMoves5.Visible = true;
					btnMoves5.Text = game+points.ToString()+" puntos.";
					break;
				case 6:	
					btnMoves6.Visible = true;
					btnMoves6.Text = game+points.ToString()+" puntos.";
					break;
			}
		}
		
		//LOAD EACH DICE IN THE TABLE
		void LoadDiceInTable()
		{
			//DICE 1
			try
			{
				btnDice1.Text = TableGame.lstDiceInTable[0].NumDice.ToString();
			}
			catch(Exception)
			{
				btnDice1.Enabled = false;
				btnDice1.Visible = false;
				
			}
			//DICE 2
			try
			{
				btnDice2.Text = TableGame.lstDiceInTable[1].NumDice.ToString();
			}
			catch(Exception)
			{
				btnDice2.Enabled = false;
				btnDice2.Visible = false;
			}
			
			//DICE 3
			try
			{
				btnDice3.Text = TableGame.lstDiceInTable[2].NumDice.ToString();
			}
			catch(Exception)
			{
				btnDice3.Enabled = false;
				btnDice3.Visible = false;
			}
			
			//DICE 4
			try
			{
				btnDice4.Text = TableGame.lstDiceInTable[3].NumDice.ToString();
			}
			catch(Exception)
			{
				btnDice4.Enabled = false;
				btnDice4.Visible = false;
			}
			
			//DICE 5
			try
			{
				btnDice5.Text = TableGame.lstDiceInTable[4].NumDice.ToString();
			}
			catch(Exception)
			{
				btnDice5.Enabled = false;
				btnDice5.Visible = false;
			}
		}
		
		//eventos de los dados
		//BOTONES TEMPORALES, REPRESENTAN DADOS.
		void BtnDice1Click(object sender, EventArgs e)
		{
			DiceClick(0);
		}
		
		void BtnDice2Click(object sender, EventArgs e)
		{
			DiceClick(1);
		}
		
		void BtnDice3Click(object sender, EventArgs e)
		{
			DiceClick(2);
		}
		
		void BtnDice4Click(object sender, EventArgs e)
		{
			DiceClick(3);
		}
		
		void BtnDice5Click(object sender, EventArgs e)
		{
			DiceClick(4);
		}
		
		//FUNCTION TO PASS A DICE TO THE SHAKER FROM THE TABLE
		//RECEIVE A DICE AS PARAM. 
		void DiceClick(int i)
		{
			//PUT THE DICE IN SHAKER
			DiceShaker.PutDieInShaker(TableGame.lstDiceInTable[i]);
			
			//REMOVE THE DICE FROM TABLE
			TableGame.lstDiceInTable.RemoveAt(i);
			
			//RESET BUTTONS TO CLICK MOVE
			btnMoves1.Visible = false;
			btnMoves2.Visible = false;
			btnMoves3.Visible = false;
			btnMoves4.Visible = false;
			btnMoves5.Visible = false;
			btnMoves6.Visible = false;
			
			//REFRESH THE SCREEN
			LoadDiceInTable();
		}
		
		//evetos de los movimientos
		
		
		
		void BtnMoves1Click(object sender, EventArgs e)
		{
			string moveSelected;
			moveSelected = btnMoves1.Text.ToString();
			WritePuntuation(moveSelected);
		}
		
		void BtnMoves2Click(object sender, EventArgs e)
		{
			string moveSelected;
			moveSelected = btnMoves2.Text.ToString();
			WritePuntuation(moveSelected);
		}
		
		void BtnMoves3Click(object sender, EventArgs e)
		{
			string moveSelected;
			moveSelected = btnMoves3.Text.ToString();
			WritePuntuation(moveSelected);
		}
		
		void BtnMoves4Click(object sender, EventArgs e)
		{
			string moveSelected;
			moveSelected = btnMoves4.Text.ToString();
			WritePuntuation(moveSelected);
		}
		
		void BtnMoves5Click(object sender, EventArgs e)
		{
			string moveSelected;
			moveSelected = btnMoves5.Text.ToString();
			WritePuntuation(moveSelected);
		}
		
		void BtnMoves6Click(object sender, EventArgs e)
		{
			string moveSelected;
			moveSelected = btnMoves6.Text.ToString();
			WritePuntuation(moveSelected);
		}
		
		void WritePuntuation(string moveSelected)
		{
			string[] vectorMoveSelected;
			string game, puntuation;
			
			vectorMoveSelected = moveSelected.Split(' ');
			game = vectorMoveSelected[2];
			game = game.Replace(":","");
			puntuation = vectorMoveSelected[3];
			
			
			switch(game)
			{
				case "1":
					lstPlayer[currentPlayer-1].Puntuation.MoveOne = Convert.ToInt32(puntuation);
					dgvPuntuation.Rows[1].Cells[currentPlayer].Value = puntuation;
					break;
				case "2":
					lstPlayer[currentPlayer-1].Puntuation.MoveTwo = Convert.ToInt32(puntuation);
					dgvPuntuation.Rows[2].Cells[currentPlayer].Value = puntuation;
					break;
				case "3":
					lstPlayer[currentPlayer-1].Puntuation.MoveThree = Convert.ToInt32(puntuation);
					dgvPuntuation.Rows[3].Cells[currentPlayer].Value = puntuation;
					break;
				case "4":
					lstPlayer[currentPlayer-1].Puntuation.MoveFour = Convert.ToInt32(puntuation);
					dgvPuntuation.Rows[4].Cells[currentPlayer].Value = puntuation;
					break;
				case "5":
					lstPlayer[currentPlayer-1].Puntuation.MoveFive = Convert.ToInt32(puntuation);
					dgvPuntuation.Rows[5].Cells[currentPlayer].Value = puntuation;
					break;
				case "6":
					lstPlayer[currentPlayer-1].Puntuation.MoveSix = Convert.ToInt32(puntuation);
					dgvPuntuation.Rows[6].Cells[currentPlayer].Value = puntuation;
					break;
				case "escalera":
					lstPlayer[currentPlayer-1].Puntuation.MoveStair = Convert.ToInt32(puntuation);
					dgvPuntuation.Rows[7].Cells[currentPlayer].Value = puntuation;
					break;
				case "full":
					lstPlayer[currentPlayer-1].Puntuation.MoveFull = Convert.ToInt32(puntuation);
					dgvPuntuation.Rows[8].Cells[currentPlayer].Value = puntuation;
					break;
				case "poker":
					lstPlayer[currentPlayer-1].Puntuation.MovePoker = Convert.ToInt32(puntuation);
					dgvPuntuation.Rows[9].Cells[currentPlayer].Value = puntuation;
					break;
				case "generala":
					lstPlayer[currentPlayer-1].Puntuation.MoveGenerala = Convert.ToInt32(puntuation);
					dgvPuntuation.Rows[10].Cells[currentPlayer].Value = puntuation;
					break;
				/*case "1":
					lstPlayer[currentPlayer-1].Puntuation.MoveGeneralaDoble = Convert.ToInt32(puntuation);
					break;*/
			}
			try
			{
				int asd = Convert.ToInt32(dgvPuntuation.Rows[12].Cells[currentPlayer].Value.ToString());
				asd += Convert.ToInt32(puntuation);
				dgvPuntuation.Rows[12].Cells[currentPlayer].Value = asd.ToString();
			}
			catch(Exception)
			{
				dgvPuntuation.Rows[12].Cells[currentPlayer].Value = puntuation;
			}
			
			fin();
			
		}
	}
}
