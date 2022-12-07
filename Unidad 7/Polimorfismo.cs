using System;
//clase abstracta
abstract class Animal{
    protected int legs=0;

    protected Animal(int legs){}
     public virtual void walk(){
        Console.WriteLine("\nEl animal camina");
     }
     abstract public void eat();
}

//Interface Pet
interface Pet{
    string getName();
    void setName(string n);
    void play();
}

//Clase derivada de Animal
class Spider: Animal{
    public Spider(int legs):base(legs){}

    public override void eat()
    {
       Console.WriteLine("\nUna araña come");
    }
}

//Clase derivada de Animal e implementando la interface Pet
class Cat: Animal, Pet{
    private string name;

    public Cat(string n, int legs):base(legs){}
    public Cat(int legs):base(legs){}
    
    public string getName(){
        
        return name;
    }
    

    public void setName(string n){
        
        this.name = n;
    }
    
    void Pet.play(){
        Console.WriteLine("\nUna mascota juega");
    }
    public void play(){
        if(name.Equals("")){
        Console.WriteLine("\nUn gato juega");
        }
        
        else
        Console.WriteLine("\n{0} juega",name);
    }

    public override void eat(){
        if(name.Equals("")){
        Console.WriteLine("\nUn gato come");
        }
        
        else
        Console.WriteLine("\n{0} come",name);
    }
}

//Clase derivada de Animal e implementando la interface Pet
class Fish: Animal, Pet{
    private string name;

    public Fish(int legs):base(legs){}

    public string getName(){
        return name;
    }

    public void setName(string n){
        this.name = n;
    }

    public void play(){
        Console.WriteLine("\nUn pez juega");
    }

    public override void walk(){
        Console.WriteLine("\nUn pez camina");
    }

     public override void eat(){
        Console.WriteLine("\nUn pez come");
    }
}

//clase Tester

class Polimorfismo{
    static void Main(){

        //Inicializamos a Animal a traves de Spider
        (new Spider(8)).walk();
        
        Console.WriteLine("------------------------------");
        //Inicializamos a Spider
        Spider spi = new Spider(8);
        spi.eat();
        

        Console.WriteLine("------------------------------");
        //Inicializamos a Cat 1
        Cat gat1 = new Cat(4);
        gat1.setName("");
        gat1.getName();
        gat1.play();
        gat1.eat();
        
        Console.WriteLine("------------------------------");
        //Inicializamos a Cat 2
        Cat gat2 = new Cat("",4);
        gat2.setName("Nini");
        gat2.getName();
        gat2.play();
        gat2.eat();

        Console.WriteLine("------------------------------");
        //Inicializamos a Pet desde Cat 1
        Pet mascota = (Pet)gat1;
        mascota.setName("");
        mascota.getName();
        mascota.play();

        Console.WriteLine("------------------------------");
        //Inicializamos a Fish
        Fish fish = new Fish(0);
        fish.setName("Peque");
        fish.getName();
        fish.play();
        fish.walk();
        fish.eat();
        
    }
}