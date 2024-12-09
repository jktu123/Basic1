using System; 
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Code
{
    public class HomeTask : MonoBehaviour
    {

        public string part1 = ("вывод чисел в консоль");

        public int intA;
        public float floatB;
        public bool boolC;

        private void Console()
        {
            UnityEngine.Debug.Log(intA);
            UnityEngine.Debug.LogWarning(floatB);
            UnityEngine.Debug.LogError(boolC);
        }

        private void Start()
        {
            Console();
        }

        private void Update()
        {

        }

        private void OnValidate()
        {

        }

    }



}

