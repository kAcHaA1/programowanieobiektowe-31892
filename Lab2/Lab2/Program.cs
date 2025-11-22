/*
KontoBankowe konto = new KontoBankowe();
class KontoBankowe
{
    private double saldo;
    public void Wplata(double kwota) { saldo += kwota; }
    public void Wyplata(double kwota)
    {
        if (saldo > kwota)
        {
            saldo -= kwota;
        }
        else
        {
            Console.WriteLine("Nie masz wystarczająco pieniędzy na koncie");
        }
    }
    public double PobierzSaldo() { return saldo; }
}
*/ 
/*
zadanie 6

class Zwierze
{
    public void Jedz() => Console.WriteLine("Zwierzę je");
}
class Pies : Zwierze
{
    public void Szczekaj() => Console.WriteLine("Hau hau!");
}

class Kot: Zwierze
{
    public void Miaucz() => Console.WriteLine("Miau miau!");
}
class Program
{
    static void Main(string[] args)
    {
        Kot k = new Kot();
        k.Jedz();   
        k.Miaucz(); 
    }
}
*/
/*
zadanie 7
class Zwierze
{
    public virtual void DajGlos() => Console.WriteLine("Zwierzę wydaje dźwięk");
}

class Pies : Zwierze
{
    public override void DajGlos() => Console.WriteLine("Hau hau!");
}

class Kot : Zwierze
{
    public override void DajGlos() => Console.WriteLine("Miau!");
}

class Program
{
    static void Main(string[] args)
    {
       
        Zwierze[] zwierzeta = { new Pies(), new Kot(), new Pies(), new Zwierze() };

        foreach (Zwierze z in zwierzeta)
        {
            z.DajGlos(); 
        }
    }
}
*/