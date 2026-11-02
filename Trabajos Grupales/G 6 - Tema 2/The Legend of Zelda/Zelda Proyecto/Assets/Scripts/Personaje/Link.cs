using UnityEngine;
using System;

public class Link
{
    private const int CapacidadInventario = 6;

    private string nombre;
    private int corazones;
    private ItemZelda[] inventario;

    public string Nombre
    {
        get { return this.nombre; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre de Link no puede estar en blanco.");
            this.nombre = value;
        }
    }

    public int MaxCorazones { get; }

    public int Corazones
    {
        get { return this.corazones; }
        private set
        {
            if (value < 0 || value > this.MaxCorazones)
                throw new ArgumentOutOfRangeException(nameof(value), "Los corazones deben estar entre 0 y el máximo.");
            this.corazones = value;
        }
    }

    public bool TieneSaludMaxima { get { return this.corazones == this.MaxCorazones; } }
    public bool EstaVivo { get { return this.corazones > 0; } }

    public Link(string nombre, int maxCorazones)
    {
        this.Nombre = nombre;
        if (maxCorazones <= 0)
            throw new ArgumentOutOfRangeException(nameof(maxCorazones), "Link debe tener al menos un corazón máximo.");
        this.MaxCorazones = maxCorazones;
        this.Corazones = maxCorazones;
        this.inventario = new ItemZelda[CapacidadInventario];
    }

    public void Equipar(ItemZelda item, int slot)
    {
        this.ValidarSlot(slot);
        if (item == null) throw new ArgumentNullException(nameof(item));
        this.inventario[slot] = item;
        
        // CORRECCIÓN: Debug.Log para que se vea reflejado en el editor de Unity
        Debug.Log($"{this.Nombre} equipó {item.Nombre} en el espacio {slot}.");
    }

    // Lo usan los cofres. Devuelve false si el inventario está lleno.
    public bool AgregarItem(ItemZelda item)
    {
        if (item == null) throw new ArgumentNullException(nameof(item));
        for (int i = 0; i < this.inventario.Length; i++)
        {
            if (this.inventario[i] == null)
            {
                this.Equipar(item, i);
                return true;
            }
        }
        Debug.Log("Inventario lleno.");
        return false;
    }

    public ItemZelda ObtenerItem(int slot)
    {
        this.ValidarSlot(slot);
        return this.inventario[slot];
    }

    public void AccionarItem(int slot)
    {
        this.ValidarSlot(slot);
        ItemZelda item = this.inventario[slot];

        if (item == null)
        {
            Debug.Log($"El espacio {slot} del inventario está vacío");
            return;
        }

        item.Usar(this);
    }

    public void RecibirDanio(int cantidad)
    {
        if (cantidad < 0)
            throw new ArgumentOutOfRangeException(nameof(cantidad), "El daño no puede ser negativo.");
        this.Corazones = Math.Max(0, this.Corazones - cantidad);
        Debug.Log($"{this.Nombre} recibió {cantidad} de daño. Corazones: {this.Corazones}/{this.MaxCorazones}");
    }

    private void ValidarSlot(int slot)
    {
        if (slot < 0 || slot >= this.inventario.Length)
            throw new ArgumentOutOfRangeException(nameof(slot), $"El espacio debe estar entre 0 y {this.inventario.Length - 1}.");
    }
}
