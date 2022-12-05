using System;
class AireAcondicionado{
    private string opcion;
    private string marca;
    private int velocidad= 1;
    private int temperatura= 17;

    public AireAcondicionado(int velocidad, int temperatura){
        velocidad= this.velocidad;
        temperatura= this.temperatura;

        Console.WriteLine("El AC se ha encendido.\nTemperatura: " + temperatura + 
        " *C \nVelocidad: " + velocidad + "\nEstado: Encendido");
    }

    public void apa
}