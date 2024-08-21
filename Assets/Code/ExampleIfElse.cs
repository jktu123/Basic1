using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

namespace Code.LessonTwo
{
    public class ExampleIfElse : MonoBehaviour
    {
        private void OnValidate()
        {
            Sixth();
        }
        
        public int A;
        public int B;

        private void First()
        {
            // > < == && ||  ! = >= <=
            if (A >= B)
            {
                UnityEngine.Debug.LogError("A more B");
            }
        }

        private void Second()
        {
            if (A > B)
            {
                UnityEngine.Debug.LogError("A more B");
            }
            else
            {
                UnityEngine.Debug.LogError("B more A");
            }
        }

        private void Third()
        {

            if (A > B)
            {
                UnityEngine.Debug.LogError("A more B");
            }
            else if (B > A)
            {
                UnityEngine.Debug.LogError("B more A");
            }
            else
            {
                UnityEngine.Debug.LogError("A equal B");
            }
        }

        private void Fifth()
        {
            /*
            int maxI = 0;
            if (A > B)
            {
                maxI = A;
                UnityEngine.Debug.LogError(maxI);
            }
            else
            {
                maxI = B;
                UnityEngine.Debug.LogError(maxI);
            }
            */

            int maxT = A > B ? A : B;
            UnityEngine.Debug.LogError(maxT);
        }

        public int C;
        private void Sixth()
        {
            /*
            int max = 0;
            if (A > B)
            {
                if (A > C)
                {
                    max = A;
                }
                else
                {
                    max = C;
                }
            }
            else if (B > C)
            {
                max = B;
            }
            else
            {
                max = C;
            }

            UnityEngine.Debug.LogError(max);
            */

            int maxTwo = A > B ? A > C ? A : C : B > C ? B : C;
            UnityEngine.Debug.LogError(maxTwo);
        }

        private void Seventh(WeekDays day)
        {
            //bool isDayOff = day == WeekDays.Saturday || day == WeekDays.Sunday;
            bool isDayOff = day is WeekDays.Sunday or WeekDays.Saturday;

        }



    }
}




