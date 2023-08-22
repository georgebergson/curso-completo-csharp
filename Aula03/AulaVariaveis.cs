using System;
class Program{
    static void Main(string[] args){
        byte n1= 10; //0 a 255
        int num=0;
        char letra = 'g';
        float valor = 5.3f;
        string nome = "George Bergson";

        // quando for usar o var ele busca a tipagem por atribuição do valor;
        // var num =10; var nome ="George" e etc..
        Console.WriteLine("O valor de byte é "+n1);
        Console.WriteLine("O valor de int é "+num);
        Console.WriteLine("O valor de char é "+letra);
        Console.WriteLine("O valor de float é "+valor);
        Console.WriteLine("O valor de string é "+nome);
    }
}