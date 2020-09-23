using UnityEngine;

public class Detection : MonoBehaviour
{
    [SerializeField] private float distance;
    [SerializeField] private LayerMask detectedLayers;
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, distance, detectedLayers))
           print(hit.rigidbody.name);
        
    }
}
