using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

namespace Code.HomeThree
{
    public class Player : MonoBehaviour
    {
        public int Health;
        public bool Enemy;
        public bool IsDead;

        private void ObjectColor()
        {
            GetComponent<MeshRenderer>().material.color = Color.grey;
        }

        private void Start()
        {
            ObjectColor();
            Health = 100;
        }

        private void Update()
        {
            if (Health <= 0)
            {
                IsDead = true;
            }

            if (IsDead)
            {
                Destroy(gameObject);
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                MeshRenderer addComponent = gameObject.GetComponent<MeshRenderer>();
                addComponent.material.color = Color.grey;
            }
        }

        public void OnValidate()
        {

            if (Enemy)
            {
                GetComponent<MeshRenderer>().material.color = Color.red;
                UnityEngine.Debug.Log("Character is Enemy");
            }
            else
            {
                GetComponent<MeshRenderer>().material.color = Color.blue;
                UnityEngine.Debug.Log("Character is Ally");
            }
        }
    }
}


