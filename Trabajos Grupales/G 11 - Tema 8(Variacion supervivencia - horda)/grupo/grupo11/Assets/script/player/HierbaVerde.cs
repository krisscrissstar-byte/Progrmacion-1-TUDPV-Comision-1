
using UnityEngine;

public class HierbaVerde : ConsumibleSurvival
{
    public HierbaVerde(string nombre) : base(nombre)
    {
    }

    public override void Consumir(Superviviente s)
    {
        // aqui estamos llamando el metodo Recuperar del superviviente // superviviente = s//
        s.RecuperarSalud(40);
        s.CurarEnvenenamiento();

        Debug.Log("Recuperaste 40 puntos de salud.");
        Debug.Log("El envenenamiento fue curado.");
    }
}

