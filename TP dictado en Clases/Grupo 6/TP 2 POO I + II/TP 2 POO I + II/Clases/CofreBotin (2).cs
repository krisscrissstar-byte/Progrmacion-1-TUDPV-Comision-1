using System;
using System.Collections.Generic;
using System.Text;

namespace TP_2_POO_I___II.Clases
{
    internal class CofreBotin
    {
        private bool _abierto;

        private Item[] itemsContenidos = new Item[2];

        public CofreBotin(Item item1, Item item2)
        {
            itemsContenidos[0] = item1;
            itemsContenidos[1] = item2;
        }
        public void Abrir()
        {
            if (!_abierto)
            {
                for (int i = 0; i < itemsContenidos.Length; i++)
                {
                    itemsContenidos[i].Usar();
                }
            }
        }
    }
}
