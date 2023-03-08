namespace exercicio;
class Exemplo
{
    //Atributos
  public string nome="nada";
  public int idade=0;
  public bool vacinado=true;

  //Métodos
  public void mostramsg(){
    Console.WriteLine("Oi 2F");
  }

    public void peganome(string texto){
        Console.WriteLine("Oi " + texto);
    }

    public string mensagem(){
        return "Devolvendo um texto";
    }

    public int somar(int a, int b){
        return a+b;
    }
}
