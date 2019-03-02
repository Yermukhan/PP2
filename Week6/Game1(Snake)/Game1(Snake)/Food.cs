using System;

namespace Game1_Snake_
{
   public class Food:GameObject
    {
        public Food(int x,int y,char sign,ConsoleColor color): base(x,y,sign,color)
        {
        }
        public void Generate()
        {
            Random random = new Random();
            int x = random.Next(0, Console.WindowWidth);
            int y = random.Next(0, Console.WindowHeight);
            body[0].x = x;
            body[0].y = y;

        } 
    }
}
