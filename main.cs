using System;

namespace Rextester
{
    public class Program
    {
        public static int width = 4, height = 4;
        public static int[,] matriz = new int[width,height];
        public static int[,] matrizB = new int[width,height];
        
        public static void Main(string[] args)
        {
            width=4;height =4; //set dimensiones  CON PROBLEMAS!!
            Random rand = new Random();
            int top = 4;
            for (int y=0; y<height; y++){
                for (int x=0; x<width; x++){
                    matriz[x,y] = rand.Next(0,top);
                }
            }
            matriz[rand.Next(0,width-1),rand.Next(0,height-1)]=12;
            for (int y=0; y<height; y++){
                for (int x=0; x<width; x++){
                  if (matriz[x,y]==12){
                    Console.Write("C ");
                  }
                  else{
                    Console.Write(matriz[x,y]); Console.Write(' ');
                  }
                }
                Console.WriteLine();
            }
			      move();
        }

        public static void move(){
          CopyMatrix();
          Console.WriteLine();
          Console.Write("Move");
          string movekind = Console.ReadLine();
          if(movekind=="c"){
            int xA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("to");
            int xB = Convert.ToInt32(Console.ReadLine());
            for (int y=0; y<height;y++){
              matriz[xB,y]=matrizB[xA,y];
              matriz[xA,y]=matrizB[xB,y];
            }
          }
          else if (movekind=="f"){
            int yA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("to");
            int yB = Convert.ToInt32(Console.ReadLine());
            for (int x=0; x<width; x++){
              matriz[x,yA]=matrizB[x,yB];
              matriz[x,yB]=matrizB[x,yA];
            }
          }
          else if (movekind=="s"){
            Random rand = new Random();
            int alfa = Convert.ToInt32(Console.ReadLine());
            bool[] isSet = new bool[width];
            for(int i=0; i<width; i++){
              int x = rand.Next(width);
              if(isSet[x]==false){
                matriz[x,alfa]= matrizB[i,alfa];
                isSet[x]=true;
              }
              else {
                for(int j = 0; j<width; j++){
                  if(isSet[j]==false){
                    matriz[j,alfa]= matrizB[i,alfa];
                    isSet[j]=true;
                    break;
                  }
                }
              }
            }
          }
          Console.WriteLine();
          for (int y=0; y<height; y++){
            for (int x=0; x<width; x++){
              if(matriz[x,y]==12){Console.Write("C ");}else{Console.Write(matriz[x,y]); Console.Write(' ');}
            }
            Console.WriteLine();
          }
          bool winning=false, wonV=false;
          for (int x=0; x<width; x++){
            for (int y=0; y<height; y++){
              if(matriz[x,y]==y||matriz[x,y]==12){
                winning=true;
              }else{
                winning=false;break;
              }
            }
            if(winning==true){Console.Write(x+"WON! "); wonV=true;}
            else{
              for (int y=0; y<height; y++){
              if(matriz[x,y]==height-1-y||matriz[x,y]==12){
                winning=true;
              }else{
                winning=false;break;
              }
              }
              if(winning==true){Console.Write(x+"Ganó al revés");wonV=true;}
            }

          }
          bool winningH = false, wonH=false;
          for(int y=0; y<height; y++){
            for(int x=0; x<width; x++){
              if(matriz[x,y]==x || matriz[x,y]==12){
                winningH=true;
              }else{
                winningH=false;break;}
            }
            if (winningH==true){
              Console.WriteLine(y+"gana horizontal"); wonH=true;
            }else{
              for(int x=0; x<width; x++){
              if(matriz[x,y]==width-1-x || matriz[x,y]==12){
                winningH=true;
              }else{
                winningH=false;break;}
              }
              if(winningH==true){Console.WriteLine(y+"reverse gana horizontal"); wonH=true;}
            }
          }
          if(wonV==true && wonH==true){Console.WriteLine("------DOUBLE WINNER-------");}
          move();
        }
        
        public static void CopyMatrix(){
            for (int x=0; x<width; x++){
                for (int y=0; y<height; y++){
                    matrizB[x,y] = matriz[x,y];
                }
            }
        }
        
    }
}
