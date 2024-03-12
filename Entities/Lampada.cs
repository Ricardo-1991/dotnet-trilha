namespace Atividade1.Entities;
public class Lampada {
    public bool Ligada { get; private set; }

    public Lampada() {

    }

    public void Ligar(){
        Ligada = true;
    }

    public void Desligar(){
        Ligada = false;
    }

    public void Imprimir(){
        if(Ligada){
            Console.WriteLine("Lampada Ligada");
        } else {
            Console.WriteLine("Lampada Desligada");
        }
    }
}
