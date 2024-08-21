using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

namespace Code.LessonTwo
{
    public class ExampleSwitch : MonoBehaviour
    {
        private void OnValidate()
        {
            First(0);
        }

        private void First(int day)
        {
            if (day == 1)
            {
                UnityEngine.Debug.LogError("Понедельник");
            }
            else
            {
                if (day == 2)
                {
                    UnityEngine.Debug.LogError("Вторник");
                }
                else
                {
                    if (day == 3)
                    {
                        UnityEngine.Debug.LogError("Среда");
                    }
                    else
                    {
                        if (day == 4)
                        {
                            UnityEngine.Debug.LogError("Четверг");
                        }
                        else if (day >= 5 && day < 8)   // if (day is >= 5 and < 8)
                        {
                            UnityEngine.Debug.LogError("Пятница - Воскресенье");
                        }
                        else
                        {
                            UnityEngine.Debug.LogError("Что-то пошло не так");
                        }
                    }
                }
            }
        }

        private void Second(int day)
        {
            // return break continue
            switch (day)
            {
                case 1:
                    UnityEngine.Debug.LogError("Понедельник");
                    break;
                case 2:
                    UnityEngine.Debug.LogError("Вторник");
                    break;
                case 3:
                    UnityEngine.Debug.LogError("Среда");
                    break;
                case 4:
                    UnityEngine.Debug.LogError("Четверг");
                    break;
                case 5:
                case 6:
                case 7:
                    UnityEngine.Debug.LogError("Пятница - Воскресенье");
                    break;
                default:
                    UnityEngine.Debug.LogError("Что-то пошло не так");
                    break;
            }

            UnityEngine.Debug.LogError("Test");
        }

        private enum Level
        {
            None = 0,
            Easy = 1,
            Medium = 2,
            Hard = 3
        }
        private void Fourth(Level level, bool isCheater)
        {
            switch (level)
            {
                case Level.None when isCheater:
                    UnityEngine.Debug.LogError("100 попыток");
                    break;
                case Level.Easy when isCheater:
                    UnityEngine.Debug.LogError("15 попыток");
                    break;
                case Level.Medium:
                    UnityEngine.Debug.LogError("10 попыток");
                    break;
                case Level.Hard:
                    UnityEngine.Debug.LogError("5 попыток");
                    break;
                default:
                    UnityEngine.Debug.LogError("Что-то пошло не так");
                    break;
            }
        }

        private enum Rainbow
        {
            None = 0,
            Red = 1,
            Orange = 2,
            Yellow = 3,
            Green = 4,
            Blue = 5,
            Indigo = 6,
            Violet = 7
        }

        private string Select(Rainbow rainbow)
        {
            switch (rainbow)
            {
                case Rainbow.Red: return "Red";
                case Rainbow.Orange: return "Orange";
                case Rainbow.Yellow: return "Yellow";
                case Rainbow.Green: return "Green";
                case Rainbow.Blue: return "Blue";
                case Rainbow.Indigo: return "Indigo";
                case Rainbow.Violet: return "Violet";
                default: return "Нет такого цвета";
            }
        }
    }
}

       

