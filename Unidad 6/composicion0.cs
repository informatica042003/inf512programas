using System;
using System.Collections.Generic;
class Cuarto{
    string tipo;
    double area; //metros cuadrados
    bool amueblado;
    byte cantidad;

    public Cuarto(string tipo, double area, bool amueblado, byte cantidad){
        this.tipo = tipo;
        this.area = area;
        this.amueblado = amueblado;
        this.cantidad = cantidad;
    }

    public void getCuarto(){
        Console.WriteLine("\n" + tipo + "\n" + area + "Metros Cuadrados\n" + 
                 amueblado + "\nCantidad " + cantidad);
    }
}

class Casa{
    string nombre;
    List<Cuarto> listaCuartos;

    public Casa(string nombreCasa){
        nombre = nombreCasa;
        listaCuartos = new List<Cuarto>(); //Al crear la Casa se crean los Cuartos
    }

    public void setCuarto(string tipo, double area, bool amueblado, byte cantidad){
        listaCuartos.Add(new Cuarto(tipo, area, amueblado, 2));
    }

    public void verCuartos(){
        for(int i =0; i < listaCuartos.Count; ++i){
            listaCuartos[i].getCuarto();
        }
    }
}

class Tester{
    static void Main(string[] args){
        Casa miCasa = new Casa("\nFamilia Ferreiras-Ovalle");
        miCasa.setCuarto("Dormitorio principal", 75.45, true, 2);
        miCasa.setCuarto("Dormitorio secundario", 50, true, 3);
        miCasa.setCuarto("Bano secundario", 11.73, true, 4);
        miCasa.setCuarto("Sala de estudio", 8.33, true, 2);
        miCasa.setCuarto("Gimnasio", 50, false, 1);
        miCasa.setCuarto("Sala principal", 35, true, 2);
        miCasa.setCuarto("Cuarto para conserje", 10.5, true, 1);      
        miCasa.verCuartos();     

        miCasa = null; // casa destruida
        //  miCasa.verCuartos();   // Ver NOTA # 1
    }
}