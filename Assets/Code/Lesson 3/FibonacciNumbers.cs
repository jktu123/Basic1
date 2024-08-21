using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Code.LessonThree
{
    public class FibonacciNumbers : MonoBehaviour
    {
        public int Numbers;
        public bool IsRecursion;

        public void Start()
        {
            for (int i = 1; i <= Numbers; i++)
            {
                DateTime startTime = DateTime.Now;
                int result = IsRecursion ? FibR(i) : FibC(i);
                double time = (DateTime.Now - startTime).TotalMilliseconds;
                UnityEngine.Debug.Log($"<color=green> Fib({i}) - {result} for {time}</color>");
            }
        }

        private int FibC(int n)
        {
            int a0 = 0, a1 = 1, temp = 0;
            for (var i = 0; i <= n; i++)
            {
                temp = a0 + a1;
                a0 = a1;
                a1 = temp;
            }
            return temp;
        }

        private int FibR(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            return FibR(n - 1) + FibR(n - 2);
        }
    }
}
