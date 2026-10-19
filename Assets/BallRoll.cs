using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallRoll : MonoBehaviour
{
    public float force = 20f;
    private Rigidbody rb;
    private Vector3 startPosition; 
    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = 0f;
        float z = 0f;
        Keyboard kb = Keyboard.current;
        if (kb.aKey.isPressed) x = -1f;
        if (kb.dKey.isPressed) x = 1f;
        if (kb.sKey.isPressed) z = -1f;
        if (kb.wKey.isPressed) z = 1f;

        Vector3 direction = new Vector3(x, 0f, z).normalized;

        rb.AddForce(direction * (Mathf.Clamp((MathF.Sin(Time.time * 0.5f) * force), 5, 20)));
        Debug.Log(Mathf.Clamp((MathF.Sin(Time.time * 0.5f) * force), 5, 20));
    }
    public void Respawn()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = startPosition;

        Debug.Log("Respawned");
    }
}
    