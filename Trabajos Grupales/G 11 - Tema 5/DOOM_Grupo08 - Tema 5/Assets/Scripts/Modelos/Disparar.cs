using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject prefabBala;
    public Transform puntoDisparo;

    private PlayerController jugador;

    void Awake()
    {
        jugador = GetComponent<PlayerController>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (jugador != null &&
                jugador.IntentarUsarMunicion(1))
            {
                Instantiate(
                    prefabBala,
                    puntoDisparo.position,
                    puntoDisparo.rotation
                );
            }
        }
    }
}