using UnityEngine;

namespace IPL
{
    public abstract class SpawnBehaviour : MonoBehaviour, ISpawner
    {
        public GameObject Spawn(GameObject prefab)
        {
            return ProcessInstance(Instantiate(prefab));
        }
        protected abstract GameObject ProcessInstance(GameObject instance);
    }
}