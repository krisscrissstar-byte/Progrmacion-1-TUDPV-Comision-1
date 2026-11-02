
using UnityEngine;

public class AranaMazmorra : MonoBehaviour
{
    [Header("Referencias")]
    [SerializeField] private Transform jugador;

    [Header("Patrulla")]
    [SerializeField] private float radioPatrulla = 5f;
    [SerializeField] private float velocidadPatrulla = 2f;

    [Header("Persecucion")]
    [SerializeField] private float distanciaDeteccion = 8f;
    [SerializeField] private float velocidadPersecucion = 4f;

    [Header("Ataque")]
    [SerializeField] private float distanciaAtaque = 2.5f;
    [SerializeField] private int daño = 15;
    [SerializeField] private float preparacionAtaque = 1f;
    [SerializeField] private float descansoAtaque = 2.5f;

    private Vector3 puntoInicial;
    private Vector3 destinoPatrulla;

    private float temporizador;

    private enum Estado
    {
        Patrullando,
        Persiguiendo,
        PreparandoAtaque,
        Descansando
    }

    private Estado estado = Estado.Patrullando;

    private void Start()
    {
        puntoInicial = transform.position;
        ElegirDestino();

        if (jugador == null)
        {
            GameObject obj = GameObject.FindGameObjectWithTag("Player");

            if (obj != null)
                jugador = obj.transform;
        }
    }

    private void Update()
    {
        if (jugador == null) return;

        float distancia = Vector3.Distance(
            transform.position,
            jugador.position
        );

        switch (estado)
        {
            case Estado.Patrullando:
                Patrullar();

                if (distancia <= distanciaDeteccion)
                    estado = Estado.Persiguiendo;
                break;

            case Estado.Persiguiendo:
                if (distancia > distanciaDeteccion)
                {
                    estado = Estado.Patrullando;
                    ElegirDestino();
                }
                else if (distancia <= distanciaAtaque)
                {
                    estado = Estado.PreparandoAtaque;
                    temporizador = preparacionAtaque;
                }
                else
                {
                    MoverHacia(jugador.position, velocidadPersecucion);
                }
                break;

            case Estado.PreparandoAtaque:
                // La arana se detiene antes de atacar
                temporizador -= Time.deltaTime;
                MirarJugador();

                if (temporizador <= 0f)
                {
                    if (distancia <= distanciaAtaque)
                        Atacar();

                    estado = Estado.Descansando;
                    temporizador = descansoAtaque;
                }
                break;

            case Estado.Descansando:
                // No persigue ni ataca durante el descanso
                temporizador -= Time.deltaTime;

                if (temporizador <= 0f)
                {
                    estado = distancia <= distanciaDeteccion
                        ? Estado.Persiguiendo
                        : Estado.Patrullando;
                }
                break;
        }
    }

    private void Patrullar()
    {
        MoverHacia(destinoPatrulla, velocidadPatrulla);

        if (Vector3.Distance(
            transform.position, destinoPatrulla
        ) < 0.3f)
        {
            ElegirDestino();
        }
    }

    private void ElegirDestino()
    {
        Vector2 punto = Random.insideUnitCircle * radioPatrulla;

        destinoPatrulla = puntoInicial +
            new Vector3(punto.x, 0f, punto.y);
    }

    private void MoverHacia(Vector3 destino, float velocidad)
    {
        Vector3 direccion = destino - transform.position;
        direccion.y = 0f;

        if (direccion.sqrMagnitude < 0.01f)
            return;

        transform.position = Vector3.MoveTowards(
            transform.position,
            transform.position + direccion,
            velocidad * Time.deltaTime
        );

        Quaternion rotacion = Quaternion.LookRotation(direccion);

        transform.rotation = Quaternion.RotateTowards(
            transform.rotation,
            rotacion,
            360f * Time.deltaTime
        );
    }

    private void MirarJugador()
    {
        Vector3 direccion = jugador.position - transform.position;
        direccion.y = 0f;

        if (direccion.sqrMagnitude < 0.01f)
            return;

        Quaternion rotacion = Quaternion.LookRotation(direccion);

        transform.rotation = Quaternion.RotateTowards(
            transform.rotation,
            rotacion,
            180f * Time.deltaTime
        );
    }

    private void Atacar()
    {
        GuerreroController controller =
            jugador.GetComponent<GuerreroController>();

        if (controller != null)
        {
            controller.RecibirDanio(daño);
            Debug.Log("AranaMazmorra ha atacado");
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(
            transform.position, distanciaDeteccion
        );

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(
            transform.position, distanciaAtaque
        );
    }
}
