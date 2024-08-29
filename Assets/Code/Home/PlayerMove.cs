using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

namespace Code.HomeThree
{
    public class PlayerMove : MonoBehaviour
    {
        public Transform Target;
        public float Speed = 3.0f;

        private void Update ()
        {
            Move();
        }

     private void Move()
        {
            float directionVertical = 0.0f;
            float directionHorizontal = 0.0f;
            
            if (Input.GetKey(KeyCode.W))
            {
                directionVertical = -1.0f;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                directionVertical = 1.0f;
            }

            if (Input.GetKey(KeyCode.A))
            {
                directionHorizontal = 1.0f;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                directionHorizontal = -1.0f;
            }

            Vector3 targetFirstVertical = Target.forward * directionVertical;
            Vector3 targetFirstHorizontal = Target.right * directionHorizontal;
            Target.position += (targetFirstVertical + targetFirstHorizontal) * Speed * Time.deltaTime;

        }

    }
}

