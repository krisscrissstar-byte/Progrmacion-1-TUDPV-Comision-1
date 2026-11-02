
using UnityEngine;

public class SprayPrimerosAuxilios : ConsumibleSurvival
{
    private bool usado;

    public SprayPrimerosAuxilios(string nombre) : base(nombre)
    {
        usado = false;
    }

    public override void Consumir(Superviviente s)
    {
        if (!usado)
        {
            s.RestaurarSaludCompleta();
            usado = true;

            Debug.Log("Salud restaurada al 100%.");
        }
        else
        {
            Debug.Log("El spray ya fue utilizado.");
        }
    }
}

