using UnityEngine;

public class EspadaMaestra : ItemZelda
{
    public int DanioSagrado { get; private set; }

    public EspadaMaestra(string nombre, int durabilidad, int danioSagrado) 
        : base(nombre, durabilidad)
    {
        this.DanioSagrado = danioSagrado;
    }

    public override void Usar(Link usuario)
    {
        if (Durabilidad <= 0) return;
        ReducirDurabilidad(1);
    }
}