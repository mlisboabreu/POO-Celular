using Smart;

public class Nokia : SmartPhone
{
    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"instalando {nome} no seu Nokia {Modelo}");
    }
}