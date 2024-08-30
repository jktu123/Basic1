using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Code.Football

{
    public class PlayerOneMove : MonoBehaviour
    {
        //public float ObjectSpeed = 5f;
        public float force = 5f;
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>(); // после добаления трансформ меняем на Addforce

        }

        private void Update()
        {
            //GetComponent<Rigidbody>().AddForce(Vector3.up * ObjectSpeed);

            float xdirection = 0.0f;
            float zdirection = 0.0f;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                //transform.Translate(Vector3.up * ObjectSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.W))
            {
                zdirection = -1.0f;
            }

            else if (Input.GetKey(KeyCode.S))
            {
                zdirection = 1.0f;
            }

            if (Input.GetKey(KeyCode.A))
            {
                xdirection = 1.0f;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                xdirection = -1.0f;
            }

            //Vector3 directiom = new Vector3 (xdirection, 0, zdirection)* (ObjectSpeed * Time.deltaTime);
            Vector3 direction = new Vector3(xdirection, 0, zdirection) * force;

            //transform.Translate(direction); // Транслейт подходит если нужно просто двигать объект
            //_rigidbody.AddForce(direction);
            _rigidbody.velocity = direction;
        }
    }
}    
