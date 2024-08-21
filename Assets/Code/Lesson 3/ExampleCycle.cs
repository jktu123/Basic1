using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

namespace Code.LessonThree
{
    public class ExampleCycle : MonoBehaviour
    {
        public int N;
        private void Start()
        {
            ExampleForeach();

            //ExampleDoWhile(25);
            //ExampleWhile(25);

            //int i = Example(N);
            //UnityEngine.Debug.Log(i);
        }

        private void ExampleFor()
        {
            for (int i = 10; i > 0; i--)
            {
                UnityEngine.Debug.Log("Mom");
            }
        }

        private int Example(int n)
        {
            int a0 = 0;
            int a1 = 1;
            int temp = 0;
            for (int i = 0; i <= n; i++)
            {
                temp = a0 + a1;
                a0 = a1;
                a1 = temp;
            }

            return temp;
        }

        private int ExampleRecursion(int n)
        {
            int exampleRecursion = ExampleRecursion(n - 1) + ExampleRecursion(n - 2);
            if (exampleRecursion == n)
            {
                return 0;
            }
            return exampleRecursion;
        }

        private void ExampleDoWhile(int n)
        {
            int i = 0;
            do
            {
                i++;
                n -= 10;
            } while (n >= 0);

            UnityEngine.Debug.Log(i);
        }

        private void ExampleWhile(int n)
        {
            int i = 0;
            while (n >= 0)
            {
                i++;
                n -= 10;
            }

            UnityEngine.Debug.Log(i);
        }

        private void ExampleForeach()
        {
            string str = "Roman";
            foreach (char i in str)
            {
                if (i == 'm')
                {
                    //continue;
                    //break;
                    return;
                }
                UnityEngine.Debug.Log(i);
            }

            UnityEngine.Debug.Log(str);
        }
    }
}

