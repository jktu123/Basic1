using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Animations

{
    public class Move : MonoBehaviour
    {

        public float moveSpeed = 5f;
        private Rigidbody _rigidbody;
        public Animator animator;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();              
        }

        private void Update()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            MoveCh(movement);

            //Vector3 velocity = _rigidbody.velocity;
            //float speed = velocity.x  + velocity.z;

            //animator.SetFloat("Speed", Mathf.Abs(speed));

        }

        private void MoveCh(Vector3 direction)
        {
            Vector3 velocity = direction * moveSpeed;

            _rigidbody.velocity = new Vector3(velocity.x, 0, velocity.z);

        }

    }
}    