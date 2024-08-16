using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Code
{
    public class Player : MonoBehaviour
    {
        public string part2 = ("1. Нанесение урона через int");
        public int Health = 100; // поля класса
        public int Damage;
        public int Rusult;

        private void ScoreInt()
        {
            Rusult = Health - Damage;

            UnityEngine.Debug.LogWarning(message: $"Damage {Damage:##.##}");
            UnityEngine.Debug.Log(message: $"PlayerHP {Rusult:##.##} hp");
        }

        public string part3 = ("2. Нанесение урона через float");

        public float Health2 = 100; // поля класса
        public float Damage2;
        public float Rusult2;

        private void ScoreFloat()
        {
            Rusult2 = Health2 - Damage2;

            UnityEngine.Debug.LogWarning(message: $"Damage2 {Damage2:##.##}"); 
            UnityEngine.Debug.Log(message: $"PlayerHP {Rusult2:##.##} hp");
        }

        public string part4 = ("3. Расчет урона");
        public int Health3 = 100; 
        public int Damage3;
        public bool Multiplier;
        public int Rusult3;

        private void ScoreMultiplier()
        {
            if (Multiplier == true)
            {
                Rusult3 = Health3 - Damage3 * 2;
            }
            else
            {
                Rusult3 = Health3 - Damage3 * 1;
            }

            UnityEngine.Debug.LogWarning(message: $"Damage3 {Damage3:##.##}");
            UnityEngine.Debug.Log(message: $"PlayerHP {Rusult3:##.##} hp");
        }


        private void OnValidate() 
        {
            ScoreMultiplier();
        }

    }
}
