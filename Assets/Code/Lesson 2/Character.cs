using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

namespace Code.LessonTwo
{
    public class Character : MonoBehaviour
    {
        public bool IsDead;
        public int Health;
        public WeekDays week;

        private void Update()
        {
            //IsDead = Health <= 0 ? true : false;
            if (IsDead)
            {
                //Destroy(gameObject);
            }
            if (week == WeekDays.Friday)
            {
                Destroy(gameObject);
            }
        }

        public void SetActive(bool isActive)
        {
            gameObject.SetActive(isActive);
        }
    }
}

