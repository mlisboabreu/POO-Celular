using Smart;

public class Program
{
    public static void Main(string[] args)
    {
        Nokia nokia1 = new Nokia();
        nokia1.Num = "985184521";
        nokia1.Imei = "0987656890";
        nokia1.Modelo = "lumia34";
        nokia1.Memoria = 32;
        nokia1.InstalarAplicativo("instagram");
    }
}