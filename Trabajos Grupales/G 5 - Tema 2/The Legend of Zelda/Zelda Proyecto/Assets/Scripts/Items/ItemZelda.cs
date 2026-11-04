using UnityEngine;

public abstract class ItemZelda
{
    public string Nombre { get; protected set; }
    public int Durabilidad { get; protected set; }

    public ItemZelda(string nombre, int durabilidad)
    {
        this.Nombre = nombre;
        this.Durabilidad = durabilidad;
    }

    public abstract void Usar(Link usuario);

    protected void ReducirDurabilidad(int cantidad)
    {
        this.Durabilidad = Mathf.Max(0, this.Durabilidad - cantidad);
        if (this.Durabilidad == 0)
        {
            Debug.Log($"¡El objeto {Nombre} se ha roto!");
        }
    }
}