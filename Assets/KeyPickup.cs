using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject pathToAppear;
    public GameObject pathToDissapear; 
    void OnTriggerEnter(Collider other)
    {
        pathToAppear.SetActive(true);
        Destroy(gameObject);
    }

}
