

interface Game
{
    void StartGame();
}

class GameManager : Game
{
    string[] boardPositions = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    bool player1Turn = true;
    bool player2Turn = false;



    private void DrawBoard()
    {

        Console.WriteLine("------------");
        Console.WriteLine(" " + boardPositions[0] + " | "+ boardPositions[1] +" | " + boardPositions[2] );
        Console.WriteLine("------------");
        Console.WriteLine(" " + boardPositions[3] + " | " + boardPositions[4] + " | " + boardPositions[5]);
        Console.WriteLine("------------");
        Console.WriteLine(" " + boardPositions[6] + " | " + boardPositions[7] + " | " + boardPositions[8]);
        Console.WriteLine("------------");



    }


    private void SelectRegion()
    {
        bool BusyRegion = false;
        int RegionSelected = -1;
        do
        {

            Console.WriteLine("Seleccione la region donde desea pintar : ");
            try
            {
                RegionSelected = int.Parse(Console.ReadLine());
                if (RegionSelected > 0 && RegionSelected <= 9)
                {
                    if (boardPositions[RegionSelected - 1] == "X" || boardPositions[RegionSelected - 1] == "0")
                    {
                        Console.WriteLine("Invalid Position ~ ");
                        BusyRegion = true;
                    }
                    else
                    {
                        if (player1Turn)
                            boardPositions[RegionSelected-1] = "0";
                        else
                            boardPositions[RegionSelected-1] = "X";

                        BusyRegion = false;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Position");
                    BusyRegion = true;
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                BusyRegion = false;
            }


        } while (BusyRegion);



    }


    private void ChangePlayer()
    {

        if(player1Turn)
        {
            player2Turn = true;
            player1Turn = false;
        }
        else if (player2Turn)
        {
            player2Turn = false ;
            player1Turn = true;
        }


    }


    private void StartTurn()
    {

        SelectRegion();
        ChangePlayer();



    }


    private bool CheckWinner()
    {
        String Character = "X";
        for (int i = 0; i < 2; i++)
        {
            if (boardPositions[0] == Character && boardPositions[1] == Character && boardPositions[2] == Character) // victoria horizontales
                return true;
            else if (boardPositions[3] == Character && boardPositions[4] == Character && boardPositions[5] == Character)
                return true;
            else if (boardPositions[6] == Character && boardPositions[7] == Character && boardPositions[8] == Character)
                return true;
            else if (boardPositions[0] == Character && boardPositions[4] == Character && boardPositions[8] == Character) // Victoria en cruz
                return true;
            else if (boardPositions[2] == Character && boardPositions[4] == Character && boardPositions[6] == Character)
                return true;
            else if (boardPositions[0] == Character && boardPositions[3] == Character && boardPositions[6] == Character) 
                return true;
            else if (boardPositions[1] == Character && boardPositions[4] == Character && boardPositions[7] == Character)
                return true;
            else if (boardPositions[2] == Character && boardPositions[5] == Character && boardPositions[8] == Character)
                return true;



                Character = "0";
        }
        return false;


    }

    private bool CheckTie()
    {
        foreach(string position in boardPositions)
        {
            if(position != "X" && position != "0")
                return false;
        }



        return true;

    }


    public void StartGame()
    {
        Console.WriteLine("Starting the game !! ");
        bool HasFinished = false;
        bool HasTie = false;


        while (!HasFinished && !HasTie)
        {
            DrawBoard();
            StartTurn();
            HasFinished = CheckWinner();
            HasTie = CheckTie();
            Console.Clear();

        }

        if(HasTie)
        {
            Console.WriteLine("Partido empatado");
        }
        else if (HasFinished)
        {
            if(!player1Turn)
            {
                Console.WriteLine("Jugador 1 Gano");
            }else
            {
                Console.WriteLine("Jugador 2 Gano");
            }
        }




    }








}



/*
 * 
Prefijos y miembros ✅
Asignaciones mentales ✅
Nombres de clases -> ✅
Nombres de métodos -> ✅
No exceder el atractivo ✅
Abreviaturas y simetrías ✅
 
 */
class C_Connect
{
    string[] V_Pos = { "1", "2", "3", "4", "5", "6", "7", "8", "9" }; // Positions on the board
    bool p1 = true; 
    bool p2 = false;



    private void M_DrwTbl()
    {

        Console.WriteLine("------------");
        Console.WriteLine(" " + V_Pos[0] + " | " + V_Pos[1] + " | " + V_Pos[2]);
        Console.WriteLine("------------");
        Console.WriteLine(" " + V_Pos[3] + " | " + V_Pos[4] + " | " + V_Pos[5]);
        Console.WriteLine("------------");
        Console.WriteLine(" " + V_Pos[6] + " | " + V_Pos[7] + " | " + V_Pos[8]);
        Console.WriteLine("------------");



    }


    private void M_SlctReg()
    {
        bool BusyRegion = false;
        int RegionSelected = -1;
        do
        {

            Console.WriteLine("Seleccione la region donde desea pintar : ");
            try
            {
                RegionSelected = int.Parse(Console.ReadLine());
                if (RegionSelected > 0 && RegionSelected <= 9)
                {
                    if (V_Pos[RegionSelected - 1] == "X" || V_Pos[RegionSelected - 1] == "0")
                    {
                        Console.WriteLine("Invalid Position ~ ");
                        BusyRegion = true;
                    }
                    else
                    {
                        if (p1)
                            V_Pos[RegionSelected - 1] = "0";
                        else
                            V_Pos[RegionSelected - 1] = "X";

                        BusyRegion = false;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Position");
                    BusyRegion = true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                BusyRegion = false;
            }


        } while (BusyRegion);



    }





    private void StartTurn_And_ChangePlayer()
    {

        M_SlctReg();
   

        if (p1)
        {
            p2 = true;
            p1 = false;
        }
        else if (p2)
        {
            p2 = false;
            p1 = true;
        }



    }


    private bool CheckQuienEsQueso()
    {
        String Character = "X";
        for (int i = 0; i < 2; i++)
        {
            if (V_Pos[0] == Character && V_Pos[1] == Character && V_Pos[2] == Character)
                return true;
            else if (V_Pos[3] == Character && V_Pos[4] == Character && V_Pos[5] == Character)
                return true;
            else if (V_Pos[6] == Character && V_Pos[7] == Character && V_Pos[8] == Character)
                return true;
            else if (V_Pos[0] == Character && V_Pos[4] == Character && V_Pos[8] == Character)
                return true;
            else if (V_Pos[2] == Character && V_Pos[4] == Character && V_Pos[6] == Character)
                return true;

            Character = "0";
        }
        return false;


    }

    private bool M_ChckTie()
    {
        foreach (string position in V_Pos)
        {
            if (position != "X" && position != "0")
                return false;
        }



        return true;

    }


    public void S()
    {
        Console.WriteLine("Starting the game !! ");


        while (true)
        {
            M_DrwTbl();
            StartTurn_And_ChangePlayer();
            Console.Clear();


            if (M_ChckTie())
            {
                Console.WriteLine("Partido empatado");
                break;
            }
            else if (CheckQuienEsQueso())
            {
                if (!p1)
                {
                    Console.WriteLine("Jugador 1 Gano");
                    break;

                }
                else
                {
                    Console.WriteLine("Jugador 2 Gano");
                    break;

                }
            }



        }





    }










}

class MainClass
{



    public static void Main(string[] args)
    {

        GameManager GameManager = new GameManager();

        GameManager.StartGame();







    }


}