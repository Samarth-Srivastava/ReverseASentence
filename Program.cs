//driver code
using System;
using System.IO;

namespace ReverseASentence{
    public class Program{
        public static void Main(string[] args){
            Solution s = new Solution();
            
            Console.WriteLine(s.solve(args[0]));
        }
    }
}