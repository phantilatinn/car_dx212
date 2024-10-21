using System;

namespace MauiAppCSharp.Classes;

public class Car
{
    public string Model;
    public string Color;
    public double Speed;
    public double Fuel;
    public double TotalMile;
    public double UseFuelRate;

    public Car(string model , double speed , double fuel)
    {
        this.Model = model;
        this.Speed = speed;
        this.Fuel = fuel;
    }
    public void Run(double mile)
    {
        this.TotalMile += mile;
        var use_fuel = mile * this.UseFuelRate;
        this.Fuel = this.Fuel - use_fuel;

    }

    public uint TimeUseForRun(double mile)
    {
        var timeuse = mile/Speed;
        this.Run(mile);
        return Convert.ToUInt16(timeuse);
    }

    public string ShowInfo()
    {
        var info = $"Model : { this.Model } \nTotal Mile : { this.TotalMile } \nFuel : {this.Fuel }";
        return info;
    }
}