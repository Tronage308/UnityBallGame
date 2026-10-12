using UnityEngine;

public class Hazard : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        BallRoll player = other.GetComponent<BallRoll>();

        if (player != null)
        {
            player.Respawn();
        }

    }
}