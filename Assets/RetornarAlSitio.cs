using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RetornarAlSitio : MonoBehaviour
{
    private Vector3 posInicial;
    private Quaternion rotInicial;
    private Rigidbody rb;

    void Start()
    {
        // Guarda la posición y rotación exacta donde empieza el objeto
        posInicial = transform.position;
        rotInicial = transform.rotation;
        rb = GetComponent<Rigidbody>();
    }

    public void Volver()
    {
        // Lo teletransporta de vuelta y frena cualquier movimiento
        transform.position = posInicial;
        transform.rotation = rotInicial;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}