using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace repairttt
{
    public class ttt_game
    {
        string[,] game_table = new string[3, 3] 
        { { "　", "　", "　" }, { "　", "　", "　" }, { "　", "　", "　" } };
        public void Put_Stone() 
        {
            string user_stone = "O";
            int.TryParse(Console.ReadLine(), out int user_number);
            int x = (user_number - 1) % 3;
            int y = (user_number - 1) / 3;






        }


        public void Com_Stome() 
        {
        
        
        
        }


        public void Win_Check() 
        {
        
        
        
        }


        public void Table_Out() 
        {
        
        
        
        }


    }
}
