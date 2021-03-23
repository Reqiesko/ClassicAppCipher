using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Playfair : ICipher
    {
        public string Decode(string text)
        {
            throw new NotImplementedException();
        }
        public string Decode(string message, string key)
        {
            //const int nine = 9;
            //for (int i = 0; i < nine; i++)
            //{
            //    message = Incode(message, key);
            //}
            int iFirst = 0, iSecond = 0, jFirst = 0, jSecond = 0;
            string tempStr1 = "", tempStr2 = "";
            string incodeString = "";
            var listAZ = Enumerable.Range('A', 'Z' - 'A' + 1).Select(c => (char)c);
            char[] alphabet = listAZ.ToArray();
            alphabet = alphabet.Except("J").ToArray();
            key = key.Replace(" ", "").Replace("J", "I");
            char[] keyword = key.Distinct().ToArray();
            message = message.Replace(" ", "").Replace("J", "I");
            int rows = 5, columns = 5;
            char[,] table = new char[rows, columns];
            for (int i = 0; i < keyword.Length; i++)
            {
                table[i / columns, i % columns] = keyword[i];
            }
            Console.WriteLine(keyword);
            alphabet = alphabet.Except(keyword).ToArray(); Console.WriteLine(alphabet.Length);
            for (int i = 0; i < alphabet.Length; i++)
            {
                int position = i + keyword.Length;
                table[position / columns, position % columns] = alphabet[i];
            }
            int temp = message.Length % 2;
            if (temp != 0) //если нет
            {               //то добавляем в конец строки символ "Q" 
                message = message.PadRight((message.Length + 1), 'Q');
            }
            int len = message.Length / 2;
            string[] str = new string[len]; //новый массив

            int l = -1; //служебная переменная

            for (int i = 0; i < message.Length; i += 2) //в старом массиве шаг равен 2
            {
                l++; //индексы для нового массива
                if (l < len)
                {
                    //Элемент_нового_массива[i] =  Элемент_старого_массива[i] +  Элемент_старого_массива[i+1]
                    str[l] = Convert.ToString(message[i]) + Convert.ToString(message[i + 1]);
                }

            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(table[i, j] + "\t");
                }
                Console.WriteLine("\t");
            }
            //координаты очередного найденного символа из каждой пары
            Console.WriteLine(message);
            foreach (string both in str)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        //координаты первого символа пары в исходной матрице
                        if (both[0] == (table[i, j]))
                        {
                            iFirst = i;
                            jFirst = j;
                        }

                        //координаты второго символа пары в исходной матрице
                        if (both[1] == (table[i, j]))
                        {
                            iSecond = i;
                            jSecond = j;

                        }
                    }
                }

                //если пара символов находится в одной строке
                if (iFirst == iSecond)
                {
                    if (jFirst == columns - columns) 
                                       
                    {
                        tempStr1 = Convert.ToString(table[iFirst, columns - 1]);//если символ первый в строке, кодируем его последним символом из матрицы
                    }
                    else
                    {
                        tempStr1 = Convert.ToString(table[iFirst, jFirst - 1]); //если символ не первый, кодируем его стоящим слева от него
                    }

                    if (jSecond == columns - columns) //если символ первый в строке, кодируем его последним символом из матрицы                 
                    {
                        tempStr2 = Convert.ToString(table[iSecond, columns - 1]);
                    }
                    else
                    {
                        tempStr2 = Convert.ToString(table[iSecond, jSecond - 1]); //если символ не первый, кодируем его стоящим слева от него
                    }

                }

                //если пара символов находится в одном столбце
                if (jFirst == jSecond)
                {
                    if (iFirst == rows - rows)
                    {
                        tempStr1 = Convert.ToString(table[rows - 1, jFirst]); //если символ первый в столбце, кодируем его последним символом из матрицы
                    }
                    else
                    {
                        tempStr1 = Convert.ToString(table[iFirst - 1, jFirst]); //если символ не первый, кодируем его стоящим выше от него
                    }

                    if (iSecond == rows - rows)
                    {
                        tempStr2 = Convert.ToString(table[rows - 1, jSecond]);//если символ первый в столбце, кодируем его последним символом из матрицы
                    }

                    else
                    {
                        tempStr2 = Convert.ToString(table[iSecond - 1, jSecond]);//если символ не первый, кодируем его стоящим выше от него
                    }
                }

                //если пара символов находиться в разных столбцах и строках
                if (iFirst != iSecond && jFirst != jSecond)
                {
                    tempStr1 = Convert.ToString(table[iFirst, jSecond]);
                    tempStr2 = Convert.ToString(table[iSecond, jFirst]);
                }

                if (tempStr1 == tempStr2)//записыавем результат кодирования
                {
                    incodeString += tempStr1 + tempStr2;
                }
                else
                {
                    incodeString += tempStr1 + tempStr2;
                }
            }
            message = incodeString;
            return message;
        }

       

        public string Incode(string message, string key)
        {
            int iFirst = 0, iSecond = 0, jFirst = 0, jSecond = 0;
            string tempStr1 = "", tempStr2 = "";
            string incodeString = "";
            var listAZ = Enumerable.Range('A', 'Z' - 'A' + 1).Select(c => (char)c);
            char[] alphabet = listAZ.ToArray();
            alphabet = alphabet.Except("J").ToArray();
            key = key.Replace(" ", "").Replace("J", "I");
            char[] keyword = key.Distinct().ToArray();
            message = message.Replace(" ", "").Replace("J", "I");
            int rows = 5, columns = 5;
            char[,] table = new char[rows, columns];
            for (int i = 0; i < keyword.Length; i++)
            {
                table[i / columns, i % columns] = keyword[i];
            }
            Console.WriteLine(keyword);
            alphabet = alphabet.Except(keyword).ToArray();
            for (int i = 0; i < alphabet.Length; i++)
            {
                int position = i + keyword.Length;
                table[position / columns, position % columns] = alphabet[i];
            }
            int temp = message.Length % 2;
            if (temp != 0) //если нет
            {               //то добавляем в конец строки символ " " 
                message = message.PadRight((message.Length + 1), 'Q');
            }
            int len = message.Length / 2;
            string[] str = new string[len]; //новый массив

            int l = -1; //служебная переменная

            for (int i = 0; i < message.Length; i += 2) //в старом массиве шаг равен 2
            {
                l++; //индексы для нового массива
                if (l < len)
                {
                    //Элемент_нового_массива[i] =  Элемент_старого_массива[i] +  Элемент_старого_массива[i+1]
                    str[l] = Convert.ToString(message[i]) + Convert.ToString(message[i + 1]);
                }

            }
            for (int i = 0; i < rows; i++)
            {   
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(table[i, j] + "\t");
                }
                Console.WriteLine("\t");
            }
            //координаты очередного найденного символа из каждой пары
            Console.WriteLine(message);
            foreach (string both in str)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        //координаты первого символа пары в исходной матрице
                        if (both[0] == (table[i, j]))
                        {
                            iFirst = i;
                            jFirst = j;
                        }

                        //координаты второго символа пары в исходной матрице
                        if (both[1] == (table[i, j]))
                        {
                            iSecond = i;
                            jSecond = j;

                        }
                    }
                }

                //если пара символов находится в одной строке
                if (iFirst == iSecond)
                {
                    if (jFirst == columns - 1)                   
                    {
                        tempStr1 = Convert.ToString(table[iFirst, 0]);//если символ последний в строке, кодируем его первым символом из матрицы
                    }
                    else
                    {
                        tempStr1 = Convert.ToString(table[iFirst, jFirst + 1]); //если символ не последний, кодируем его стоящим справа от него
                    }

                    if (jSecond == columns - 1) //если символ последний в строке, кодируем его первым символом из матрицы 
                    {
                        tempStr2 = Convert.ToString(table[iSecond, 0]);
                    }
                    else
                    {
                        tempStr2 = Convert.ToString(table[iSecond, jSecond + 1]); //если символ не последний, кодируем его стоящим справа от него
                    }

                }

                //если пара символов находится в одном столбце
                if (jFirst == jSecond)
                {
                    if (iFirst == rows - 1)
                    {
                        tempStr1 = Convert.ToString(table[0, jFirst]);
                    }
                    else
                    {
                        tempStr1 = Convert.ToString(table[iFirst + 1, jFirst]);
                    }

                    if (iSecond == rows - 1)
                    {
                        tempStr2 = Convert.ToString(table[0, jSecond]);
                    }

                    else
                    {
                        tempStr2 = Convert.ToString(table[iSecond + 1, jSecond]);
                    }
                }

                //если пара символов находиться в разных столбцах и строках
                if (iFirst != iSecond && jFirst != jSecond)
                {

                    tempStr1 = Convert.ToString(table[iFirst, jSecond]);
                    tempStr2 = Convert.ToString(table[iSecond, jFirst]);
                }

                if (tempStr1 == tempStr2)
                {
                    incodeString += tempStr1 + tempStr2;
                }
                else
                {
                    //записыавем результат кодирования
                    incodeString += tempStr1 + tempStr2;
                }
            }
            message = incodeString;
            return message;        
        }
    }
}
