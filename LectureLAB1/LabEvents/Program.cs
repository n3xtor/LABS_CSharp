using System;

class Sun
{
    public event EventHandler<SunEventArgs> Sunrise;
    public event EventHandler<SunEventArgs> Sunset;

    public void Rise()
    {
        Console.WriteLine("The sun is rising.");
        Sunrise?.Invoke(this, new SunEventArgs("rise"));
    }

    public void Set()
    {
        Console.WriteLine("The sun is setting.");
        Sunset?.Invoke(this, new SunEventArgs("set"));
    }
}

class SunEventArgs : EventArgs
{
    public string State { get; }

    public SunEventArgs(string state)
    {
        State = state;
    }
}

class Flower
{
    private string _name;
    private int _daysToBloom;
    private bool _isBloomed;

    public Flower(string name, int daysToBloom)
    {
        _name = name;
        _daysToBloom = daysToBloom;
    }

    public void OnSunrise(object sender, SunEventArgs e)
    {
        if (e.State == "rise" && !_isBloomed)
        {
            Console.WriteLine($"{_name} is blooming.");
            _isBloomed = true;
        }
    }

    public void OnSunset(object sender, SunEventArgs e)
    {
        if (e.State == "set" && _isBloomed)
        {
            Console.WriteLine($"{_name} is closing.");
            _isBloomed = false;
            _daysToBloom--;
        }

        if (_daysToBloom == 0)
        {
            Console.WriteLine($"{_name} has withered.");
            (sender as Sun).Sunrise -= OnSunrise;
            (sender as Sun).Sunset -= OnSunset;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Sun sun = new Sun();

        Flower daisy = new Flower("Daisy", 3);
        Flower rose = new Flower("Rose", 5);

        sun.Sunrise += daisy.OnSunrise;
        sun.Sunset += daisy.OnSunset;

        sun.Sunrise += rose.OnSunrise;
        sun.Sunset += rose.OnSunset;

        for (int i = 0; i < 10; i++)
        {
            sun.Rise();
            sun.Set();
        }

        Console.ReadKey();
    }
}
