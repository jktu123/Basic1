using System;
using UnityEngine;

public sealed class Task1 : MonoBehaviour
{

    /**
    * Тривиальная (1 балл)
    *
    * Мой возраст. Для заданного 0 < n < 200, рассматриваемого как возраст человека,
    * вернуть строку вида: «21 год», «32 года», «12 лет».
    */
    public int age; // здесь будем задавать возраст (на выход подается значение)
    public string result1; // здесь будем выводить результат (текст потому что со словами)
    /*
        private void OnValidate()
        {
            DZ11();
        }

        /*
        private void DZ1() // подход через строки
        {
            string agest = age.ToString(); // перевели значение которое ввели в сроку, будем смотреть сколько там символов 
            char[] agech = agest.ToCharArray(); // перевели значение, сивмолы. После того как поймем сколько там символов будем делать условие.
            string output = " лет"; // здесь будет опция - год, годы, лет

            if (agech.Length < 2)
            {
                if (age == 1)
                {
                    output = " год";
                }
                if (age == 2 || age == 3 || age == )
                {
                    output = " года";
                }
            }

            if (agech.Length == 2 && age > 20)
            {
                var lastnum1 = int.Parse(agech[1].ToString());

                if (lastnum1 == 1)
                {
                    output = " год";
                }
                if (lastnum1 == 2 || lastnum1 == 3 || lastnum1 == 4)
                {
                    output = " года";
                }
            }

            if (agech.Length == 3 && age > 120 | age < 110)
            {
                var lastnum2 = int.Parse(agech[2].ToString());

                if (lastnum2 == 1)
                {
                    output = " год";
                }
                if (lastnum2 == 2 || lastnum2 == 3 || lastnum2 == 4)
                {
                    output = " года";
                }
            }

            result = age + output;
        }
        */
    private void DZ11()  // подход через остаток от деления
    {
        string output = " лет"; // здесь будет опция - год, годы, лет
        int a = 0;

        if (age >= 10 && age <= 20 || age >= 110 && age <= 120)
        {
            output = " лет";
        }
        else
        {
            a = age % 10;
            if (a == 1)
            {
                output = " год";
            }
            if (a == 2 || a == 3 || a == 4)
            {
                output = " года";
            }
        }
        output = age + output;
        result1 = output;
    }

    /**
    * Простая (2 балла)
    *
    * Нa шахматной доске стоят черный король и две белые ладьи (ладья бьет по горизонтали и вертикали).
    * Определить, не находится ли король под боем, а если есть угроза, то от кого именно.
    * Вернуть 0, если угрозы нет, 1, если угроза только от первой ладьи, 2, если только от второй ладьи,
    * и 3, если угроза от обеих ладей.
    * Считать, что ладьи не могут загораживать друг друга
    */
    public int kingX;
    public int kingY;
    public int rookX1;
    public int rookY1;
    public int rookX2;
    public int rookY2;
    public int result2;
    /*
       private void OnValidate()
       {
           DZ2();
       }
    */
    private void DZ2()
    {
        result2 = 0; // угрозы сейчас нет

        if (kingX == rookX1 || kingY == rookY1)
        {
            if (kingX == rookX2 || kingY == rookY2)
            {
                result2 = 3;
            }
            else
            {
                result2 = 1;
            }
        }
        else
        {
            if (kingX == rookX2 || kingY == rookY2)
            {
                result2 = 2;
            }
        }

    }

