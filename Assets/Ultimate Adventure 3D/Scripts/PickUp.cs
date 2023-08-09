using UnityEngine;
using SimpleFPS;

public class PickUp : MonoBehaviour
{
    protected virtual void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            Destroy(gameObject);
        }
    }
}
