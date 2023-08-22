using System;
class Program
{
    static void Main(string[] args){
        Console.WriteLine("Segunda Aula");
        if(args.Length>0){
            Console.WriteLine(args.GetValue(0));
        }
    }
}