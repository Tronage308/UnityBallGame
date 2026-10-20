
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float FORCE;
    void OnTriggerStay(Collider other)
    {
        other.attachedRigidbody.AddForce(transform.up * FORCE);
    }
}