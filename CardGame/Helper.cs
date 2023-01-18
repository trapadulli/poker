using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Helper
    {
        public Dictionary<string, int> Converter { get; set; }
        public Helper(){
            Converter = new Dictionary<string, int>();
            Converter.Add("1", 1);
            Converter.Add("2", 2);
            Converter.Add("3", 3);
            Converter.Add("4", 4);
            Converter.Add("5", 5);
            Converter.Add("6", 6);
            Converter.Add("7", 7);
            Converter.Add("8", 8);
            Converter.Add("9", 9);
            Converter.Add("10", 10);
            Converter.Add("J", 11);
            Converter.Add("Q", 12);
            Converter.Add("K", 13);
            Converter.Add("A", 14);
        }
    }
}
