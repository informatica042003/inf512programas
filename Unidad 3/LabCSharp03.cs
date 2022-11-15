using System;

class Prestatario{

    private string bien;
    private double cuota;
    private double principal;
    private double interes;
    private int plazo;

    public Prestatario(){}
 
    public void pedirBien(double principal, double interes, string bien){
        this.principal=principal;
        this.interes=interes;
        this.bien=bien;
    }

    public void devolverBien(){}

    public void pagarCuota(double cuota, int plazo){
          this.cuota=cuota;
          this.plazo=plazo;

    }
}

class TesterPrestatario{

    static void Main(){

        Prestatario prestatario1= new Prestatario();
        prestatario1.pedirBien(0.0,0.0,"");
        prestatario1.devolverBien();
        prestatario1.pagarCuota(0.0,0);
    }
}