// ChunLi corregido, la clase era un copypaste de Ryu.
using System;
using UnityEngine;


public class ChunLi : Luchador
{   
    public GameObject projectilePrefab;
    public Transform firePoint;  
    private float facingDirection = 1f;  // 1 = derecha, -1 = izquierda
    private const int CostoKikoken = 25;
    private int velocidadKikoken = 2;

    public ChunLi(string nombre, int barraSalud, int barraKi)
        : base(nombre, barraSalud, barraKi)
    {
    }

    public override void EjecutarEspecial()
    {
        if (barraKi >= CostoKikoken)
        {
            barraKi -= CostoKikoken;

            Console.WriteLine($"{nombre} lanza: ¡KIKOKEN!");
            Console.WriteLine($"Velocidad del Kikoken: {velocidadKikoken}x");
            Console.WriteLine($"Ki restante: {barraKi}");
            
            GameObject proj = Instantiate (projectilePrefab, firePoint.position, Quaternion.identity);
            proj.GetComponent<Projectile>().Launch(Vector2.right * facingDirection);
        }
        else
        {
            Console.WriteLine($"{nombre} no tiene Ki suficiente para el Kikoken.");
            Console.WriteLine($"Ki actual: {barraKi}, necesita {CostoKikoken}");
        }
    }


}
