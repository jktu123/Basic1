using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

namespace Code.LessonTwo
{
    public class CharacterPresenter : MonoBehaviour
    {
        public Character Character;

        private void Start()
        {
            WeekDays WD = WeekDays.Monday;
            UnityEngine.Debug.LogError(WD);
        }

        private void Update()
        {
            Character.gameObject.SetActive(Character.IsDead);
            /*
            if (Character.IsDead)
            {
                UnityEngine.Debug.LogError(message: "Character is alive");
            }
            else
            {
                UnityEngine.Debug.LogError(message: "Character is dead");
            }
            */
        }
    }
}

