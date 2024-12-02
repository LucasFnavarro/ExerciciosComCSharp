using System;

/* Crie uma matriz linear com 6 números e adicione o número 75 no final dela */

namespace InserirNumeroNoFimDoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = [10, 20, 30, 40, 50];
            array = AddNumeroNoArray(array, 75);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}" + ",");
            }



            string[] alunos = { "Lucas", "Maria", "José", "Fernando" };
            alunos = AddNome(alunos, "Vitória");

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine(alunos[i] + ",");
            }

        }

        public static string[] AddNome(string[] alunos, string aluno)
        {
            string[] nomesTemp = new string[alunos.Length + 1];

            for (int i = 0; i < alunos.Length; i++)
            {
                nomesTemp[i] = alunos[i];
            }

            nomesTemp[alunos.Length] = aluno;
            return nomesTemp;


        }

        public static int[] AddNumeroNoArray(int[] array, int value)
        {
            int[] tempArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[array.Length] = value;
            return tempArray;
        }
    }
}