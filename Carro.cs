public class Carro : Veiculo
{
    public override void Acelerar()
    {
        velocidade = velocidade + 10;
        Console.WriteLine("O Carro está acelerando");
    }
    public override void Frear()
    {
        velocidade = velocidade - 5;
        Console.WriteLine("O carro está freando");
    }
}