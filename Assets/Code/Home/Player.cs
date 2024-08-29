using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

namespace Code.HomeThree
{
    public class Player : MonoBehaviour
    {
        public int Health = 100;
        public bool Enemy;
        public bool IsDead;

        private void Start()
        {
            MeshRenderer addComponent = gameObject.GetComponent<MeshRenderer>();
            addComponent.material.color = Color.grey;
            //gameObject.GetComponent<MeshRenderer>().sharedMaterial.color = Color.grey;
   
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
                gameObject.GetComponent<MeshRenderer>().sharedMaterial.color = Color.red;
                UnityEngine.Debug.Log("Character is Enemy");
            }

            else
            {
                //MeshRenderer addComponent = gameObject.GetComponent<MeshRenderer>();
                //addComponent.sharedMaterial.color = Color.blue;                
                gameObject.GetComponent<MeshRenderer>().sharedMaterial.color = Color.blue;
                UnityEngine.Debug.Log("Character is Ally");
            }
        }
    }
}


