using System; // добавил вручную
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Code
{

    public class Example : MonoBehaviour
    {
        private void Start() // Вызывается 1 раз
        {
            Second();
            //UnityEngine.Debug.LogError(message:1); // надо писать UnityEngine
        }


        private void First()
        {
            int a = 1;
            long l = 2;
            float f = 2.123456789123456789f;
            double d = 2.123456789123456789f;
            char c = 'c';
            string s = "string"; //класс а все остальные - структуры
            bool b = true;

            UnityEngine.Debug.Log(a); // белая ошибка 
            UnityEngine.Debug.LogError(l); // красная ошибка
            UnityEngine.Debug.LogWarning(f); // желтая ошибка
            UnityEngine.Debug.LogError(d);
            UnityEngine.Debug.LogError(c);
            UnityEngine.Debug.LogError(s);
            UnityEngine.Debug.LogError(b);
        }

        private void Second()
        {
            float health = 1.123456f;
            UnityEngine.Debug.LogWarning(message: "Player " + health + " hp");
            UnityEngine.Debug.LogWarning(message: String.Format("Player {0:C0} hp", health));
            UnityEngine.Debug.LogWarning(message: $"Player {health:##.##} hp");
        }

        public string A;
        public string B;
        public string Result;

        private void Third()
        {
            // + - * / $ ++ --
            int intA = Convert.ToInt32(A);
            int intB = int.Parse(B);
            Result = (intA + intB).ToString();

            double doubleA = int.Parse(A);
            double doubleB = int.Parse(B);
            Result = (doubleA / doubleB).ToString();
            int a = 5;
            UnityEngine.Debug.LogWarning(a--);
            UnityEngine.Debug.LogError(--a);
        }

        public float D;
        public float E;
        public float Result2;
        private int[] _array = { 1, 2, 3, 4, 5 };
        private int _currentIdex = 0;

        private void Fourth()
        {
            // %
            Result2 = D % E;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _currentIdex++;
                int index = _currentIdex % _array.Length;
                UnityEngine.Debug.LogWarning(_array[index]);
                UnityEngine.Debug.LogError(index);
            }
        }

        private bool IsTrue(int a)
        {
            return a > 0;
        }

        private void Update() // вызывается 1 раз за кадр // выполеяются действия с объектом
        {
            Fourth();
            // UnityEngine.Debug.LogError(message:2);
        }

        private void OnValidate() // выхывается при изменении объекта
        {
            // UnityEngine.Debug.LogError(message:3);
        }


    }
}
