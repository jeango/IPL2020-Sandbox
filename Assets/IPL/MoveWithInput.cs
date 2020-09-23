using System;
using UnityEngine;

namespace IPL
{
    public class MoveWithInput : MonoBehaviour
    {
        [SerializeField] private float _speed;
        private Rigidbody _rigidbody;
        private Vector3 _currentVelocity;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            var hInput = Input.GetAxisRaw("Horizontal");
            var vInput = Input.GetAxisRaw("Vertical");
            var direction = new Vector3(hInput, 0, vInput)
                                    .normalized;
            _currentVelocity = _speed * direction;
            _currentVelocity.y = _rigidbody.velocity.y;
        }

        private void FixedUpdate()
        {
            _rigidbody.velocity = _currentVelocity;
        }
    }
}