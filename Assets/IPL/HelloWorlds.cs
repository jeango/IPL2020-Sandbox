using System;
using UnityEngine;

namespace IPL
{
    public class HelloWorlds : MonoBehaviour
    {
        [SerializeField] private HelloWorlds otherRef;
        [SerializeField] private string otherName;

        public HelloWorlds OtherRef => otherRef;
        
        // Start is called before the first frame update
        void Awake()
        {
            print(FindObjectsOfType<HelloWorlds>().Length);
        }

        void Start()
        {
        }

        private void OnEnable()
        {
            print("I'm on");
        }

        private void OnDisable()
        {
            print("I'm OFF");
        }

        private void OnDestroy()
        {
            print("Goodbye World");
        }
    }
}