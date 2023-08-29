using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosArrayList
{
    internal class ExerciciosIntermediario
    {
        public static void Exercicio0() //Inverta os elementos de um array
        {
            try
            {
                int[] arrayUm = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int[] arrayDois = new int[arrayUm.Length];

                string stringUm = "";
                for (int i = arrayUm.Length - 1; i >= 0; i--)
                {
                    stringUm = stringUm + arrayUm[i];
                }

                int j = 0;
                foreach (char bla in stringUm)
                {
                    arrayDois[j] = Convert.ToInt32(bla.ToString());
                    j++;
                }

                foreach (var bct in arrayDois)
                {
                    Console.WriteLine(bct);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        public static void Exercicio1() //Ordene uma lista de strings alfabeticamente
        {
            try
            {
                List<string> nomes = new List<string>() {  "David", "Eva", "Frank", "Grace", "Henry", "Ivy", "Jack", "Alice", "Bob", "Carol" };
                nomes.Sort();

                foreach (string nome in nomes)
                {
                    Console.WriteLine(nome + "; ");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio2() //Encontre elementos comuns entre dois arrays de inteiros
        {
            try
            {
                int[] array1 = { 18, 47, 9, 32, 86, 51, 23, 75, 14, 65 };
                int[] array2 = { 1, 42, 92, 3, 86, 52, 32, 7, 4, 66 };

                for (int i = 0; i < array1.Length; i++)
                {
                    for (int i2 = 0; i2 < array2.Length; i2++)
                    {
                        if (array1[i] == array2[i2])
                        {
                            Console.WriteLine(array1[i]);
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio3() // Implemente uma lista ligada simples
        {
            try
            {
                LinkedList<string> list = new LinkedList<string>();

                list.AddLast("Alice");
                list.AddLast("Bob");
                list.AddFirst("Charlie");
                list.AddLast("vou deletar");
                list.Remove("vou deletar");

                foreach (string nome in list)
                {
                    Console.WriteLine(nome + "; ");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio4() //Calcule a média dos elementos em uma lista de inteiros
        {
            try
            {
                bool parar = false;
                List<int> numeros = new List<int>();
                while (parar == false)
                {
                    Console.WriteLine("Digite um numero para calcular a media, Caso queira parar digite 'parar'");
                    string input = Console.ReadLine();

                    if (input.Trim().ToLower() != "parar")
                    {
                        numeros.Add(Convert.ToInt32(input));
                    }
                    else
                    {
                        parar = true;
                    }
                }
                int result = numeros.Sum() / numeros.Count();
                Console.WriteLine(result);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio5() //Utilizando LINQ, filtre os números pares de uma lista
        {
            try
            {
                List<int> numeros = new List<int>() { 18, 47, 9, 32, 86, 51, 23, 75, 14, 65 };
                var numerosPares = numeros.Where(numero => numero % 2 == 0);

                Console.WriteLine("Números pares na lista:");
                foreach (var numero in numerosPares)
                {
                    Console.Write(numero + " ");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio6() // Converta uma lista de inteiros em um array
        {
            try
            {
                List<int> numeros = new List<int>() { 18, 47, 9, 32, 86, 51, 23, 75, 14, 65 };
                int[] array = new int[] { };

                array = numeros.ToArray();

            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio7() //Encontre o valor mínimo e máximo em um array de inteiros
        {
            try
            {
                int[] array1 = { 18, 47, 9, 32, 86, 51, 23, 75, 14, 65 };

                var maior = array1.Max();
                var menor = array1.Min();

                Console.WriteLine(maior + " > " + menor);

            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio8() //Concatene duas listas de inteiros
        {
            try
            {
                List<int> numeros = new List<int>() { 18, 47, 9, 32, 86, 51, 23, 75, 14, 65 };
                List<int> numeros2 = new List<int>() { 22, 55, 8, 42, 64, 99, 16, 72, 10, 6 };

                numeros.AddRange(numeros2);

                foreach (var numero in numeros)
                {
                    Console.WriteLine(numero);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio9() //Remova duplicatas de uma lista de inteiros
        {
            try
            {
                List<int> numeros = new List<int>() { 18, 47, 9, 32, 8, 51, 23, 75, 18, 65, 8, 75 };
                List<int> numerosSemDuplicatas = numeros.Distinct().ToList();

                foreach (var numero in numerosSemDuplicatas)
                {
                    Console.Write(numero + ", ");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}
