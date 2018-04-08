using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class Chess
    {
        public enum Color { white = 0, black = 1 };

        //public enum Cell { white = 0, black = 1 }

        public class Player
        {
            public int name;
            public Boolean turn;
            public Color color;

            public void Move(Piece p, Square s)
            {
                if(turn)
                    p.Move(s);
            }
        }

        public class Game
        {
            public Player[] players;
            public Board board;

            public Game()
            {
                players = new Player[2];
                board = new Board();
            }


        }

        public class Square
        {
            public Piece piece;
            public Color color;
            public int x;
            public int y;
            public Square(Piece p, Color c, int x, int y)
            {
                this.piece = p;
                this.color = c;
                this.x = x;
                this.y = y;
            }

        }

        public class Board
        {
            public Square[,] squares;
            //List<Piece> pieces;
            public Board()
            {
                this.squares = new Square[8, 8];
            }
        }

        public class Piece
        {
            public Color color;
            public Square square;// you can assign square to piece

            public virtual void Move(Square s) { }

            public virtual void isValidMove(Square s)
            {
                //return false;
            }

            public  void Attack(Piece p)
            {

            }

            public  Boolean IsValidAttack()
            {
                return false;
            }

        }

        public class elephant : Piece
        {
            public override void Move(Square s)
            {  
            }

            public override void isValidMove(Square s)
            {

            }
        }

        public class King : Piece
        {
            public override void Move(Square s)
            {
            }

            public override void isValidMove(Square s)
            {
            }
        }

        public class Queeen : Piece
        {
            public override void Move(Square s)
            {
            }

            public override void isValidMove(Square s)
            {
            }
        }

        public class Rook : Piece
        {
            public override void Move(Square s)
            {
            }

            public override void isValidMove(Square s)
            {
            }
        }

        public class Bishop : Piece
        {
            public override void Move(Square s)
            {
            }

            public override void isValidMove(Square s)
            {
            }
        }

        public class Knight : Piece
        {
            public override void Move(Square s)
            {
            }

            public override void isValidMove(Square s)
            {
            }
        }
    }
}
