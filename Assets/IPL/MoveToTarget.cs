using UnityEngine;

namespace IPL
{
    public class MoveToTarget : MonoBehaviour
    {
        [SerializeField] private GameObject target;
        [SerializeField] private float speed;

        // Update is called once per frame
        void Update()
        {
            var dir = target.transform.position - gameObject.transform.position;
            var velocity = speed * dir.normalized;
            var movement = velocity * Time.deltaTime;
            transform.position += movement;
        }
    }
}
