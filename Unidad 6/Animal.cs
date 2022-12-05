using System;
//clase base
class Animal{
     public virtual void eat(){
         Console.WriteLine("\nEl animal come");
    }
}

//clase derivada de Animal
class Bird : Animal{
   
    
    public void takeOff(){
        Console.WriteLine("\nEl ave despegó");
    }
    public void land(){
        Console.WriteLine("\nEl ave aterrizó");
    }
    public void fly(){
        Console.WriteLine("\nEl ave vuela");
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

//clase derivada de Kriptonian
class Superman : Kriptonian{
    
    public   void takeOff(){
        Console.WriteLine("\nSuperman despega");
    }
    public  void land(){
         Console.WriteLine("\nSuperman aterriza");
    }
    public  void fly(){
         Console.WriteLine("\nSuperman vuela");
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


//clase Tester
class Tester{
    static void Main(){
        
        //Inicializamos a Animal
        Animal ani = new Animal();
        ani.eat();
        
        Console.WriteLine("------------------------------");
        //Inicializamos a Kriptonian
         ani = new Kriptonian();
        
        
        Console.WriteLine("------------------------------");
        //Inicializamos a Bird
         Bird brd = new Bird();
         ani = new Bird();
        brd.takeOff();
        brd.land();
        brd.fly();
        brd.buildNest();
        brd.layEggs();
        brd.eat();

        Console.WriteLine("------------------------------");
        //Inicializamos a Superman
        Superman sp = new Superman();
        ani = new Superman();
        sp.takeOff();
        sp.land();
        sp.fly();
        sp.leapBuilding();
        sp.stopBullet();
        ani.eat();
    }
}