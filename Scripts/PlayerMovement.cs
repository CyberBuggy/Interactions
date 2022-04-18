using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CyberBuggy
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed = 1f;
        [SerializeField] private Rigidbody2D _rigidBody;
        private Vector2 _moveInput;

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