    /**
    * Средняя (2 балла)
    *
    * Треугольник задан длинами своих сторон a, b, c.
    * Проверить, является ли данный треугольник остроугольным (вернуть 0),
    * прямоугольным (вернуть 1) или тупоугольным (вернуть 2).
    * Если такой треугольник не существует, вернуть -1.
    */
    public double a;
    public double b;
    public double c;
    public double result3;
    /*
       private void OnValidate()
       {
           DZ3();
       }
    */
    private void DZ3()
    {
        result3 = 0;

        double a1 = Math.Pow(a, 2);
        double b1 = Math.Pow(b, 2);
        double c1 = Math.Pow(c, 2);

        if (a + b > c && b + c > a && a + c > b) // на существование треугольника
        {
            /** так не сработало=))) задача оказалась сложнее 
           if (a1 == b1 + c1 || b1 == a1 + c1 || c1 == b1 + a1) // проверка на то, что треугольник прямоугольный 
           {
               result3 = 1; 
           }
           if (a1 < b1 + c1 || b1 < a1 + c1 || c1 < b1 + a1) // проверка на то, что треугольник остроугольный
           {
               result3 = 0;
           }
           if (a1 > b1 + c1 || b1 > a1 + c1 || c1 > b1 + a1) // проверка на то, что треугольник тупоугольный
           {
               result3 = 2;
           }
             */
            if (a == b)
            {
                if (a > c)
                {
                    result3 = 0;
                }
                else // c - max
                // в последствии нужно научиться вызывать программу проверки. Сейчас такая проверка идет для каждого случая
                {
                    if (a1 + b1 == c1)
                    {
                        result3 = 1;
                    }
                    if (a1 + b1 > c1)
                    {
                        result3 = 0;
                    }
                    if (a1 + b1 < c1)
                    {
                        result3 = 2;
                    }
                }
            }
            else
            {
                if (a > b)
                {
                    if (a == c)
                    {
                        result3 = 0;
                    }
                    else
                    {
                        if (a > c) // a - max
                        {
                            if (c1 + b1 == a1)
                            {
                                result3 = 1;
                            }
                            if (c1 + b1 > a1)
                            {
                                result3 = 0;
                            }
                            if (c1 + b1 < a1)
                            {
                                result3 = 2;
                            }
                        }
                        else // c - max
                        {
                            if (a1 + b1 == c1)
                            {
                                result3 = 1;
                            }
                            if (a1 + b1 > c1)
                            {
                                result3 = 0;
                            }
                            if (a1 + b1 < c1)
                            {
                                result3 = 2;
                            }
                        }
                    }
                }
                else
                {
                    if (b == c) // a - max
                    {
                        if (c1 + b1 == a1)
                        {
                            result3 = 1;
                        }
                        if (c1 + b1 > a1)
                        {
                            result3 = 0;
                        }
                        if (c1 + b1 < a1)
                        {
                            result3 = 2;
                        }
                    }
                    else
                    {
                        if (b > c) // b - mac
                        {
                            if (a1 + b1 == b1)
                            {
                                result3 = 1;
                            }
                            if (a1 + b1 > b1)
                            {
                                result3 = 0;
                            }
                            if (a1 + b1 < b1)
                            {
                                result3 = 2;
                            }
                        }
                        else // c - max
                        {
                            if (a1 + b1 == c1)
                            {
                                result3 = 1;
                            }
                            if (a1 + b1 > c1)
                            {
                                result3 = 0;
                            }
                            if (a1 + b1 < c1)
                            {
                                result3 = 2;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            result3 = -1;
        }
    }

    /**
    * Тривиальная (1 балла)
    *
    * Найти число Фибоначчи из ряда 1, 1, 2, 3, 5, 8, 13, 21, ... с номером n.
    * Ряд Фибоначчи определён следующим образом: fib(1) = 1, fib(2) = 1, fib(n+2) = fib(n) + fib(n+1)
    */
    public int n;
    public int result4;
    /*
       private void OnValidate()
       {
           DZ4();
       }
    */
    private void DZ4()
    {
        int f0 = 0;
        int f1 = 1;
        int fn = 0;

        for (int i = 0; i < n - 1; i++)
        {
            fn = f0 + f1;
            f0 = f1;
            f1 = fn;
        }
        result4 = fn;
    }

    /**
    * Простая (2 балла)
    *
    * Для заданного числа n > 1 найти минимальный делитель, превышающий 1
    */

    public int n2;
    public int result5;
    /*
       private void OnValidate()
       {
           DZ5();
       }
    */
    private void DZ5()
    {
        int div = 1;
        int res = 0;

        if (n2 > 1)
        {
            do
            {
                div++;
                res = n2 % div;
            } while (res != 0);
        }
        else div = 1;

        result5 = div;
    }

    /**
    * Средняя (2 балла)
    *
    * Поменять порядок цифр заданного числа n на обратный: 13478 -> 87431.
    *
    * Использовать операции со строками в этой задаче запрещается!
    */
    public int n6;
    public int result6;

    private void OnValidate()
    {
        DZ11();
    }
    private void DZ6()
    {
        int new_n6 = n6;
        int old_n6 = n6;

        if (old_n6 > 0)
        {
            new_n6 = old_n6 % 10;
            old_n6 = old_n6 / 10;

            while (old_n6 >= 1)
            {
                new_n6 = new_n6 * 10;
                new_n6 = new_n6 + old_n6 % 10;
                old_n6 = old_n6 / 10;
            }

            result6 = new_n6;
        }
    }
}
