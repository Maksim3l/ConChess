using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okay_serious_stuff
{
    class Board
    {
        public string colour;
        public string defcolour;
        public string permpos;
        

        public Board(string colour, string defcolour, string permpos)
        {
            this.colour = colour;
            this.defcolour = defcolour;
            this.permpos = permpos;
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public string Defcolour
        {
            get { return defcolour; }
            set { defcolour = value; }
        }
        public string PermPos
        {
            get { return permpos; }
            set { permpos = value; }
        }
        
    }

    class Piece
    {
        public string type;
        public string startPos;
        public string currentPos;
        public string pieceColour;

        public Piece(string type, string startPos, string CurrentPos, string PieceColour)
        {
            this.type = type;
            this.startPos = startPos;
            this.currentPos = CurrentPos;
            this.pieceColour = PieceColour;
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string StartPos
        {
            get { return startPos; }
            set { startPos = value; }
        }
        public string CurrentPos
        {
            get { return currentPos; }
            set { currentPos = value; }
        }
        public string PieceColour
        {
            get { return pieceColour; }
            set { pieceColour = value; }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            //array for class
            List<Piece> BoardPieces = new List<Piece>();
            BoardPieces.Add(new Piece("Rook1", "A1", "A1", "Magenta"));
            BoardPieces.Add(new Piece("Rook2", "H1", "H1", "DMagenta"));
            BoardPieces.Add(new Piece("Knight1", "B1", "B1", "Cyan"));
            BoardPieces.Add(new Piece("Knight2", "G1", "G1", "DCyan"));
            BoardPieces.Add(new Piece("Bishop1", "C1", "C1", "Green"));
            BoardPieces.Add(new Piece("Bishop2", "F1", "F1", "DGreen"));
            BoardPieces.Add(new Piece("Queen", "D1", "D1", "Yellow"));
            BoardPieces.Add(new Piece("King", "E1", "E1", "DYellow"));
            BoardPieces.Add(new Piece("Pawn1", "A2", "A2", "Blue"));
            BoardPieces.Add(new Piece("Pawn2", "B2", "B2", "DBlue"));
            BoardPieces.Add(new Piece("Pawn3", "C2", "C2", "Red"));
            BoardPieces.Add(new Piece("Pawn4", "D2", "D2", "DRed"));
            BoardPieces.Add(new Piece("Pawn5", "E2", "E2", "Gray"));
            BoardPieces.Add(new Piece("Pawn6", "F2", "F2", "DGray"));
            BoardPieces.Add(new Piece("Pawn7", "G2", "G2", "Yellow"));
            BoardPieces.Add(new Piece("Pawn8", "H2", "H2", "DYellow"));

            List<string> OccupiedPos = new List<string>();
            foreach (var opiece in BoardPieces)
            {
                string x = opiece.CurrentPos;
                OccupiedPos.Add(x);
            }
            List<Board> EntireBoard = new List<Board>();

            EntireBoard.Add(new Board("White", "White", "A1"));
            EntireBoard.Add(new Board("Black", "Black", "B1"));
            EntireBoard.Add(new Board("White", "White", "C1"));
            EntireBoard.Add(new Board("Black", "Black", "D1"));
            EntireBoard.Add(new Board("White", "White", "E1"));
            EntireBoard.Add(new Board("Black", "Black", "F1"));
            EntireBoard.Add(new Board("White", "White", "G1"));
            EntireBoard.Add(new Board("Black", "Black", "H1"));

            EntireBoard.Add(new Board("Black", "Black", "A2"));
            EntireBoard.Add(new Board("White", "White", "B2"));
            EntireBoard.Add(new Board("Black", "Black", "C2"));
            EntireBoard.Add(new Board("White", "White", "D2"));
            EntireBoard.Add(new Board("Black", "Black", "E2"));
            EntireBoard.Add(new Board("White", "White", "F2"));
            EntireBoard.Add(new Board("Black", "Black", "G2"));
            EntireBoard.Add(new Board("White", "White", "H2"));

            EntireBoard.Add(new Board("White", "White", "A3"));
            EntireBoard.Add(new Board("Black", "Black", "B3"));
            EntireBoard.Add(new Board("White", "White", "C3"));
            EntireBoard.Add(new Board("Black", "Black", "D3"));
            EntireBoard.Add(new Board("White", "White", "E3"));
            EntireBoard.Add(new Board("Black", "Black", "F3"));
            EntireBoard.Add(new Board("White", "White", "G3"));
            EntireBoard.Add(new Board("Black", "Black", "H3"));

            EntireBoard.Add(new Board("Black", "Black", "A4"));
            EntireBoard.Add(new Board("White", "White", "B4"));
            EntireBoard.Add(new Board("Black", "Black", "C4"));
            EntireBoard.Add(new Board("White", "White", "D4"));
            EntireBoard.Add(new Board("Black", "Black", "E4"));
            EntireBoard.Add(new Board("White", "White", "F4"));
            EntireBoard.Add(new Board("Black", "Black", "G4"));
            EntireBoard.Add(new Board("White", "White", "H4"));

            EntireBoard.Add(new Board("White", "White", "A5"));
            EntireBoard.Add(new Board("Black", "Black", "B5"));
            EntireBoard.Add(new Board("White", "White", "C5"));
            EntireBoard.Add(new Board("Black", "Black", "D5"));
            EntireBoard.Add(new Board("White", "White", "E5"));
            EntireBoard.Add(new Board("Black", "Black", "F5"));
            EntireBoard.Add(new Board("White", "White", "G5"));
            EntireBoard.Add(new Board("Black", "Black", "H5"));

            EntireBoard.Add(new Board("Black", "Black", "A6"));
            EntireBoard.Add(new Board("White", "White", "B6"));
            EntireBoard.Add(new Board("Black", "Black", "C6"));
            EntireBoard.Add(new Board("White", "White", "D6"));
            EntireBoard.Add(new Board("Black", "Black", "E6"));
            EntireBoard.Add(new Board("White", "White", "F6"));
            EntireBoard.Add(new Board("Black", "Black", "G6"));
            EntireBoard.Add(new Board("White", "White", "H6"));

            EntireBoard.Add(new Board("White", "White", "A7"));
            EntireBoard.Add(new Board("Black", "Black", "B7"));
            EntireBoard.Add(new Board("White", "White", "C7"));
            EntireBoard.Add(new Board("Black", "Black", "D7"));
            EntireBoard.Add(new Board("White", "White", "E7"));
            EntireBoard.Add(new Board("Black", "Black", "F7"));
            EntireBoard.Add(new Board("White", "White", "G7"));
            EntireBoard.Add(new Board("Black", "Black", "H7"));

            EntireBoard.Add(new Board("Black", "Black", "A8"));
            EntireBoard.Add(new Board("White", "White", "B8"));
            EntireBoard.Add(new Board("Black", "Black", "C8"));
            EntireBoard.Add(new Board("White", "White", "D8"));
            EntireBoard.Add(new Board("Black", "Black", "E8"));
            EntireBoard.Add(new Board("White", "White", "F8"));
            EntireBoard.Add(new Board("Black", "Black", "G8"));
            EntireBoard.Add(new Board("White", "White", "H8"));

            int NumberOfIterations = 0;
            bool PieceSelected = false;
            string PieceType = "";
            string PieceTypeN = "";
            string PiecePos = "";
            string colourFromPiece = "";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello welcome to Maksim's console chesspiece simulator!~\nEnjoy your stay!");
            List<string> PossiblePosList = new List<string>();

            
            bool AllowedMove = false;
            for (bool Finsih = false; Finsih != true;)
            {
                for (; PieceSelected != true;)
                {
                    
                    FirstMenue();
                    
                    PieceTypeN = Console.ReadLine();
                    PieceType = PieceTypeN.Remove(PieceTypeN.Length - 1, 1);

                    foreach (var boardType in BoardPieces)
                    {
                        if (boardType.Type == PieceTypeN)
                        {
                            PieceSelected = true;
                            colourFromPiece = boardType.PieceColour;
                        }
                    }
                    Console.Clear();
                }

                foreach (var Spiece in BoardPieces)
                {
                    if (Spiece.Type == PieceTypeN) PiecePos = Spiece.CurrentPos;
                }

                if (PieceType == "Rook")
                {
                    RookPos(PiecePos, ref PossiblePosList, ref OccupiedPos);
                }

                if (PieceType == "Pawn")
                {

                    PawnPos(PiecePos, ref PossiblePosList, ref OccupiedPos);
                }


                for (; AllowedMove != true;)
                {
                    NumberOfIterations++;
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    foreach (string part in PossiblePosList)
                    {
                        Console.Write($"{part} ");
                    }

                    Console.WriteLine("\n");

                    if (NumberOfIterations == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Please choose a position to move to from the table above,\nenter a chess letter(A-H) and number(1-8)\nIf you want to select another chess piece, then write '/' \nfor example: H1\n");
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Your current possision is: {0}", PiecePos);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string NewPos = Console.ReadLine();
                    if (NewPos == "/") { PieceSelected = false; break; };
                    Console.WriteLine("");

                    foreach (string APos in PossiblePosList)
                    {
                        if (NewPos == APos)
                        {
                            PiecePos = NewPos;
                            
                            foreach (var piece in BoardPieces)
                            { 
                                if (piece.Type == PieceTypeN) piece.CurrentPos = NewPos; 
                            }
                            AllowedMove = true;
                            switch (PieceType)
                            {
                                case "Pawn":
                                    PawnPos(PiecePos, ref PossiblePosList, ref OccupiedPos);
                                    break;
                                case "Rook":
                                    RookPos(PiecePos, ref PossiblePosList, ref OccupiedPos);
                                    break;
                            }
                            break;
                        }
                    }
                }
                if (PieceSelected == false) { continue; };

                foreach (var Cpos in EntireBoard)
                {
                    foreach (var BPpos in BoardPieces)
                    {
                        if (Cpos.PermPos == BPpos.CurrentPos) { Cpos.Colour = BPpos.PieceColour; break; }
                        else if (Cpos.PermPos != BPpos.CurrentPos) { Cpos.Colour = Cpos.Defcolour; }
                    }

                    foreach (var PPos in PossiblePosList)
                    {
                        if (Cpos.PermPos == PPos) { Cpos.Colour = colourFromPiece; break; }
                    }
                }

                if (AllowedMove == true) //graphic part
                {
                    Console.Clear();
                    //colour change
                    int i = 0;
                    foreach (var Piece in EntireBoard)
                    {
                        i++;
                        switch (Piece.Colour)
                        {
                            case "Black":
                                Console.BackgroundColor = ConsoleColor.Black;
                                break;
                            case "White":
                                Console.BackgroundColor = ConsoleColor.White;
                                break;
                            case "Magenta":
                                Console.BackgroundColor = ConsoleColor.Magenta;
                                break;
                            case "Cyan":
                                Console.BackgroundColor = ConsoleColor.Cyan;
                                break;
                            case "DCyan":
                                Console.BackgroundColor = ConsoleColor.DarkCyan;
                                break;
                            case "Red":
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            case "DMagenta":
                                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                break;
                            case "DRed":
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                break;
                            case "Blue":
                                Console.BackgroundColor = ConsoleColor.Blue;
                                break;
                            case "DBlue":
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                break;
                            case "Green":
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            case "DGreen":
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                break;
                            case "Yellow":
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                break;
                            case "DYellow":
                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                                break;
                            case "Gray":
                                Console.BackgroundColor = ConsoleColor.Gray;
                                break;
                            case "DGray":
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                break;
                            case "0":
                                Console.BackgroundColor = ConsoleColor.Gray;
                                break;
                            case "1":
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                break;
                        }
                        //block placement
                        Console.Write("  ");

                        //skip to next row
                        if (i % 8 == 0) Console.WriteLine("");
                        continue;
                    }
                }
                //reset
                Console.BackgroundColor = ConsoleColor.Black;
                AllowedMove = false;

                if (NumberOfIterations >= 7)
                {
                    if (NumberOfIterations == 7) Console.WriteLine("Please write 'Yes' to continue or 'No' to end\n");
                    else Console.WriteLine("Continue?");

                    string holder = Console.ReadLine();
                    if (holder == "Yes" || holder == "YES" || holder == "yes" || holder == "y" || holder == "Y") { Finsih = false; continue; }
                    else if (holder == "No" || holder == "NO" || holder == "no" || holder == "n" || holder == "N") { Finsih = true; break; }
                }
            }

            Console.ReadKey();
        }
        static void PawnPos(string PiecePos, ref List<string> PossiblePosList, ref List<string> OccupiedPos)
        {
            PossiblePosList.Clear();
            char LetterS = Convert.ToChar(PiecePos.Remove(PiecePos.Length - 1, 1));
            int NumS = Convert.ToInt32(PiecePos.Remove(0, 1));
            
            for (int i = NumS + 3; NumS != i; NumS++)
            {
                if (NumS >= 9) break;
                string PosToAdd = "";
                PosToAdd = Convert.ToString(LetterS) + Convert.ToString(NumS);
                PossiblePosList.Add(PosToAdd);
                
            }
        }
        static void RookPos(string PiecePos, ref List<string> PossiblePosList, ref List<string> OccupiedPos)
        {
            List<string> A = new List<string>();
            for (int i = 1; i <= 8; i++)
            {
                A.Add("A" + Convert.ToString(i));
            }

            List<string> B = new List<string>();
            for (int i = 1; i <= 8; i++)
            {
                B.Add("B" + Convert.ToString(i));
            }

            List<string> C = new List<string>();
            for (int i = 1; i <= 8; i++)
            {
                C.Add("C" + Convert.ToString(i));
            }

            List<string> D = new List<string>();
            for (int i = 1; i <= 8; i++)
            {
                D.Add("D" + Convert.ToString(i));
            }

            List<string> E = new List<string>();
            for (int i = 1; i <= 8; i++)
            {
                E.Add("E" + Convert.ToString(i));
            }

            List<string> F = new List<string>();
            for (int i = 1; i <= 8; i++)
            {
                F.Add("F" + Convert.ToString(i));
            }

            List<string> G = new List<string>();
            for (int i = 1; i <= 8; i++)
            {
                G.Add("G" + Convert.ToString(i));
            }

            List<string> H = new List<string>();
            for (int i = 1; i <= 8; i++)
            {
                H.Add("H" + Convert.ToString(i));
            }

            List<string> One = new List<string>();
            for (int i = 65; i <= 72; i++)
            {
                char g = Convert.ToChar(i);
                One.Add(Convert.ToString(g) + 1);
            }

            List<string> Two = new List<string>();
            for (int i = 65; i <= 72; i++)
            {
                char g = Convert.ToChar(i);
                Two.Add(Convert.ToString(g) + 2);
            }

            List<string> Three = new List<string>();
            for (int i = 65; i <= 72; i++)
            {
                char g = Convert.ToChar(i);
                Three.Add(Convert.ToString(g) + 3);
            }

            List<string> Four = new List<string>();
            for (int i = 65; i <= 72; i++)
            {
                char g = Convert.ToChar(i);
                Four.Add(Convert.ToString(g) + 4);
            }

            List<string> Five = new List<string>();
            for (int i = 65; i <= 72; i++)
            {
                char g = Convert.ToChar(i);
                Five.Add(Convert.ToString(g) + 5);
            }

            List<string> Six = new List<string>();
            for (int i = 65; i <= 72; i++)
            {
                char g = Convert.ToChar(i);
                Six.Add(Convert.ToString(g) + 6);
            }

            List<string> Seven = new List<string>();
            for (int i = 65; i <= 72; i++)
            {
                char g = Convert.ToChar(i);
                Seven.Add(Convert.ToString(g) + 7);
            }

            List<string> Eight = new List<string>();
            for (int i = 65; i <= 72; i++)
            {
                char g = Convert.ToChar(i);
                Eight.Add(Convert.ToString(g) + 8);
            }

            PossiblePosList.Clear();
            char LetterS = Convert.ToChar(PiecePos.Remove(PiecePos.Length - 1, 1));
            int NumS = Convert.ToInt32(PiecePos.Remove(0, 1));
            switch (NumS)
            {
                case 1:
                    foreach (string part in One)
                    {
                        PossiblePosList.Add(part);
                    }
                    break;
                case 2:
                    foreach (string part in Two)
                    {
                        PossiblePosList.Add(part);
                    }
                    break;
                case 3:
                    foreach (string part in Three)
                    {
                        PossiblePosList.Add(part);
                    }
                    break;
                case 4:
                    foreach (string part in Four)
                    {
                        PossiblePosList.Add(part);
                    }
                    break;
                case 5:
                    foreach (string part in Five)
                    {
                        PossiblePosList.Add(part);
                    }
                    break;
                case 6:
                    foreach (string part in Six)
                    {
                        PossiblePosList.Add(part);
                    }
                    break;
                case 7:
                    foreach (string part in Seven)
                    {
                        PossiblePosList.Add(part);
                    }
                    break;
                case 8:
                    foreach (string part in Eight)
                    {
                        PossiblePosList.Add(part);
                    }
                    break;
            }
            switch (char.ToUpper(LetterS))
            {
                case 'A':
                    foreach (string part in A)
                    {
                        PossiblePosList.Add(part);
                    }
                    break;
                case 'B':
                    foreach (string part in B)
                    {
                        PossiblePosList.Add(part);
                    }
                    break;
                case 'C':
                    foreach (string part in C)
                    {
                        PossiblePosList.Add(part);
                    }
                    break;
                case 'D':
                    foreach (string part in D)
                    {
                        PossiblePosList.Add(part);
                    }
                    break;
                case 'E':
                    foreach (string part in E)
                    {
                        PossiblePosList.Add(part);
                    }
                    break;
                case 'F':
                    foreach (string part in F)
                    {
                        PossiblePosList.Add(part);
                    }
                    break;
                case 'G':
                    foreach (string part in G)
                    {
                        PossiblePosList.Add(part);
                    }
                    break;
                case 'H':
                    foreach (string part in H)
                    {
                        PossiblePosList.Add(part);
                    }
                    break;
            }
        }

        static void BishopPos(string PiecePos, ref List<string> PossiblePosList, ref List<string> OccupiedPos)
        {

        } //not finished

        static void Queen (string PiecePos, ref List<string> PossiblePosList, ref List<string> OccupiedPos)
        {

        }//not finished

        static void FirstMenue()
        {
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPlease choose from the following:\n");
            Console.WriteLine("\n\tRook1(left),\tRook2(right),\n" +
                "\n\tKnight1(left),\tKnight2(right),\n" +
                "\n\tBishop1(left),\tBishop2(right),\n" +
                "\n\tQueen(left),\tKing(right),\n" +
                "\n\tPawn1,\t\tPawn2,\n" +
                "\n\tPawn3,\t\tPawn4,\n" +
                "\n\tPawn5,\t\tPawn6,\n" +
                "\n\tPawn7,\t\tPawn8,\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

/*
  A  B  C  D  E  F  G  H
1 A1 B1 C1 D1 E1 F1 G1 H1   
2 A2 B2 C2 D2 E2 F2 G2 H2 
3 A3 B3 C3 D3 E3 F3 G3 H3 
4 A4 B4 C4 D4 E4 F4 G4 H4 
5 A5 B5 C5 D5 E5 F5 G5 H5 
6 A6 B6 C6 D6 E6 F6 G6 H6
7 A7 B7 C7 D7 E7 F7 G7 H7 
8 A8 B8 C8 D8 E8 F8 G8 H8 


knight --> skips between a letter and a number at once npr. strat: D3; C2, C4 - E2, E4
*/
