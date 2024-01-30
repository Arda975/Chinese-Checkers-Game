using System;

namespace Checkers
{
    class Program
    {
        //box drawing method (collapse to reduce mess)
        static void DrawBox()
        {
            //box size
            byte boxwidth = 17;
            byte boxheight = 10;
            //box position
            byte boxposx = 2;
            byte boxposy = 1;
            //box border color
            var edgecolor = ConsoleColor.Black;
            var bordercolor = ConsoleColor.White;
            var boxcolor = ConsoleColor.Gray;

            //box
            {
                //draw box border
                Console.ForegroundColor = edgecolor;
                Console.BackgroundColor = bordercolor;
                Console.SetCursorPosition(boxposx, boxposy);
                Console.Write("╔");
                for (byte x = 1; x < boxwidth - 1; x++) Console.Write("═");
                Console.Write("╗");
                for (byte y = 1; y < boxheight - 1; y++)
                {
                    Console.SetCursorPosition(boxposx, y + boxposy);
                    Console.Write("║");
                    Console.SetCursorPosition(boxposx + boxwidth - 1, boxposy + y);
                    Console.Write("║");
                }
                Console.SetCursorPosition(boxposx, boxposy + boxheight - 1);
                Console.Write("╚");
                for (byte x = 1; x < boxwidth - 1; x++) Console.Write("═");
                Console.Write("╝");

                //draw box
                Console.BackgroundColor = boxcolor;
                for (byte y = 1; y < boxheight - 1; y++)
                {
                    Console.SetCursorPosition(boxposx + 1, y + boxposy);
                    for (byte x = 1; x < boxwidth - 1; x++) Console.Write(" ");
                }

                //draw box shadow
                Console.BackgroundColor = ConsoleColor.Black;
                for (byte y = 0; y < boxheight - 1; y++)
                {
                    Console.SetCursorPosition(boxwidth + boxposx, 1 + y + boxposy);
                    Console.Write(" ");
                }
                Console.SetCursorPosition(boxposx + 1, boxheight + boxposy);
                for (byte x = 0; x < boxwidth; x++) Console.Write(" ");
            }

            Console.BackgroundColor = boxcolor;
        }

        //draw info box (collapse to reduce mess)
        static void DrawInfoBox1()
        {
            //box size
            byte boxwidth = 12;
            byte boxheight = 4;
            //box position
            byte boxposx = 21;
            byte boxposy = 1;
            //box border color
            var edgecolor = ConsoleColor.Black;
            var bordercolor = ConsoleColor.White;
            var boxcolor = ConsoleColor.Gray;

            //box
            {
                //draw box border
                Console.ForegroundColor = edgecolor;
                Console.BackgroundColor = bordercolor;
                Console.SetCursorPosition(boxposx, boxposy);
                Console.Write("╔");
                for (byte x = 1; x < boxwidth - 1; x++) Console.Write("═");
                Console.Write("╗");
                for (byte y = 1; y < boxheight - 1; y++)
                {
                    Console.SetCursorPosition(boxposx, y + boxposy);
                    Console.Write("║");
                    Console.SetCursorPosition(boxposx + boxwidth - 1, boxposy + y);
                    Console.Write("║");
                }
                Console.SetCursorPosition(boxposx, boxposy + boxheight - 1);
                Console.Write("╚");
                for (byte x = 1; x < boxwidth - 1; x++) Console.Write("═");
                Console.Write("╝");

                //draw box
                Console.BackgroundColor = boxcolor;
                for (byte y = 1; y < boxheight - 1; y++)
                {
                    Console.SetCursorPosition(boxposx + 1, y + boxposy);
                    for (byte x = 1; x < boxwidth - 1; x++) Console.Write(" ");
                }

                //draw box shadow
                Console.BackgroundColor = ConsoleColor.Black;
                for (byte y = 0; y < boxheight - 1; y++)
                {
                    Console.SetCursorPosition(boxwidth + boxposx, 1 + y + boxposy);
                    Console.Write(" ");
                }
                Console.SetCursorPosition(boxposx + 1, boxheight + boxposy);
                for (byte x = 0; x < boxwidth; x++) Console.Write(" ");
            }

            Console.BackgroundColor = boxcolor;
        }

