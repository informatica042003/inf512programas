using System;

//Clase Base abstracta
abstract class F{
    private string x="Ferreiras, Castro";
    private double y=12.34E+12;
    private long z=987364354;
    protected byte w=34;

    public F(string x, double y, long z, byte w){}

    public string getX(){
        return x;
    }

    public double getY(){
        return y;
    }

    public long getZ(){
        return z;
    }
     
     //Ver estado del objeto
    abstract public void verObjeto();
}

//Clase derivada
class G: F{
    private int s=9998833;
    public G(string x, double y, long z, byte w): base (x, y, z, w){}
    public override void verObjeto(){
        Console.WriteLine("El valor de x: "+ getX());
        Console.WriteLine("El valor de y: "+ getY());
        Console.WriteLine("El valor de z: "+ getZ());
        Console.WriteLine("El valor de w: "+ w);
          Console.WriteLine("El valor de s: "+ s);
    }

}
//Tester Class

class TesterClass{
    static void Main(){
        G testerClass=new G("",0,0,0);
        testerClass.verObjeto();
    }
}