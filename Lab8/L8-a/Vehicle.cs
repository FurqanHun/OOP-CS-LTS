namespace L8_a;

public class Vehicle
{
    string model;
    string color;
    string engine;
    int door; 

    public Vehicle()
    {

    }
    public Vehicle(string model, string color, string engine, int door)
    {
        this.model = model;
        this.color = color;
        this.engine = engine;
        this.door = door;
    }

    public void start(){
        Console.WriteLine("Starting...");
    }
    public void stop(){
        Console.WriteLine("Stopping...");
    }
    public void run(){
        Console.WriteLine("Running...");
    }
    public virtual void calculateSpeed(){
        System.Console.WriteLine("HAHA choose a vehicle type first brotha");
    }
   public void printInfo(){
        System.Console.WriteLine("\n\n--Vehicle Information--\n");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Engine: " + engine);
        Console.WriteLine("Door: " + door);
    }
}

public class Car : Vehicle{

    public Car(string model, string color, string engine, int door) : base(model, color, engine, door){

    }
   public override void calculateSpeed(){
        Console.WriteLine("Current Car Speed: 100km/h \n\nSlow down your CAR...\n");
    }
}

public class Bike : Vehicle{

    public Bike(string model, string color, string engine, int door) : base(model, color, engine, door){

    }
   public override void calculateSpeed(){
        Console.WriteLine("Current Bike Speed: 40km/h \n\nSpeed up your BIKE mate...\n");
    }
}