using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            string map = $@"Z 0 0 0 0 0 0 0 0
0 1 1 1 1 1 0 0 0
1 0 0 0 0 0 0 1 1
0 0 0 0 1 0 0 1 1
1 1 1 1 1 1 0 1 1
1 1 1 1 1 0 0 0 0
0 0 K 0 0 0 0 0 0";
            string[] mapArr = map.Split(' ', '\n', '\r');
            mapArr = map.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            int xM = 7;
            int yM = 9;
            int x;
            int y;
            char[,] CharMap = new char[xM, yM];
            int pozice = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    CharMap[i, i2] = Convert.ToChar(mapArr[pozice]);
                    pozice++;
                }
            }
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    if (CharMap[i, i2] == 'Z')
                    {
                        x = i;
                        y = i2;
                    }
                }
            }
            char[,] CharRoboMap = new char[xM, yM];
            if (CharMap[x + 1, y] == '0')
            {
                CharRoboMap[x + 1, y] = '0';
            }
        }
    }
}

    