        //draw info box (collapse to reduce mess)
        static void DrawInfoBox2()
        {
            //box size
            byte boxwidth = 21;
            byte boxheight = 6;
            //box position
            byte boxposx = 21;
            byte boxposy = 6;
            //box border color
            var edgecolor = ConsoleColor.Black;
            var bordercolor = ConsoleColor.White;
            var boxcolor = ConsoleColor.Gray;

            //box
            {
                //draw box border
                Console.ForegroundColor = edgecolor;
                Console.BackgroundColor = bordercolor;
                Console.SetCursorPosition(boxposx, boxposy);
                Console.Write("╔");
                for (byte x = 1; x < boxwidth - 1; x++) Console.Write("═");
                Console.Write("╗");
                for (byte y = 1; y < boxheight - 1; y++)
                {
                    Console.SetCursorPosition(boxposx, y + boxposy);
                    Console.Write("║");
                    Console.SetCursorPosition(boxposx + boxwidth - 1, boxposy + y);
                    Console.Write("║");
                }
                Console.SetCursorPosition(boxposx, boxposy + boxheight - 1);
                Console.Write("╚");
                for (byte x = 1; x < boxwidth - 1; x++) Console.Write("═");
                Console.Write("╝");

                //draw box
                Console.BackgroundColor = boxcolor;
                for (byte y = 1; y < boxheight - 1; y++)
                {
                    Console.SetCursorPosition(boxposx + 1, y + boxposy);
                    for (byte x = 1; x < boxwidth - 1; x++) Console.Write(" ");
                }

                //draw box shadow
                Console.BackgroundColor = ConsoleColor.Black;
                for (byte y = 0; y < boxheight - 1; y++)
                {
                    Console.SetCursorPosition(boxwidth + boxposx, 1 + y + boxposy);
                    Console.Write(" ");
                }
                Console.SetCursorPosition(boxposx + 1, boxheight + boxposy);
                for (byte x = 0; x < boxwidth; x++) Console.Write(" ");
            }

            Console.BackgroundColor = boxcolor;
        }

