using System;
using UnityEngine;

namespace IPL
{
    public class SpawnPrefab : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;

        private Transform _transform;

        private void Awake()
        {
            
            _transform = transform;
        }

        // Start is called before the first frame update
        void Start()
        {
            Instantiate(prefab, _transform.position, _transform.rotation);
        }

    }
}
