using System;
using System.ComponentModel;
using UnityEngine;

namespace IPL
{
    public class Canon : SpawnBehaviour
    {
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private float initialSpeed;
        protected override GameObject ProcessInstance(GameObject instance)
        {
            var t = instance.transform;
            t.position = spawnPoint.position;
            t.rotation = spawnPoint.rotation;
            foreach (Transform child in t)
            {
                child.gameObject.layer = gameObject.layer;
            }
            instance.layer = gameObject.layer;
            var rb = instance.GetComponent<Rigidbody>();
            if (rb)
            {
                rb.velocity = t.forward * initialSpeed;
            }
            else
            {
                Debug.LogError("The spawned object can't have a velocity if it doesn't have a rigidbody");
            }
            return instance;
        }
    }
}