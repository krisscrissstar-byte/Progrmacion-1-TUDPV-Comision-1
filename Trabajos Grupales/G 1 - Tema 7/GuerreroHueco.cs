public abstract class GuerreroHueco
{
    protected string nombre;
    protected int salud;
    protected int stamina;

    public string Nombre { get => nombre; }
    public int Salud { get => salud; protected set => salud = value < 0 ? 0 : value; }
    public int Stamina { get => stamina; protected set => stamina = value < 0 ? 0 : value; }

    public GuerreroHueco(string nombre, int salud, int stamina)
    {
        this.nombre = nombre;
        this.Salud = salud;
        this.Stamina = stamina;
    }

    public abstract void Esquivar();

    public virtual void Atacar()
    {
        if (stamina >= 20)
        {
            stamina -= 20;
            Console.WriteLine($"{nombre} ataca con su arma gastando 20 de stamina. Stamina restante: {stamina}");
        }
        else
        {
            Console.WriteLine($"{nombre} no tiene suficiente stamina para atacar.");
        }
    }

    public void RestablecerAtributos(int saludMax, int staminaMax)
    {
        this.salud = saludMax;
        this.stamina = staminaMax;
    }
}