        //draw board (collapse to reduce mess)
        static void DrawBoard(byte[,] board)
        {
            //convert byte values and display the board
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.SetCursorPosition(3 + (j * 2), 2 + i);
                    switch (board[j, i])
                    {
                        case 0:
                            Console.WriteLine(".");
                            break;
                        case 1:
                            Console.WriteLine("x");
                            break;
                        case 2:
                            Console.WriteLine("o");
                            break;
                    }
                }
            }
        }

        //draw info (collapse to reduce mess)
        static void DrawInfo()
        {
            Console.SetCursorPosition(22, 2);
            Console.Write("Round : 1");
            Console.SetCursorPosition(22, 3);
            Console.Write("Turn  : x");
            Console.SetCursorPosition(22, 7);
            Console.Write("Arrow Keys = Select");
            Console.SetCursorPosition(22, 8);
            Console.Write("Z = Select Piece");
            Console.SetCursorPosition(22, 9);
            Console.Write("X = Select Spot");
            Console.SetCursorPosition(22, 10);
            Console.Write("C = End Turn");
        }

        static void DrawVisuals(byte[,] board)
        {
            DrawInfoBox1();

            DrawInfoBox2();

            DrawInfo();

            DrawBox();

            DrawBoard(board);
        }

        static void Xwins()
        {
            Console.SetCursorPosition(22, 7);
            Console.Write("▀▄    ▄▀           ");
            Console.SetCursorPosition(22, 8);
            Console.Write("  ▀▄▄▀     Wins!");
            Console.SetCursorPosition(22, 9);
            Console.Write("  ▄▀▀▄         ");
            Console.SetCursorPosition(22, 10);
            Console.Write("▄▀    ▀▄    ");
        }

        static void Owins()
        {
            Console.SetCursorPosition(22, 7);
            Console.Write(" ▄█▀▀█▄            ");
            Console.SetCursorPosition(22, 8);
            Console.Write("█▀    ▀█   Wins!");
            Console.SetCursorPosition(22, 9);
            Console.Write("█▄    ▄█       ");
            Console.SetCursorPosition(22, 10);
            Console.Write(" ▀█▄▄█▀     ");
        }




        //move cursor (related to the board, skips the complicated math of setting cursor positions)
        static void MoveCursor(byte x, byte y)
        {
            Console.SetCursorPosition(3 + (2 * x), 2 + y);
        }

        static void MovePiece(byte x, byte y, char piece, bool color = false)
        {
            Console.Write('.');
            MoveCursor(x, y);

            //cpu move exclusive
            if (color) Console.BackgroundColor = ConsoleColor.DarkGreen;

            Console.Write(piece);
        }


        //check if movement is a good move
        static bool RightGoodMove(byte inputX, byte inputY, byte[,] board)
        {
            byte count = 0;
            if (inputX > 5)
            {
                for (byte x = inputX; x < 8; x++)
                {
                    for (byte y = 0; y < 8; y++)
                    {
                        if (board[x, y] == 2) count++;
                    }
                }


                if (inputX == 6)
                {
                    if (count > 5) return false;
                }

                if (inputX == 7)
                {
                    if (count > 2) return false;
                }
            }

            return true;
        }

        static bool DownGoodMove(byte inputX, byte inputY, byte[,] board)
        {

            byte count = 0;
            if (inputY > 5)
            {
                for (byte y = inputY; y < 8; y++)
                {
                    for (byte x = 0; x < 8; x++)
                    {
                        if (board[x, y] == 2) count++;
                    }
                }


                if (inputY == 6)
                {
                    if (count > 5) return false;
                }

                if (inputY == 7)
                {
                    if (count > 2) return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {

            

            byte cursorX = 5;
            byte cursorY = 5;

            byte SelectX = 0;
            byte SelectY = 0;

            bool playerturn = true;

            // 0 = empty
            // 1 = player 1 (user)
            // 2 = player 2 (cpu)

            byte[,] board = new byte[,]

            {
               { 2, 2, 2, 0, 0, 0, 0, 0 },
               { 2, 2, 2, 0, 0, 0, 0, 0 },
               { 2, 2, 2, 0, 0, 0, 0, 0 },
               { 0, 0, 0, 0, 0, 0, 0, 0 },
               { 0, 0, 0, 0, 0, 0, 0, 0 },
               { 0, 0, 0, 0, 0, 1, 1, 1 },
               { 0, 0, 0, 0, 0, 1, 1, 1 },
               { 0, 0, 0, 0, 0, 1, 1, 1 },
             };

            byte[,] cpupieces = {
            {0,0},
            {0,1},
            {0,2},
            {1,0},
            {1,1},
            {1,2},
            {2,0},
            {2,1},
            {2,2}
            };

            byte[] lastMovedCPUPiece = { 7, 7 };
            byte[] movableCPUPieces = new byte[8];
            byte[,] newEmptySpaces = { { 0, 0 }, { 0, 0 } };

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            DrawVisuals(board);

            bool allowMovePiece = false;
            bool suppressPieceSelection = false;

            byte spots = 0;
            byte[,] PossibleMoves = new byte[4, 2];

            byte[,] AlreadyStepped = new byte[15, 2];
            byte combocount = 0;

            //check if a coordinate is one of the tiles that are already traveled during the turn (prevents jumping back and forth in a turn)
            static bool CheckAlreadyStepped(byte x, byte y, byte combocount, byte[,] alreadyStepped)
            {
                bool o = false;
                for (byte i = 0; i < combocount;i++)
                {
                    if ((alreadyStepped[i, 0] == x) && (alreadyStepped[i, 1] == y))
                    {
                        o = true;
                        break;
                    }
                }
                return o;
            }

            

            MoveCursor(cursorX, cursorY);

            bool gameover = false;

            byte round = 1;

            while (true)
            {

                

                if (Console.KeyAvailable)
                {

                    


                    //PLAYER TURN
                    MoveCursor(cursorX, cursorY);

                    //for recording the empty space left behind
                    bool savenewemptyspace = true;

                    while (playerturn)
                    {
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.RightArrow:
                                //cursorX = cursorX + 1;
                                if (cursorX >= 7) cursorX = 0;
                                else cursorX++;
                                MoveCursor(cursorX, cursorY);
                                break;
                            case ConsoleKey.LeftArrow:
                                //key control
                                if (cursorX == 0) cursorX = 7;
                                else cursorX--;
                                MoveCursor(cursorX, cursorY);
                                break;
                            case ConsoleKey.UpArrow:
                                //key control
                                if (cursorY == 0) cursorY = 7;
                                else cursorY--;
                                MoveCursor(cursorX, cursorY);
                                break;
                            case ConsoleKey.DownArrow:
                                //key control
                                if (cursorY == 7) cursorY = 0;
                                else cursorY++;
                                MoveCursor(cursorX, cursorY);
                                break;
                            case ConsoleKey.Z: // choose piece
                                if ((!suppressPieceSelection) && (board[cursorX, cursorY] == 1))
                                {
                                    //clear possiblesteps if full
                                    if (allowMovePiece)
                                    {
                                        for (byte i = 0; i < spots; i++)
                                        {
                                            MoveCursor(PossibleMoves[i, 0], PossibleMoves[i, 1]);
                                            Console.Write('.');
                                        }

                                        MoveCursor(SelectX, SelectY);
                                        Console.Write('x');
                                    }

                                    //look for possible locations (all 4 directions) and place positions in array
                                    spots = 0;
                                    //right
                                    if (cursorX != 7) //out of range prevention
                                    {
                                        if (board[cursorX + 1, cursorY] == 0)
                                        {
                                            PossibleMoves[spots, 0] = (byte)(cursorX + 1);
                                            PossibleMoves[spots, 1] = cursorY;
                                            spots++;
                                        }

                                        //jump over check
                                        else if (cursorX != 6) //out of range prevention
                                        {
                                            if ((board[cursorX + 1, cursorY] > 0) && (board[cursorX + 2, cursorY] == 0))
                                            {
                                                PossibleMoves[spots, 0] = (byte)(cursorX + 2);
                                                PossibleMoves[spots, 1] = cursorY;
                                                spots++;
                                            }
                                        }
                                    }
                                    //down
                                    if (cursorY != 7) //out of range prevention
                                    {
                                        if (board[cursorX, cursorY + 1] == 0)
                                        {
                                            PossibleMoves[spots, 0] = cursorX;
                                            PossibleMoves[spots, 1] = (byte)(cursorY + 1);
                                            spots++;
                                        }

                                        //jump over check
                                        else if (cursorY != 6) //out of range prevention
                                        {
                                            if ((board[cursorX, cursorY + 1] > 0) && (board[cursorX, cursorY + 2] == 0))
                                            {
                                                PossibleMoves[spots, 0] = cursorX;
                                                PossibleMoves[spots, 1] = (byte)(cursorY + 2);
                                                spots++;
                                            }
                                        }
                                    }
                                    //left
                                    if (cursorX != 0) //out of range prevention
                                    {
                                        if (board[cursorX - 1, cursorY] == 0)
                                        {
                                            PossibleMoves[spots, 0] = (byte)(cursorX - 1);
                                            PossibleMoves[spots, 1] = cursorY;
                                            spots++;
                                        }

                                        //jump over check
                                        else if (cursorX != 1) //out of range prevention
                                        {
                                            if ((board[cursorX - 1, cursorY] > 0) && (board[cursorX - 2, cursorY] == 0))
                                            {
                                                PossibleMoves[spots, 0] = (byte)(cursorX - 2);
                                                PossibleMoves[spots, 1] = cursorY;
                                                spots++;
                                            }
                                        }
                                    }
                                    //up
                                    if (cursorY != 0) //out of range prevention
                                    {
                                        if (board[cursorX, cursorY - 1] == 0)
                                        {
                                            PossibleMoves[spots, 0] = cursorX;
                                            PossibleMoves[spots, 1] = (byte)(cursorY - 1);
                                            spots++;
                                        }

                                        //jump over check
                                        else if (cursorY != 1) //out of range prevention
                                        {
                                            if ((board[cursorX, cursorY - 1] > 0) && (board[cursorX, cursorY - 2] == 0))
                                            {
                                                PossibleMoves[spots, 0] = cursorX;
                                                PossibleMoves[spots, 1] = (byte)(cursorY - 2);
                                                spots++;
                                            }
                                        }
                                    }

                                    //display selected piece
                                    MoveCursor(cursorX, cursorY);
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.Write('x');

                                    //show possible steps
                                    for (byte i = 0; i < spots; i++)
                                    {
                                        MoveCursor(PossibleMoves[i, 0], PossibleMoves[i, 1]);
                                        Console.BackgroundColor = ConsoleColor.DarkRed;
                                        Console.Write('.');
                                    }

                                    Console.BackgroundColor = ConsoleColor.Gray;
                                    MoveCursor(cursorX, cursorY);

                                    if (savenewemptyspace)
                                    {
                                        newEmptySpaces[0, 0] = cursorX;
                                        newEmptySpaces[0, 1] = cursorY;
                                    }

                                    SelectX = cursorX;
                                    SelectY = cursorY;
                                    allowMovePiece = true;
                                }
                                break;
                            case ConsoleKey.X:  //move to selected square
                                if (allowMovePiece)
                                {

                                    //check if selected tile is one of the possible spots
                                    bool move = false;
                                    for (byte i = 0; i < spots; i++)
                                    {
                                        if ((PossibleMoves[i, 0] == cursorX) && (PossibleMoves[i, 1] == cursorY))
                                        {
                                            move = true;
                                            break;
                                        }
                                    }

                                    if (move)
                                    {

                                        savenewemptyspace = false;

                                        //clear possible steps from screen
                                        for (byte i = 0; i < spots; i++)
                                        {
                                            MoveCursor(PossibleMoves[i, 0], PossibleMoves[i, 1]);
                                            Console.Write('.');
                                        }

                                        //move piece
                                        MoveCursor(cursorX, cursorY);
                                        board[cursorX, cursorY] = 1;
                                        Console.Write('x');

                                        //remove previous spot
                                        MoveCursor(SelectX, SelectY);
                                        board[SelectX, SelectY] = 0;
                                        Console.Write('.');

                                        MoveCursor(cursorX, cursorY);
                                        allowMovePiece = false;

                                        suppressPieceSelection = true;

                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Console.Write('x');
                                        Console.BackgroundColor = ConsoleColor.Gray;

                                        //check jumps if move was jump
                                        if ((SelectX + cursorX + SelectY + cursorY) % 2 == 0)
                                        {

                                            //add jumped position into AlreadyStepped
                                            AlreadyStepped[combocount, 0] = SelectX;
                                            AlreadyStepped[combocount, 1] = SelectY;
                                            combocount++;



                                            spots = 0;
                                            if (cursorX < 6) //out of range prevention
                                            {
                                                if ((board[cursorX + 1, cursorY] > 0) && (board[cursorX + 2, cursorY] == 0)) //jumpable
                                                {
                                                    if (!CheckAlreadyStepped((byte)(cursorX + 2), cursorY, combocount, AlreadyStepped))
                                                    {
                                                        PossibleMoves[spots, 0] = (byte)(cursorX + 2);
                                                        PossibleMoves[spots, 1] = cursorY;
                                                        spots++;
                                                        allowMovePiece = true;
                                                    }
                                                }
                                            }
                                            if (cursorY < 6) //out of range prevention
                                            {
                                                if ((board[cursorX, cursorY + 1] > 0) && (board[cursorX, cursorY + 2] == 0)) //jumpable
                                                {
                                                    if (!CheckAlreadyStepped(cursorX, (byte)(cursorY + 2), combocount, AlreadyStepped))
                                                    {
                                                        PossibleMoves[spots, 0] = cursorX;
                                                        PossibleMoves[spots, 1] = (byte)(cursorY + 2);
                                                        spots++;
                                                        allowMovePiece = true;
                                                    }
                                                }
                                            }
                                            if (cursorX > 1) //out of range prevention
                                            {
                                                if ((board[cursorX - 1, cursorY] > 0) && (board[cursorX - 2, cursorY] == 0)) //jumpable
                                                {
                                                    if (!CheckAlreadyStepped((byte)(cursorX - 2), cursorY, combocount, AlreadyStepped))
                                                    {
                                                        PossibleMoves[spots, 0] = (byte)(cursorX - 2);
                                                        PossibleMoves[spots, 1] = cursorY;
                                                        spots++;
                                                        allowMovePiece = true;
                                                    }
                                                }
                                            }
                                            if (cursorY > 1) //out of range prevention
                                            {
                                                if ((board[cursorX, cursorY - 1] > 0) && (board[cursorX, cursorY - 2] == 0)) //jumpable
                                                {
                                                    if (!CheckAlreadyStepped(cursorX, (byte)(cursorY - 2), combocount, AlreadyStepped))
                                                    {
                                                        PossibleMoves[spots, 0] = cursorX;
                                                        PossibleMoves[spots, 1] = (byte)(cursorY - 2);
                                                        spots++;
                                                        allowMovePiece = true;
                                                    }
                                                }
                                            }

                                            //show possible combo jumps
                                            for (byte i = 0; i < spots; i++)
                                            {
                                                MoveCursor(PossibleMoves[i, 0], PossibleMoves[i, 1]);
                                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                                Console.Write('.');
                                                Console.BackgroundColor = ConsoleColor.Gray;
                                            }
                                            MoveCursor(cursorX, cursorY);

                                        }

                                        //selected tile
                                        SelectX = cursorX;
                                        SelectY = cursorY;


                                        //win check
                                        if ((SelectX<3)&&(SelectY<3))
                                        {
                                            bool complete = true;
                                            for (byte x = 0;x<3;x++)
                                            {
                                                for (byte y = 0;y<3;y++)
                                                {
                                                    if (board[x,y]!= 1)
                                                    {
                                                        complete = false;
                                                        break;
                                                    }
                                                }
                                                if (!complete) break;
                                            }

                                            if (complete) gameover = true;
                                        }

                                    }
                                }
                                break;
                            case ConsoleKey.C:
                                if ((!allowMovePiece) || suppressPieceSelection)
                                {

  

                                    allowMovePiece = false;
                                    if (suppressPieceSelection)
                                    {
                                        //clear possible steps from screen
                                        for (byte i = 0; i < spots; i++)
                                        {
                                            MoveCursor(PossibleMoves[i, 0], PossibleMoves[i, 1]);
                                            Console.Write('.');
                                        }

                                        //rewrite deleted selected tile after X press
                                        MoveCursor(SelectX, SelectY);
                                        Console.Write('x');

                                        suppressPieceSelection = false;

                                        //"clear" already stepped list
                                        combocount = 0;

                                        playerturn = false;
                                    }

                                }


                                break;
                        }//switch console key

                    }
                    //PLAYER TURN END

                    if (gameover)
                    {
                        Xwins();
                        break;
                    }

                    Console.SetCursorPosition(30, 3);
                    Console.WriteLine("o");

                    Console.CursorVisible = false;

                    //CPU TURN
                    while (!playerturn)
                    {

                        


                        Random rand = new Random();

                        byte pickedX = 8;
                        byte pickedY = 8;
                        byte picked = 9;

                        //record double jumps if possible (priority)
                        bool priority = false;

                        spots = 0;

                        for (byte repeat = 0; repeat < 2; repeat++)
                        {
                            // o x . ? .
                            if ((0 < SelectX) && (SelectX < 5))
                            {
                                if (
                                    (board[SelectX - 1, SelectY] == 2) &&
                                    (board[SelectX + 1, SelectY] == 0) &&
                                    (board[SelectX + 2, SelectY] > 0) &&
                                    (board[SelectX + 3, SelectY] == 0)
                                    )
                                {
                                    if (RightGoodMove((byte)(SelectX + 3), SelectY, board))
                                    {
                                        PossibleMoves[spots, 0] = (byte)(SelectX + 3);
                                        PossibleMoves[spots, 1] = SelectY;

                                        pickedX = (byte)(SelectX - 1);
                                        pickedY = SelectY;
                                        for (byte i = 0; i < 9; i++)
                                        {
                                            if ((cpupieces[i, 0] == pickedX) && (cpupieces[i, 1] == pickedY))
                                            {
                                                movableCPUPieces[spots] = i;
                                                break;
                                            }
                                        }

                                        spots++;
                                        priority = true;
                                    }
                                }
                            }

                            // o ? . x .
                            if ((2 < SelectX) && (SelectX < 7))
                            {
                                if (
                                    (board[SelectX - 3, SelectY] == 2) &&
                                    (board[SelectX - 2, SelectY] > 0) &&
                                    (board[SelectX - 1, SelectY] == 0) &&
                                    (board[SelectX + 1, SelectY] == 0)
                                    )
                                {
                                    if (RightGoodMove((byte)(SelectX + 1), SelectY, board))
                                    {
                                        PossibleMoves[spots, 0] = (byte)(SelectX + 1);
                                        PossibleMoves[spots, 1] = SelectY;

                                        pickedX = (byte)(SelectX - 3);
                                        pickedY = SelectY;
                                        for (byte i = 0; i < 9; i++)
                                        {
                                            if ((cpupieces[i, 0] == pickedX) && (cpupieces[i, 1] == pickedY))
                                            {
                                                movableCPUPieces[spots] = i;
                                                break;
                                            }
                                        }

                                        spots++;
                                        priority = true;
                                    }
                                }
                            }

                            /*

                            o
                            x
                            .
                            ?
                            .

                            */
                            if ((0 < SelectY) && (SelectY < 5))
                            {
                                if (
                                    (board[SelectX, SelectY - 1] == 2) &&
                                    (board[SelectX, SelectY + 1] == 0) &&
                                    (board[SelectX, SelectY + 2] > 0) &&
                                    (board[SelectX, SelectY + 3] == 0)
                                    )
                                {
                                    if (DownGoodMove(SelectX, (byte)(SelectY + 3), board))
                                    {
                                        PossibleMoves[spots, 0] = SelectX;
                                        PossibleMoves[spots, 1] = (byte)(SelectY + 3);

                                        pickedX = SelectX;
                                        pickedY = (byte)(SelectY - 1);
                                        for (byte i = 0; i < 9; i++)
                                        {
                                            if ((cpupieces[i, 0] == pickedX) && (cpupieces[i, 1] == pickedY))
                                            {
                                                movableCPUPieces[spots] = i;
                                                break;
                                            }
                                        }

                                        spots++;
                                        priority = true;
                                    }
                                }
                            }

                            /*

                            o
                            ?
                            .
                            x
                            .

                            */
                            if ((2 < SelectY) && (SelectY < 7))
                            {
                                if (
                                    (board[SelectX, SelectY - 3] == 2) &&
                                    (board[SelectX, SelectY - 2] > 0) &&
                                    (board[SelectX, SelectY - 1] == 0) &&
                                    (board[SelectX, SelectY + 1] == 0)
                                    )
                                {
                                    if (DownGoodMove(SelectX, (byte)(SelectY + 1), board))
                                    {
                                        PossibleMoves[spots, 0] = SelectX;
                                        PossibleMoves[spots, 1] = (byte)(SelectY + 1);

                                        pickedX = SelectX;
                                        pickedY = (byte)(SelectY - 3);
                                        for (byte i = 0; i < 9; i++)
                                        {
                                            if ((cpupieces[i, 0] == pickedX) && (cpupieces[i, 1] == pickedY))
                                            {
                                                movableCPUPieces[spots] = i;
                                                break;
                                            }
                                        }

                                        spots++;
                                        priority = true;
                                    }
                                }
                            }

                            SelectX = lastMovedCPUPiece[0];
                            SelectY = lastMovedCPUPiece[1];
                        }

                        for (byte repeat = 0; repeat < 2; repeat++)
                        {
                            SelectX = newEmptySpaces[repeat, 0];
                            SelectY = newEmptySpaces[repeat, 1];

                            // o ? . ? ,
                            if ((3 < SelectX) && (SelectX < 8))
                            {
                                if (
                                    (board[SelectX - 4, SelectY] == 2) &&
                                    (board[SelectX - 3, SelectY] > 0) &&
                                    (board[SelectX - 2, SelectY] == 0) &&
                                    (board[SelectX - 1, SelectY] > 0)
                                    )
                                {
                                    if (RightGoodMove(SelectX, SelectY, board))
                                    {
                                        PossibleMoves[spots, 0] = SelectX;
                                        PossibleMoves[spots, 1] = SelectY;

                                        pickedX = (byte)(SelectX - 4);
                                        pickedY = SelectY;
                                        for (byte i = 0; i < 9; i++)
                                        {
                                            if ((cpupieces[i, 0] == pickedX) && (cpupieces[i, 1] == pickedY))
                                            {
                                                movableCPUPieces[spots] = i;
                                                break;
                                            }
                                        }

                                        spots++;
                                        priority = true;
                                    }
                                }
                            }

                            // o ? , ? .
                            if ((1 < SelectX) && (SelectX < 6))
                            {
                                if (
                                    (board[SelectX - 2, SelectY] == 2) &&
                                    (board[SelectX - 1, SelectY] > 0) &&
                                    (board[SelectX + 1, SelectY] > 0) &&
                                    (board[SelectX + 2, SelectY] == 0)
                                    )
                                {
                                    if (RightGoodMove((byte)(SelectX + 2), SelectY, board))
                                    {
                                        PossibleMoves[spots, 0] = (byte)(SelectX + 2);
                                        PossibleMoves[spots, 1] = SelectY;

                                        pickedX = (byte)(SelectX - 2);
                                        pickedY = SelectY;
                                        for (byte i = 0; i < 9; i++)
                                        {
                                            if ((cpupieces[i, 0] == pickedX) && (cpupieces[i, 1] == pickedY))
                                            {
                                                movableCPUPieces[spots] = i;
                                                break;
                                            }
                                        }

                                        spots++;
                                        priority = true;
                                    }
                                }
                            }

                            /*

                            o
                            ?
                            .
                            ?
                            ,

                            */
                            if ((3 < SelectY) && (SelectY < 8))
                            {
                                if (
                                    (board[SelectX, SelectY - 4] == 2) &&
                                    (board[SelectX, SelectY - 3] > 0) &&
                                    (board[SelectX, SelectY - 2] == 0) &&
                                    (board[SelectX, SelectY - 1] > 0)
                                    )
                                {
                                    if (DownGoodMove(SelectX, SelectY, board))
                                    {
                                        PossibleMoves[spots, 0] = SelectX;
                                        PossibleMoves[spots, 1] = SelectY;

                                        pickedX = SelectX;
                                        pickedY = (byte)(SelectY - 4);
                                        for (byte i = 0; i < 9; i++)
                                        {
                                            if ((cpupieces[i, 0] == pickedX) && (cpupieces[i, 1] == pickedY))
                                            {
                                                movableCPUPieces[spots] = i;
                                                break;
                                            }
                                        }

                                        spots++;
                                        priority = true;
                                    }
                                }
                            }

                            /*

                            o
                            ?
                            ,
                            ?
                            .

                            */
                            if ((1 < SelectY) && (SelectY < 6))
                            {
                                if (
                                    (board[SelectX, SelectY - 2] == 2) &&
                                    (board[SelectX, SelectY - 1] > 0) &&
                                    (board[SelectX, SelectY + 1] > 0) &&
                                    (board[SelectX, SelectY + 2] == 0)
                                    )
                                {
                                    if (DownGoodMove(SelectX, (byte)(SelectY + 2), board))
                                    {
                                        PossibleMoves[spots, 0] = SelectX;
                                        PossibleMoves[spots, 1] = (byte)(SelectY + 2);

                                        pickedX = SelectX;
                                        pickedY = (byte)(SelectY - 2);
                                        for (byte i = 0; i < 9; i++)
                                        {
                                            if ((cpupieces[i, 0] == pickedX) && (cpupieces[i, 1] == pickedY))
                                            {
                                                movableCPUPieces[spots] = i;
                                                break;
                                            }
                                        }

                                        spots++;
                                        priority = true;
                                    }
                                }
                            }
                        }

                        if (!priority)
                        {
                            //choose a piece
                            picked = (byte)rand.Next(0, 9);

                            //take x and y of piece
                            pickedX = cpupieces[picked, 0];
                            pickedY = cpupieces[picked, 1];


                            //record possible moves of selected piece if there are no double jumps
                            if (pickedX != 7)
                            {
                                //step
                                if (board[pickedX + 1, pickedY] == 0)
                                {
                                    if (RightGoodMove((byte)(pickedX + 1), pickedY, board))
                                    {
                                        PossibleMoves[spots, 0] = (byte)(pickedX + 1);
                                        PossibleMoves[spots, 1] = pickedY;
                                        spots++;
                                    }
                                }

                                //jump
                                else if (pickedX != 6)
                                {
                                    if (board[pickedX + 2, pickedY] == 0)
                                    {
                                        if (RightGoodMove((byte)(pickedX + 2), pickedY, board))
                                        {
                                            PossibleMoves[spots, 0] = (byte)(pickedX + 2);
                                            PossibleMoves[spots, 1] = pickedY;
                                            spots++;
                                        }
                                    }
                                }
                            }
                            if (pickedY != 7)
                            {
                                //step
                                if (board[pickedX, pickedY + 1] == 0)
                                {
                                    if (DownGoodMove(pickedX, (byte)(pickedY + 1), board))
                                    {
                                        PossibleMoves[spots, 0] = pickedX;
                                        PossibleMoves[spots, 1] = (byte)(pickedY + 1);
                                        spots++;
                                    }
                                }

                                //jump
                                else if (pickedY != 6)
                                {
                                    if (board[pickedX, pickedY + 2] == 0)
                                    {
                                        if (DownGoodMove(pickedX, (byte)(pickedY + 2), board))
                                        {
                                            PossibleMoves[spots, 0] = pickedX;
                                            PossibleMoves[spots, 1] = (byte)(pickedY + 2);
                                            spots++;
                                        }
                                    }
                                }
                            }
                        }

                        //move
                        if (spots != 0)
                        {
                            System.Threading.Thread.Sleep(500);

                            //randomly select a possible spot
                            byte choose = (byte)rand.Next(0, spots);

                            if (priority)
                            {
                                picked = movableCPUPieces[choose];
                                pickedX = cpupieces[picked,0];
                                pickedY = cpupieces[picked,1];
                            }

                            newEmptySpaces[1, 0] = pickedX;
                            newEmptySpaces[1, 1] = pickedY;

                            //move piece
                            MoveCursor(pickedX, pickedY);
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine('o');
                            Console.BackgroundColor = ConsoleColor.Gray;

                            board[pickedX, pickedY] = 0;
                            board[PossibleMoves[choose, 0], PossibleMoves[choose, 1]] = 2;

                            if (PossibleMoves[choose ,0] - pickedX == 4)
                            {
                                System.Threading.Thread.Sleep(500);
                                MoveCursor(pickedX, pickedY);
                                MovePiece((byte)(PossibleMoves[choose, 0]-2), PossibleMoves[choose, 1], 'o', true);
                                Console.BackgroundColor = ConsoleColor.Gray;

                                pickedX = (byte)(pickedX + 2);
                            }

                            if (PossibleMoves[choose, 1] - pickedY == 4)
                            {
                                System.Threading.Thread.Sleep(500);
                                MoveCursor(pickedX, pickedY);
                                MovePiece(PossibleMoves[choose, 0], (byte)(PossibleMoves[choose, 1] - 2), 'o', true);
                                Console.BackgroundColor = ConsoleColor.Gray;

                                pickedY = (byte)(pickedY + 2);
                            }

                            System.Threading.Thread.Sleep(500);
                            MoveCursor(pickedX, pickedY);
                            MovePiece(PossibleMoves[choose, 0], PossibleMoves[choose, 1], 'o',true);

                            System.Threading.Thread.Sleep(500);
                            MoveCursor(PossibleMoves[choose, 0], PossibleMoves[choose, 1]);
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.Write('o');


                            //update cpu pieces
                            cpupieces[picked, 0] = PossibleMoves[choose, 0];
                            cpupieces[picked, 1] = PossibleMoves[choose, 1];

                            //store moved piece position (for double jump check)
                            lastMovedCPUPiece[0] = cpupieces[picked, 0];
                            lastMovedCPUPiece[1] = cpupieces[picked, 1];

                            //win check
                            if ((PossibleMoves[choose, 0] > 4) && (PossibleMoves[choose, 1] > 4))
                            {
                                bool complete = true;
                                for (byte x = 7; x > 4; x--)
                                {
                                    for (byte y = 7; y > 4; y--)
                                    {
                                        if (board[x, y] != 2)
                                        {
                                            complete = false;
                                            break;
                                        }
                                    }
                                    if (!complete) break;
                                }

                                if (complete) gameover = true;
                            }


                            playerturn = true;
                        }
                    }
                    //CPU TURN END
                    Console.CursorVisible = true;

                    if (gameover)
                    {
                        Owins();
                        break;
                    }

                    round++;
                    Console.SetCursorPosition(30, 2);
                    Console.WriteLine(round);
                    Console.SetCursorPosition(30, 3);
                    Console.WriteLine("x");
                    MoveCursor(cursorX, cursorY);

                }//console.KeyAvileable

                
            }//while loop

            Console.ReadKey();
            Console.SetCursorPosition(0, 20);

        }
    }
}
