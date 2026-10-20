
using UnityEngine;

public class Push : MonoBehaviour
{
    public float FORCE;
    void OnTriggerStay(Collider other)
    {
        other.attachedRigidbody.AddForce(transform.forward * FORCE);
    }
}