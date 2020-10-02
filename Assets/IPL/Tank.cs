using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace IPL
{
    public class Tank : MonoBehaviour
    {
        [SerializeField] private GameObject projectile;
        [SerializeField] private float fireInterval;
        public Action<Tank> onHit;
        public TankEvent onHitUnity;
        
        private ISpawner _spawner;

        private void Awake()
        {
            _spawner = GetComponentInChildren<ISpawner>();
        }

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
                StartCoroutine(Fire(fireInterval));
            if (Input.GetButtonUp("Fire1"))
                StopAllCoroutines();
        }

        private void OnTriggerEnter(Collider other)
        {
            onHit?.Invoke(this);
            onHitUnity?.Invoke(this);
        }

        private IEnumerator Fire(float interval)
        {
            while (true)
            {
                _spawner?.Spawn(projectile);
                yield return new WaitForSeconds(interval);
            }
        }
    }
    [Serializable]
    public class TankEvent : UnityEvent<Tank>{}
}