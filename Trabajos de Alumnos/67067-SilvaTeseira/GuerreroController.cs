using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class GuerreroController : MonoBehaviour
{
    [Header("Configuración del Personaje")]
    [SerializeField] private float saludInicial = 100f;
    [SerializeField] private float escudoInicial = 50f;
    [SerializeField] private float velocidadMovimiento = 6f;

    private GuerreroModel _modelo;
    private Rigidbody2D _rb;
    private Vector2 _inputMovimiento;

    public GuerreroModel Modelo => _modelo;

    private void Awake(){
        _rb = GetComponent<Rigidbody2D>();
        _modelo = new GuerreroModel(saludInicial, escudoInicial);
        _modelo.OnGuerreroMuerto += ManejarMuerte;
        _modelo.OnSaludCambiada += (actual, max) => Debug.Log($"Salud: {actual}/{max}");
        _modelo.OnEscudoCambiado += (actual, max) => Debug.Log($"Escudo: {actual}/{max}");
    }

    private void Update(){
        if (!_modelo.EstaVivo) return;

        _inputMovimiento.x = Input.GetAxisRaw("Horizontal");
        _inputMovimiento.y = Input.GetAxisRaw("Vertical");
        _inputMovimiento = _inputMovimiento.normalized;
    }

    private void FixedUpdate(){
        if (!_modelo.EstaVivo){
            _rb.velocity = Vector2.zero;
            return;
        }

        _rb.velocity = _inputMovimiento * velocidadMovimiento;
    }

    private void ManejarMuerte(){
        Debug.Log("El Guerrero ha caído en combate.");
        _rb.velocity = Vector2.zero;
    }

    private void OnDestroy(){
        if (_modelo != null){
            _modelo.OnGuerreroMuerto -= ManejarMuerte;
        }
    }
}