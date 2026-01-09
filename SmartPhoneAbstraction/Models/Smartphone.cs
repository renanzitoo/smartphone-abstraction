namespace SmartPhoneAbstraction.Models;

public abstract class Smartphone
{
    public string Number { get; set; }
    public string Model  { get; set; }
    public string Imei  { get; set; }
    public int Memory { get; set; }
    
    private Random random;

    public Smartphone(string number, string model, string imei, int memory)
    {
        Number = number;
        Model = model;
        Imei = imei;
        Memory = memory;
        
        random = new Random();
    }

    public bool Call()
    {
        if (random.Next(1, 11) >= 5)
        {
            return  true;
        }
        else
        {
            return false;
        }
    }

    public bool receiveCall()
    {
        if (random.Next(1, 11) >= 5)
        {
            return  true;
        }
        else
        {
            return false;
        } 
    }

    public abstract void InstallApp(string nomeApp);
}