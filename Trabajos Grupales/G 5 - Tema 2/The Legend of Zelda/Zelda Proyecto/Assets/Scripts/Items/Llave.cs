using UnityEngine;

public class Llave : ItemZelda
{
    public Llave(string nombre) : base(nombre, 1) { }

    public override void Usar(Link usuario)
    {
        if (Durabilidad <= 0) return;
        ReducirDurabilidad(1);
    }
}