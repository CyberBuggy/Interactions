using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CyberBuggy
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed = 1f;
        private Vector2 _moveInput;
        private Rigidbody2D _rigidBody;

        private void Start()
        {
            _rigidBody = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            _rigidBody.MovePosition(_rigidBody.position + _moveInput * _moveSpeed * Time.fixedDeltaTime);
        }

        private void OnMove(InputValue value)
        {
            this._moveInput = value.Get<Vector2>();
        }
    }
}
