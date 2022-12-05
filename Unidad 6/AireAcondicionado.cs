using System;
class AireAcondicionado{
    private string opcion;
    private string marca = ""; //Marcas disponibles: SAMSUNG, HAIER, NEDOCA
    private int velocidad = 1;
    private int temperatura= 17;

    public AireAcondicionado(int velocidad, int temperatura, string marca){
        velocidad= this.velocidad;
        temperatura= this.temperatura;
        marca= this.marca;

        Console.WriteLine("El AC se ha encendido.\nTemperatura: " + temperatura + 
        " *C \nVelocidad del fan: " + velocidad + "\nEstado: Encendido");

        Console.Write("Introduzca su marca de AC: ");
        marca = Console.ReadLine();
        if((marca.ToUpper())!="SAMSUNG"||(marca.ToUpper())!="HAIER"||(marca.ToUpper())!="NEDOCA"){
            while((marca.ToUpper())!="SAMSUNG" && (marca.ToUpper())!="HAIER" && (marca.ToUpper())!="NEDOCA"){
            Console.Write("\n Introduzca su opción de nuevo \n(Marcas disponibles: SAMSUNG, HAIER, NEDOCA): ");
            marca = Console.ReadLine();
        }
        }
              
    }

    public void apagar(){
        Console.WriteLine("\nEstado: Stand-by");
    }

    public void subirTemperatura(int temperatura){
        this.temperatura= this.temperatura + temperatura;
        interfazAC();
    }

    public void bajarTemperatura(int temperatura){
        this.temperatura= this.temperatura - temperatura;
        interfazAC();
    }

    public void subirVelocidad(int velocidad){
        if(this.velocidad==4){
            Console.WriteLine("No se puede aumentar más la velocidad");
            interfazAC();
        }
        else
        this.velocidad= this.velocidad + velocidad;
        interfazAC();
    }

    public void bajarVelocidad(int velocidad){
        if(this.velocidad==1){
            Console.WriteLine("No se puede reducir más la velocidad");
            interfazAC();
        }
        else
        this.velocidad = this.velocidad - velocidad;
        interfazAC();
    }
   
   public void interfazAC(){
    
    Console.WriteLine("\nTemperatura: " + temperatura + 
        " *C \nVelocidad del fan: " + velocidad + "\nEstado: Encendido" + "\n Marca: " + marca);
    Console.WriteLine("\n0. Apagar \n1. Subir Temperatura \n2. Bajar Temperatura"
    + "\n3. Subir Velocidad del fan \n4. Bajar Velocidad del fan");
    Console.Write("Elija una opción: ");

    opcion = Console.ReadLine();

    switch(opcion){
        case "0":  {apagar(); break;}

        case "1": {subirTemperatura(1); break;}

        case "2": {bajarTemperatura(1); break;}

        case "3": {subirVelocidad(1); break;}

        case "4": {bajarVelocidad(1); break;}

        default: {Console.WriteLine("\nOpción no disponible"); interfazAC(); break;}
    }
   

}}

public class Tester{
    static  void Main(){
        AireAcondicionado AC = new AireAcondicionado(0, 0, "");
        AC.interfazAC();
        
    }
}