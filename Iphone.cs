using Smart;

public class Iphone : SmartPhone
{
    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando {nome} no seu Iphone {Modelo}");
    }
}
