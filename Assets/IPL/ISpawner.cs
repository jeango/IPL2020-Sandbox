using UnityEngine;

namespace IPL
{
    public interface ISpawner
    {
        GameObject Spawn(GameObject prefab);
    }
}