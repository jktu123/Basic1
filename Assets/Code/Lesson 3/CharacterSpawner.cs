using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using Code.LessonTwo;


namespace Code.LessonThree
{
    public class CharacterSpawner : MonoBehaviour
    {
        public Character Character; // Можно так а можно как ниже 
                                    //public GameObject Character;
        public Transform Point;
        public int[] Array;
        private GameObject[] _items = new GameObject[10];



        private void Start()
        {
            Array = new int[10];
            Array[2] = 9;

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = i + 1;
            }

            for (int index = 0; index < Array.Length; index++)
            {
                int i = Array[index];
                UnityEngine.Debug.LogError(i);
            }

            Instantiate(Character, Point.position, Quaternion.identity);
            for (int i = 0; i < 10; i++)
            {
                Character instantiate = Instantiate(Character, new Vector3(0, i, 0), Quaternion.identity);
                //GameObject instantiate = Instantiate(Character, new Vector3(0, i, 0), Quaternion.identity);
                instantiate.name = $"Character {i}"; // создаем имена клонам 

            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Character[] findObjectsByType = FindObjectsByType<Character>(FindObjectsInactive.Include, FindObjectsSortMode.None);
                foreach (Character character in findObjectsByType)
                {
                    character.gameObject.SetActive(!character.gameObject.activeSelf);
                }
            }
        }
    }

}

