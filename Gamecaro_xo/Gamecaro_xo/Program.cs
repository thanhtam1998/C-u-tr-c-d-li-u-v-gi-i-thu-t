/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 3/4/2020
 * Time: 9:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Gamecaro_xo
{
	class Program
	{
		
		
		public static void Main(string[] args)
		{
			string[,] A = new String[12,12];
			int index =0 ;
			int indey =0 ;
			
			
			
			for(int i= 0; i < 12; i ++){
				for(int j = 0; j < 12; j++){
					Console.WriteLine("A[{0},{1}]",i,j);
					A[i,j] = "-";
				}
			}
			DisplayBoard(0,0,A,"X");
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void DisplayChess(int index, int indey, string[,] A,string chess)
        {
            Console.Clear();

           	for(int x= 0; x < 12; x ++){
				for(int y = 0; y < 12; y++){
            		if(x == index && y == indey){
            			Console.Write(" {0} ", chess);
            		}
            		else{
            			Console.Write(" {0} ",A[x,y]);
            		}
					
				}
				Console.WriteLine("");
			}
        }
		
		public static void DisplayBoard(int index, int indey, string[,] A,string chess){
			ConsoleKey key;
			do
                {
                    DisplayChess(index,indey,A,chess);
                    key = Console.ReadKey().Key;
                    if (key == ConsoleKey.UpArrow)
                    {
                        index = index -1;
                        if(index < 0)
                        	index = 0;
                    }
                    else if (key == ConsoleKey.DownArrow)
                    {
                        index = index + 1;
                        if (index > 12)
                            index = 12;
                    }
                    else if (key == ConsoleKey.LeftArrow)
                    {
                        indey = indey - 1;
                        if (indey < 0)
                            indey = 0;
                    }
                    else if (key == ConsoleKey.RightArrow)
                    {
                        indey = indey + 1;
                        if (indey > 12)
                            indey = 12;
                    }

                } while (key != ConsoleKey.Enter);
			A[index,indey] = chess;
			if(checkRow(A,index,indey) || checkColum(A,index,indey) || checkDiagonal(A,index,indey))
				Console.WriteLine(" Congratulations on Player {0} victory",A[index,indey]);
			else{
				if(A[index,indey] == "X"){
					DisplayBoard(index,indey,A,"O");
				}
				else{
					DisplayBoard(index,indey,A,"X");
				}
			}
		}
		
		public static bool checkRow(string[,] A, int x, int y){
			int count = 0;
			//kt dem nguoc lai
			for(int j = y; j >= 0; j--){
				if(A[x,j] == A[x,y]){
					count++;
				}
				else break;
			}
			if(count == 5){
				return true;
			}
			
			count = 0;
			for(int j = y; j < 12; j++){
				if(A[x,j] == A[x,y]){
					count++;
				}
				else break;
			}
			if(count == 5){
				return true;
			}
			return false;
		}
		
		public static bool checkColum(string[,] A, int x, int y){
			int count=0;
			for(int i = x; i < 13;i++){
				if(A[i,y] == A[x,y])
				{
					count++;
				}
				else
					break;
			}
			
			if(count == 5){
				return true;
			}
			count = 0;
			for(int i = x; i >= 0;i--){
				if(A[i,y] == A[x,y])
				{
					count++;
				}
				else
					break;
			}
			
			if(count == 5){
				return true;
			}
			return false;
		}
		
		public static bool checkDiagonal(string[,] A, int x, int y){
			int count = 0;
			int i = x;
			int j = y;
			while(i > 0 && j > 0){
				if(A[i,j] == A[x,y]){
					count++;
				}
				else
					break;
				i--; j--;
			}
			if(count == 5){
				return true;
			}
			count = 0;
			i = x; j = y;
			while(i>= 0 && j < 12){
				if(A[i,j] == A[x,y]){
					count++;
				}
				else
					break;
				i--; j++;
			}
			
			if(count == 5){
				return true;
			}
			count = 0;
			i = x; j = y;
			while(i< 12 && j >= 0){
				if(A[i,j] == A[x,y]){
					count++;
				}
				else
					break;
				i++ ;j--;
			}
			
			if(count == 5)
				return true;
			
			count = 0;
			i = x; j = y;
			
			while(i< 12 && j < 12){
				if(A[i,j] == A[x,y]){
					count++;
				}
				else
					break;
				i++ ;j++;
			}
			if(count == 5)
				return true;
			return false;
			
		}
	}
}