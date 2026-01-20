using System;
Bicycle vehicle = new Bicycle();
vehicle.Start();
vehicle.Stop();
vehicle.Maxspeed();
vehicle.FuelCapacity();
Console.WriteLine("------------------");
Transport vehicle1 = new Bicycle();
vehicle1.Maxspeed();
vehicle1.FuelCapacity();
public class Transport
{
    public string Stamp { get; set; }
    public int Horsepower { get; set; }
    public string Bodywork { get; set; }
    public string TransmissionBox { get; set; }
    public void Signal()
    {
        Console.WriteLine("Машина издаёт звук");
    }
    public void Turnleft()
    {
        Console.WriteLine("Машина поворачивает навлево");
    }
    public virtual void Start()
    {
        Console.WriteLine("Машина начинает движение");
    }

    public virtual void Stop()
    {
        Console.WriteLine("Машина останваливается");
    }

    public virtual void Maxspeed()
    {
        Console.WriteLine("Машина развивает максимальную скорость");
    }
    public virtual
        void FuelCapacity()
    {
        Console.WriteLine("Максимальная вместимость топливного бака");
    }

}

public class Bicycle : Transport
{
    public override void Start()
    {
        Console.WriteLine("Движение с помощью силы ног");
    }

    public override void Stop()
    {
        Console.WriteLine("Остановка с помощью силы ног или рук");
    }

    public bool HasGears { get; set; }
    public string BrakeType { get; set; }
    public new void Maxspeed()
    {
        Console.WriteLine("Велосипед едет изо всех сил");
    }
    public new void FuelCapacity()
    {
        Console.WriteLine("У велосипеда нет топливного бака");
    }
}
