using TP_POO_I___II.Clases;

namespace TP_POO_I___II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personaje guerrero = new Guerrero("Juan", 50, 15);
            Personaje mago = new Mago("Sergio", 35, 10);

            Personaje[] grupo = { guerrero, mago };

            while (mago.EstaVivo() && guerrero.EstaVivo())
            {
                grupo[0].Atacar(mago);
                if(!mago.EstaVivo()) break;
                grupo[1].Atacar(guerrero);
            }
        }
    }
}
