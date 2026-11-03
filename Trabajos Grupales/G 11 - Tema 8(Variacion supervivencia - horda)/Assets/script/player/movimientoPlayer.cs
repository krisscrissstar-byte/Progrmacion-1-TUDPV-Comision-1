using System;
using UnityEngine;
using UnityEngine.InputSystem;



//hola chicos les estare dejando estos mesajes por si acaso

public class movimientoPlayer : MonoBehaviour
{

    public float velocidad = 2f;

    private Rigidbody2D rb2D;
    private Vector2 movimiento;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movimiento = Vector2.zero;

        if (Keyboard.current == null)
            return;

        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            movimiento.x = -1;
        }

        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            movimiento.x = 1;

        }

        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            movimiento.y = -1;
        }

        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            movimiento.y = 1;
        }

        movimiento = movimiento.normalized;
    }

    private void FixedUpdate()
    {
        rb2D.linearVelocity = movimiento * velocidad;
    }










}




