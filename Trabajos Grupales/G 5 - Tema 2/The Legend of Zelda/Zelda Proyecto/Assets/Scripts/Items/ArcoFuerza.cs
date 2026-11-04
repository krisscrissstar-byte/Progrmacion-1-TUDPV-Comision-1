using UnityEngine;

public class ArcoFuerza : ItemZelda
{
    public int FlechasDisponibles { get; private set; }

    public ArcoFuerza(string nombre, int durabilidad, int flechas) 
        : base(nombre, durabilidad)
    {
        this.FlechasDisponibles = flechas;
    }

    public override void Usar(Link usuario)
    {
        if (Durabilidad <= 0 || FlechasDisponibles <= 0) return;
        FlechasDisponibles--;
        ReducirDurabilidad(1);
    }
}