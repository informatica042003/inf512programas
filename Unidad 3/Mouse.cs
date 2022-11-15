using System;

public class Mouse{
    private string marca; //Marcas permitidos: Dell, Genius, Logitec
    private string modelo;
    private string tipo; // Tipos permitidos: normal, ergonomico
    private string color; //Colores permitidos: Rojo, Verde, Azul.
    private bool ergonomico;
    private float precio;

    public Mouse(){}

    public bool seleccionar(string bloqueTexto){
        return true;
    }

    public bool clickDerecho(){
        Console.WriteLine("El usuario ha hecho un click derecho");
        return true;
    }

    public bool clickIzquierdo(){
        Console.WriteLine("El usuario ha hecho un click izquierdo");
        return true;
    }

    public string arrastrar(string bloqueTexto){
        return "";
    }

       
      public void setColor(string color){
        color = color.ToUpper();
        if (color.Equals("ROJO") || color.Equals("VERDE") || color.Equals("AZUL")){
            this.color = color;
        } else {
            Console.WriteLine("Error 2. Color Invalido.");
            Console.WriteLine("Colores permitidos: ROJO, VERDE, AZUL.");
            Console.WriteLine("Debe corregir color: " + color);
            this.color = null;
        }
         
    }
    public void setPrecio(float precio){
        if (precio >= 0.0 && precio <=50.0){
            this.precio = precio;
        } else {
            this.precio = 0.0f;
            Console.WriteLine("Error 1. Precio Invalido.");
        }
    }
       public void setModelo(string modelo){
          this.modelo= modelo;
       }

       public void setMarca(string marca){
           if (marca.Equals("Dell") || marca.Equals("Genius") || marca.Equals("Logitec")){
            this.marca = marca;
        } else {
            this.marca = "Generic Device";
        }
         
       }

       public void setTipo(string tipo){
       if (tipo.Equals("Normal")){
            this.tipo = tipo;
            this.ergonomico=false;
        } else {
            this.tipo= tipo;
            this.ergonomico=true;
        }

       }

    public float getPrecio(){
        return this.precio;
    }

      
      public string getMarca(){
        return this.marca;}

  
    public string getColor(){
        return this.color.ToLower();}

        public string getModelo(){
        return this.modelo;}

        public string getTipo(){
        return this.tipo;}

        public bool getErgonomico(){
        return this.ergonomico;}
    
   
    public void desplegarInformacion(){
        Console.WriteLine("Marca: " + getMarca());
        Console.WriteLine("Modelo: " + getModelo());
        Console.WriteLine("Tipo: " + getTipo());
        Console.WriteLine("Color: " + getColor());
        Console.WriteLine("Ergonomico: " + getErgonomico());
        Console.WriteLine("Precio: " + getPrecio());


    }
}

public class MouseTest{
    static void Main(){
        
        Mouse raton1 = new Mouse(); 
        raton1.setMarca("Dell");
        raton1.setModelo("WM126");
        raton1.setPrecio(18.99f);
        raton1.setColor("rojo");
        raton1.setTipo("Ergonomico");
        raton1.desplegarInformacion();
    }
}