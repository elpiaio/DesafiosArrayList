using DesafiosArrayList.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesafiosArrayList
{
    internal class ExerciciosAvancados
    {
        static public List<Carros> carros = new List<Carros>();

        public static void Exercicio0() // Encontre o elemento mais frequente em uma lista
        {
            try
            {
                List<int> numeros = new List<int>() { 18, 47, 9, 32, 8, 51, 23, 75, 18, 65, 8, 75 };
                List<int> numerosSemDuplicatas = numeros.Distinct().ToList();

                Console.WriteLine("Lista de números sem duplicatas:");
                foreach (var numero in numerosSemDuplicatas)
                {
                    Console.Write(numero + " ");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio1() //Converta um array de caracteres em uma string
        {
            try
            {
                List<char> caracteres = new List<char>() { 'a', 'B', 'C', 'D', 'E', ' ', 'd', 'g' };
                string bgl = "";

                foreach (var caracter in caracteres)
                {
                    bgl += Convert.ToString(caracter);
                }
                Console.WriteLine(bgl);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio2() //Rotacione os elementos de uma lista (e.g., [1,2,3] torna-se [3,1,2])
        {
            try
            {
                List<int> lista = new List<int>() { 1, 2, 3, 4, 5 };
                int quantidade = 2;

                Console.WriteLine("Lista original:");
                foreach (var numero in lista)
                {
                    Console.Write(numero + " ");
                }

                int tamanho = lista.Count;

                List<int> elementosRotacionados = new List<int>();

                for (int i = tamanho - quantidade; i < tamanho; i++)
                {
                    elementosRotacionados.Add(lista[i]);
                }

                for (int i = tamanho - 1; i >= quantidade; i--)
                {
                    lista[i] = lista[i - quantidade];
                }

                for (int i = 0; i < quantidade; i++)
                {
                    lista[i] = elementosRotacionados[i];
                }

                Console.WriteLine("\nLista após rotação:");
                foreach (var numero in lista)
                {
                    Console.Write(numero + " ");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio3() //Verifique se uma lista de inteiros está ordenada
        {
            try
            {
                List<int> numeros = new List<int>() { 15, 72, 43, 8, 91, 27, 54, 39, 66, 12, 88, 20, 47, 30, 59, 3, 76, 18, 62, 10 };
                var numerosVar = numeros.OrderBy(x => x);

                //for (int i = 0; i < numeros.Count(); i++)
                //{
                //    for (int j = 0; j < (numeros.Count() - i - 1); j++)
                //    {
                //        if (numeros[j] > numeros[j + 1])
                //        {
                //            var temp = numeros[j];
                //            numeros[j] = numeros[j + 1];
                //            numeros[j + 1] = temp;
                //        }
                //    }
                //}
                foreach (var num in numerosVar)
                {
                    Console.Write(num + ",");
                }
                Console.WriteLine("\n");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio4() //Some dois arrays de inteiros
        {
            try
            {
                int[] array1 = { 18, 47, 9, 32, 86, 51, 23, 75, 14, 65 };
                int[] array2 = { 1, 42, 92, 3, 86, 52, 32, 7, 4, 66 };

                var soma = array1.Sum() + array2.Sum();
                Console.WriteLine(soma);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio5() //Utilize delegates para processar uma lista de inteiros
        {
            try
            {
                List<int> lista = new List<int>() { 1, 2, 3, 4, 5 };
                Action<int> processador = ProcessarNumero;

                foreach (int numero in lista)
                {
                    processador(numero);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void ProcessarNumero(int numero)
        {
            Console.WriteLine("Número processado: " + numero);
        }

        public static void Exercicio6() //Encontre a interseção de duas listas usando LINQ
        {
            try
            {
                List<int> lista1 = new List<int>() { 1, 2, 3, 4, 5 };
                List<int> lista2 = new List<int>() { 3, 4, 5, 6, 7 };

                for (int i1 = 0; i1 < lista1.Count(); i1++)
                {
                    for (int i2 = 0; i2 < lista2.Count(); i2++)
                    {
                        if (lista1[i1] == lista2[i2])
                        {
                            Console.WriteLine(lista1[i1]);
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio7() //Encontre o subarray contínuo dentro de um array que tem a soma máxima
        {
            try
            {
                Console.WriteLine("Digite o indexador inicial dentro do array");
                int inputInicial = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o indexador final dentro do array");
                int inputFinal = Convert.ToInt32(Console.ReadLine());

                int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                ArraySegment<int> subArray = new ArraySegment<int>(originalArray, 2, 4);

                Console.WriteLine("Subarray:");
                foreach (int num in subArray)
                {
                    Console.Write(num + " ");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio8() //Implemente uma fila (queue) usando lista
        {
            try
            {
                List<string> modelos = new List<string>() {"fusion","jetta","saveiro","civic","focus" };
                Queue<string> veiculos= new Queue<string>();
                foreach (var veiculo in modelos)
                {
                    veiculos.Enqueue(veiculo);
                    Console.WriteLine("-- " + veiculo);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio9() //Crie uma classe genérica que possa trabalhar com listas de diferentes tipos
        {
            try
            {
                Console.WriteLine("Digite oque vc deseja fazer:\n1 - consultar os carros em estoque\n2 - adicionar carros ao estoque");
                string escolha = Console.ReadLine();

                if (escolha.Trim() == "1")
                {
                    if (carros.Count == 0)
                    {
                        Console.WriteLine("Não há carros em estoque.");
                    }
                    else
                    {
                        foreach (Carros carro in carros)
                        {
                            Console.WriteLine($"--------\nMarca: {carro.Marca}\nModelo: {carro.Modelo}\nAno: {carro.Ano}");
                        }
                    }
                }
                if (escolha.Trim() == "2")
                {
                    Console.WriteLine("Digite a marca do carro:");
                    string marca = Console.ReadLine();

                    Console.WriteLine("Digite o modelo do carro:");
                    string modelo = Console.ReadLine();

                    Console.WriteLine("Digite o ano do carro:");
                    int ano = int.Parse(Console.ReadLine());

                    Carros novoCarro = new Carros
                    {
                        Marca = marca,
                        Modelo = modelo,
                        Ano = ano
                    };

                    carros.Add(novoCarro);
                    Console.WriteLine("Carro adicionado ao estoque.");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}
