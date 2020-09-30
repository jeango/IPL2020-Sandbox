using System;
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

    public abstract class SingletonMB<T> : MonoBehaviour where T : MonoBehaviour
    {
        [SerializeField] private bool persistent;
        private static T _instance;
        public static T Instance => GetInstance();

        public static T GetInstance()
        {
            if (_instance == null)
            {
                var t = typeof(T);
                _instance = FindObjectOfType<T>();
                if (_instance == null)
                    _instance = new GameObject(t.ToString(), t).GetComponent<T>();
            }
            return _instance;
        }

        private bool InitInstance()
        {
            if (!_instance)
            {
                _instance = (T) this;
            }
        }
        
        private void Awake()
        {
            
        }
    }

    public class GameManager : SingletonMB<GameManager>
    {
        
    }

    public class GameManagerUser
    {
        void DoSomething()
        {
            GameManager test = GameManager.Instance;
        }
    }
}