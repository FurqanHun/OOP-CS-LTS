namespace L8_a;

class Program
{
    static void Main(string[] args)
    {
        Vehicle C = new Car("Toyota", "Red", "V8", 4);
        C.printInfo();
        C.start();
        C.run();
        C.calculateSpeed();
        C.stop();

        Vehicle B = new Bike("Yamaha", "Blue", "V4", 0);
        B.printInfo();
        B.start();
        B.run();
        B.calculateSpeed();
        B.stop();
        
    }
}
