using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

namespace Code.HomeThree
{
    public class PlayerClone : MonoBehaviour
    {
        public Player Clone;
        private Player _player;

        private void Start()
        {
            for (int i = 0; i < 5; i++)
            {
                _player = Instantiate(Clone, new Vector3(-i, 1, 0), Quaternion.identity);
                _player.name = $"Clone {i+1}";
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Destroy(Clone.gameObject);
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Destroy(_player.gameObject);
                // Destroy(_player.GetComponent<___>()) //удаление компанента на объекте
                // _player.gameObject.AddComponent<Rigidbody>(); //боращение к компаненту
            }
        }

        private void OnValidate()
        {

        }
    }
}

