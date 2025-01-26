using System;

class Program
{
    static void Main(string[] args)
    {
        Car mycar = new Car();
        Console.WriteLine($"my car default model is :{mycar.carModel}");
        mycar.carModel = "my second model car";
        Console.WriteLine($"my change model is :{mycar.carModel}");
        Console.WriteLine($"my car default price is :{mycar.IrPrice}");
        mycar.IrPrice = 351;
        Console.WriteLine($"my change price is :{mycar.IrPrice}");
        Console.WriteLine($"my car default brand is :{mycar.srBrand}");
        Console.WriteLine($"my car default year is :{mycar.IrYear}");
        
        mycar.IrYear = 3000;
        Console.WriteLine($"my change year is :{mycar.IrYear}");

        // Wait for user input to close  
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

class Car
{
    public string carModel = "Default Car";
    public string srBrand;
    public int IrPrice { get; set; }

    private int _irYear = 1999;

    public int IrYear
    {
        get
        {
            if (_irYear < 2000)
                return 2000;
            return _irYear;
        }
        set
        {
            _irYear = value - 10;
            if (_irYear > 3000)
                _irYear = 3000;
            
        }
    }
}