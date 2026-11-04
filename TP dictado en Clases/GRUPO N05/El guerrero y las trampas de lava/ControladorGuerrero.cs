using UnityEngine;

public class ControladorGuerrero : MonoBehaviour
{
    public string nombreGuerrero = "Guerrero";
    public int vidaMax = 100;
    public int escudoInicial = 30;
    public float velocidad = 5f;
    public int danioTrampa = 20;
    public int curacionPocion = 25;

    private GuerreroLogico guerrero;

    void Start()
    {
        guerrero = new GuerreroLogico(nombreGuerrero, vidaMax, escudoInicial);
    }

    void Update()
    {
        if (guerrero.EstaVivo == false)
        {
            return;
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(horizontal, vertical, 0);
        transform.Translate(movimiento * velocidad * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Trampa"))
        {
            guerrero.RecibirDanio(danioTrampa);
            Debug.Log("Escudo: " + guerrero.Escudo + " | Vida: " + guerrero.VidaActual);

            if (guerrero.EstaVivo == false)
            {
                Debug.Log(guerrero.Nombre + " murio");
            }
        }

        if (otro.CompareTag("Pocion"))
        {
            guerrero.Curar(curacionPocion);
            Debug.Log("Vida: " + guerrero.VidaActual);
            Destroy(otro.gameObject);
        }
    }
}
