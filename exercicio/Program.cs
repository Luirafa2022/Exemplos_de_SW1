namespace exercicio;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.ReadKey();

        Exemplo exe01 = new Exemplo();

        exe01.mostramsg();
        exe01.peganome("Pelé");
        Console.WriteLine(exe01.mensagem());
        Console.WriteLine("O resultado da soma é: "+exe01.somar(20,43));
    }
}
