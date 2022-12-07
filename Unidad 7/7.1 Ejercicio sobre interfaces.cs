using System;
//clase base Animal
class Animal{
     public virtual void eat(){
         Console.WriteLine("\nEl animal come");
    }
}

//clase base Vehicle
public class Vehicle{}

//Interface Flyer
interface IFlyer{
    void takeOff();
    void land();
    void fly();
}

//clase derivada de Animal e implementando a la interface IFlyer
class Bird : Animal, IFlyer{
   
    
    public void takeOff(){
        Console.WriteLine("\nEl ave despegó desde Flyer");
    }
    public void land(){
        Console.WriteLine("\nEl ave aterrizó desde Flyer");
    }
    public void fly(){
        Console.WriteLine("\nEl ave vuela desde Flyer");
    }
    public void buildNest(){
        Console.WriteLine("\nEl ave construye un nido");
    }
    public void layEggs(){
        Console.WriteLine("\nEl ave deja sus huevos");
    }
    public override void eat(){
        Console.WriteLine("\nEl ave come");
    }
}

//clase derivada de Animal
class Kriptonian : Animal{
   
}


//clase derivada de Kriptonian e implementando a la interface IFlyer
class Superman : Kriptonian,IFlyer{
    
    public   void takeOff(){
        Console.WriteLine("\nSuperman despega desde Flyer");
    }
    public  void land(){
         Console.WriteLine("\nSuperman aterriza desde Flyer");
    }
    public  void fly(){
         Console.WriteLine("\nSuperman vuela desde Flyer");
    }
    public void leapBuilding(){
         Console.WriteLine("\nSuperman sostiene un edificio");
    }
    public  void stopBullet(){
        Console.WriteLine("\nSuperman para una bala");
    }
    public override void eat(){
         Console.WriteLine("\nSuperman come");
    }
}

//clase derivada de Vehicle e implementando a la interface IFlyer
public class Airplane: Vehicle, IFlyer{
    
    void IFlyer.takeOff(){Console.WriteLine("\nUn objeto despega");}
    void IFlyer.land(){Console.WriteLine("\nUn objeto aterriza");}
    void IFlyer.fly(){Console.WriteLine("\nUn objeto vuela");}


    public void takeOff(){Console.WriteLine("\nEl avión despega desde IFlyer");}
    public void land(){Console.WriteLine("\nEl avión aterriza desde IFlyer");}
    public void fly(){Console.WriteLine("\nEl avión vuela desde IFlyer");}
}

//clase derivada de Airplane
class Seaplane: Airplane{}

//clase derivada de Airplane
class Helicopter: Airplane{}



//clase Tester
class Tester{
    static void Main(){
        
        //Inicializamos a Animal
        Animal ani = new Animal();
        Console.WriteLine("\nUn animal");
        ani.eat();
        
        Console.WriteLine("------------------------------");
        //Inicializamos a Kriptonian
         ani = new Kriptonian();
         Console.WriteLine("\nUn Kriptoniano");
        
        
        Console.WriteLine("------------------------------");
        //Inicializamos a Bird
         Bird brd = new Bird();
         Console.WriteLine("\nUn ave");
         ani = new Bird();
        (new Bird()).takeOff();
        (new Bird()).land();
        (new Bird()).fly();
        brd.buildNest();
        brd.layEggs();
        ani.eat();

        Console.WriteLine("------------------------------");
        //Inicializamos a Superman
        Superman sp = new Superman();
        Console.WriteLine("\nUn Superman");
        ani = new Superman();
        (new Superman()).takeOff();
        (new Superman()).land();
        (new Superman()).fly();
        sp.leapBuilding();
        sp.stopBullet();
        ani.eat();

        Console.WriteLine("------------------------------");
        //Inicializamos a Vehicle
        Vehicle vh = new Vehicle();
        Console.WriteLine("\nUn vehículo");

        Console.WriteLine("------------------------------");
        //Inicializamos a Airplane
        Airplane ap = new Airplane();
        Console.WriteLine("\nUn avión");
        (new Airplane()).takeOff();
        (new Airplane()).land();
        (new Airplane()).fly();

        Console.WriteLine("------------------------------");
        //Inicializamos a IFlyer
        IFlyer refSC = ap;
        Console.WriteLine("\nUn objeto");
        refSC.takeOff();
        refSC.land();
        refSC.fly();

        Console.WriteLine("------------------------------");
        //Inicializamos a Seaplane
        ap = new Seaplane();
        Console.WriteLine("\nUn avión de mar");

        Console.WriteLine("------------------------------");
        //Inicializamos a Helicopter
        ap = new Helicopter();
        Console.WriteLine("\nUn helicóptero");
        
    }
}