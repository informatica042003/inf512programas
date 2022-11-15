
// Luis Miguel Sánchez Cabreja     Matrícula: 100613071     Sec.12  

// Agregué una condición unica para la variable modelo. Solo aceptará los modelos
// A50, A20, A30

using System;
class TelefonoMovil{

/* 

Atributos de clase.

Debajo se encuentran las definiciones de los atributos de la clase TelefonoMovil.
Realice los cambios en los atributos y metodos que sean necesarios para encapsular
la clase TelefonoMovil.
  
*/

    private string marca;
    private string color;
    private string modelo; // CONDICIÓN UNICA Modelos disponibles: A50, A20, A30
    private int cantidadCamaras; //No puede ser mayor de 8
    private int size; //No puede ser mayor de 7 pulgadas
    private string estado; //Estados posibles: Encendido, Suspendido, Apagado

/* 

Metodos de acceso: getters y setters.

En este espacio defina los metodos get y set que sean necesarios para 
encapsular la clase TelefonoMovil.
  
*/

    public bool marcar(){
        return true;
    }

    public bool llamar(string numeroTelefonoDestino){
        return true;
    }

    public void vibrar(){

    }

    public bool encender(){
        return true;
    }
     
     public bool suspender(){
        return true;
    }

    public bool apagar(){
        return true;
    }
    
    //CREAMOS TODOS LOS SETS
    public void setMarca(string marca){
        this.marca=marca;
    }

    public void setColor(string color){
        this.color=color;
    }

    public void setModelo(string modelo){
        if(modelo.Equals("A50") || modelo.Equals("A20") || modelo.Equals("A30"))
    {
        this.modelo=modelo;
    }
    else 
    Console.WriteLine("\n MODELO NO POSIBLE");
    Console.WriteLine("Modelos disponibles: A50, A20, A30");
    Console.WriteLine("Debe introducir de nuevo modelo:" + modelo);
    this.modelo="";
    }
    
    
    public void setCantidadCamaras(int cantidadCamaras){
    if(cantidadCamaras>=1 && cantidadCamaras<=8)
    {
        this.cantidadCamaras=cantidadCamaras;
    }
    else 
    Console.WriteLine("\n CANTIDAD DE CAMARAS NO POSIBLE");
    Console.WriteLine("Cantidad maxima= 8");
    Console.WriteLine("Debe introducir de nuevo cantidad de camaras:"+ cantidadCamaras);
    
    }

    public void setSize(int size){
    if(size>=1 && cantidadCamaras<=7)
    {
        this.size=size;
    }
    else 
    Console.WriteLine("\n TAMAÑO NO POSIBLE");
    Console.WriteLine("Tamaño maximo= 7");
    Console.WriteLine("Debe introducir de nuevo tamaño;"+size);
    
    }

    public void setEstado(string estado){
    if(estado.Equals("Encendido") || estado.Equals("Suspendido ") || estado.Equals("Apagado"))
    {
        this.estado=estado;
    }
    else 
    Console.WriteLine("\n ESTADO NO POSIBLE");
    Console.WriteLine("Estados disponibles: Encendido, Suspendido, Apagado");
    Console.WriteLine("Debe introducir de nuevo estado:" + estado);
    this.estado="";
    }

    //CREAMOS LOS GETS

    public string getMarca(){
        return this.marca;
    }

    public string getColor(){
        return this.color;
    }
    
    public string getModelo(){
        return this.modelo;
    }

    public int getCantidadCamaras(){
        return this.cantidadCamaras;
    }

    public int getSize(){
        return this.size;
    }
    
     public string getEstado(){
        return this.estado;
    }
}

class TelefonoMovilTest{
    public static void Main(){
        TelefonoMovil miCelular = new TelefonoMovil();
        miCelular.llamar("");
        miCelular.setMarca("Samsung");
        miCelular.setColor("Negro");
        miCelular.setModelo("A50");
        miCelular.setCantidadCamaras(1000);
        miCelular.setSize(6);
        miCelular.setEstado("Sumergido en agua");
        
        Console.WriteLine("\n*** Salida ***\n");
        Console.WriteLine("Marca:            " + miCelular.getMarca());
        Console.WriteLine("Color:            " + miCelular.getColor());
        Console.WriteLine("Modelo:           " + miCelular.getModelo());
        Console.WriteLine("Cantidad Camaras: " + miCelular.getCantidadCamaras());
        Console.WriteLine("Tamaño:           " + miCelular.getSize());
        Console.WriteLine("Estado:           " + miCelular.getEstado());     
    }
}
