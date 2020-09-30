using UnityEngine;

namespace IPL
{
    public class Tank : MonoBehaviour
    {
        [SerializeField] private GameObject projectile;
        private ISpawner _spawner;

        private void Awake()
        {
            _spawner = GetComponentInChildren<ISpawner>();
        }

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
                _spawner?.Spawn(projectile);
        }
    }
}