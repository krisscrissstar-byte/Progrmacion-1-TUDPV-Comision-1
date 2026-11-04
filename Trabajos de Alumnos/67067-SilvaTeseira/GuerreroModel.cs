using System;

public class GuerreroModel{
    private float _saludMaxima;
    private float _saludActual;
    private float _escudoMaximo;
    private float _escudoActual;

    public float SaludMaxima => _saludMaxima;
    public float SaludActual => _saludActual;
    public float EscudoMaximo => _escudoMaximo;
    public float EscudoActual => _escudoActual;

    public bool EstaVivo => _saludActual > 0;

    public event Action<float, float> OnSaludCambiada;
    public event Action<float, float> OnEscudoCambiado;
    public event Action OnGuerreroMuerto;

    public GuerreroModel(float saludInicial, float escudoInicial){
        _saludMaxima = Math.Max(1f, saludInicial);
        _saludActual = _saludMaxima;

        _escudoMaximo = Math.Max(0f, escudoInicial);
        _escudoActual = _escudoMaximo;
    }

    public void RecibirDano(float cantidad){
        if (!EstaVivo || cantidad <= 0) return;

        float danoRestante = cantidad;

        if (_escudoActual > 0){
            if (_escudoActual >= danoRestante){
                _escudoActual -= danoRestante;
                danoRestante = 0;
            }else{
                danoRestante -= _escudoActual;
                _escudoActual = 0;
            }
            OnEscudoCambiado?.Invoke(_escudoActual, _escudoMaximo);
        }

        if (danoRestante > 0){
            _saludActual = Math.Max(0f, _saludActual - danoRestante);
            OnSaludCambiada?.Invoke(_saludActual, _saludMaxima);

            if (_saludActual <= 0){
                OnGuerreroMuerto?.Invoke();
            }
        }
    }

    public void Curar(float cantidad){
        if (!EstaVivo || cantidad <= 0) return;

        _saludActual = Math.Min(_saludMaxima, _saludActual + cantidad);
        OnSaludCambiada?.Invoke(_saludActual, _saludMaxima);
    }

    public void RecargarEscudo(float cantidad){
        if (!EstaVivo || cantidad <= 0) return;

        _escudoActual = Math.Min(_escudoMaximo, _escudoActual + cantidad);
        OnEscudoCambiado?.Invoke(_escudoActual, _escudoMaximo);
    }
}