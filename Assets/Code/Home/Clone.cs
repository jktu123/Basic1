using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using Code.LessonTwo;

namespace Code.HomeThree
{
    public class Clone : MonoBehaviour
    {
        public GameObject Object;

        private void Start()
        {
            for (int i = 0; i < 5; i++)
            {
                GameObject instantiate = Instantiate(Object, new Vector3(-i, 1, 0), Quaternion.identity);
                instantiate.name = $"Clone {i+1}";
            }
        }

        private void Update()
        {

        }

        private void OnValidate()
        {

        }
    }
}

