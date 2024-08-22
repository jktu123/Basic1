using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

namespace Code.HomeThree
{
    public class Object : MonoBehaviour
    {
        public int Health;
        public bool Enemy;
        public bool IsDead;

        private void Start()
        {
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
            if (Enemy)
            {
                GetComponent<MeshRenderer>().material.color = Color.red;
            }
            else
            {
                GetComponent<MeshRenderer>().material.color = Color.blue;

            }

        }

        public void OnValidate()
        {
            if (Enemy)
            {
                UnityEngine.Debug.Log("Character is Enemy");

            }
            else
            {
                UnityEngine.Debug.Log("Character is Ally");
            }
        }
    }
}


