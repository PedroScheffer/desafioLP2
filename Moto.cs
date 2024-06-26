public class Moto : Veiculo
{
    public override void Acelerar()
    {
        velocidade = velocidade + 15;
        Console.WriteLine("A moto está acelerando");
    }
    public override void Frear()
    {
        velocidade = velocidade - 10;
        Console.WriteLine("A moto está freando");
    }
}