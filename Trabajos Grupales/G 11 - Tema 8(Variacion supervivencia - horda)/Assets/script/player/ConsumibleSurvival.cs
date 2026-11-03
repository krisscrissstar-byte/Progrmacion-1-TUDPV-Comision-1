using UnityEngine;

public class ConsumibleSurvival
{
    protected string nombre;

    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nombre = value;
        }
    }

    public ConsumibleSurvival(string nombre)
    {
        this.Nombre = nombre;
    }

    public virtual void Consumir(Superviviente s)
    {
        Debug.Log("Usando " + Nombre);
    }




}
