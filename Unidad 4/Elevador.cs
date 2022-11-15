using System;
class ELEVATORWELL
{
    private string persona;
    private int piso;

    public ELEVATORWELL(){
     encenderAscensor();
    }
    
    public void encenderAscensor(){
     Console.WriteLine("\nEs de mañana y el ascensor se enciende".ToUpper());
     Console.WriteLine("\nBienvenido a ELEVATORWELL. Póngase cómodo y seleccione un piso hacia donde quiere ir");
     piso=1;
    }
    
    public void apagarAscensor(){
      Console.WriteLine("\nLlego la noche y el ascensor se apaga".ToUpper());
      Console.WriteLine("Gracias por utilizar nuestros servicios");
    }

    public void InterfazElevador(){
     Console.WriteLine("\nPISO: "+piso);
     Console.WriteLine("\n0. Terminar tanda");
     Console.WriteLine("1. Moverme de piso (Piso tope: 15)");
     Console.Write("\nQue quiere hacer? ");
    
     persona=Console.ReadLine();

     switch (persona)
     {
        case "0":{
        apagarAscensor();
        break;
        }

        case "1":{
         Subir_BajarPiso(); break;
        }
        default:{Console.WriteLine("\nOpción no disponible");
        InterfazElevador();
        break;
        }       
     }

    }

    public void Subir_BajarPiso(){
       Console.Write("La puerta se ha cerrado. A qué piso quiere ir?");
        piso=int.Parse(Console.ReadLine());

        if(piso>=1 && piso<=15){
            Console.WriteLine("\nSe movió exitósamente de piso");
            InterfazElevador();
        }    

         else if(piso<1||piso>15){
            Console.WriteLine("No puede ir más allá del tope");
            while(piso<1||piso>15){
                Console.Write("\n");
                Console.Write("Introduzca a que piso quiere ir: ");
                piso=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nSe movió exitósamente de piso");
            InterfazElevador();
        }
    }
    
    
}

class Elevador{

    static void Main(){
        ELEVATORWELL personaElevador= new ELEVATORWELL();

        personaElevador.InterfazElevador();
        
    }
}