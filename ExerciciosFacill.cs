using DesafiosArrayList.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosArrayList
{
    internal class ExerciciosFacill
    {
        public static void Exercicio0() //Crie um array de inteiros com 5 elementos e imprima todos os elementos
        {
            try
            {
                int[] ints = { 1, 2, 3, 4, 5 };
                for (int i = 0; i < ints.Count(); i++)
                {
                    Console.WriteLine(ints[i]);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio1() //Crie uma lista de strings e adicione 3 nomes a ela, depois imprima todos os nomes
        {
            try
            {
                List<string> nomes = new List<string>() { "Serjão", "Nego", "José" };
                Console.WriteLine(String.Join(", ", nomes));
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio2() //Crie um programa que encontre o maior número em um array de inteiros.",
        {
            try
            {
                int[] numeros = new int[10] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
                int maior = 0;
                for (int i = 0; i < numeros.Count(); i++)
                {
                    if (numeros[i] > maior)
                    {
                        maior = numeros[i];
                    }
                }
                Console.WriteLine("maior: " + maior);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio3() //Crie um programa que some todos os elementos de uma lista de inteiros
        {
            try
            {
                Console.WriteLine("Digite os números para serem somados separados por vírgula");
                var input = Console.ReadLine();
                var numerosString = input.Split(',');

                List<int> numeros = new List<int>();

                foreach (var numeroString in numerosString)
                {
                    var bct = numeroString.Replace(" ", "");
                    numeros.Add(Int32.Parse(bct));
                }
                int soma = numeros.Sum();
                Console.WriteLine($"A soma é: {soma}");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio4() //Crie um array 2D 3x3 e preencha com números. Imprima a diagonal principal
        {
            try
            {
                int[,] matriz = new int[,]
{
                { 2, 1, 1 },
                { 8, 5, 4 },
                { 3, 1, 9 }
};
                bool parar = false;
                int linha = 0; int coluna = 0;

                while (parar == false)
                {
                    try
                    {
                        Console.WriteLine(matriz[linha, coluna]);
                        linha++;
                        coluna++;
                    }
                    catch
                    {
                        parar = true;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio5() //Crie um programa que adicione elementos em uma lista até que o usuário diga 'parar'
        {
            try
            {
                bool parar = false;
                List<string> inputs = new List<string>();

                while (parar == false)
                {
                    Console.WriteLine("Digite algo para adicionar em uma lista, Caso queira parar digite 'parar'");
                    string input = Console.ReadLine();
                    if (input.Trim().ToLower() != "parar")
                    {
                        inputs.Add(input);
                    }
                    else
                    {
                        parar = true;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio6() //Crie um programa que remova um elemento específico de um array de strings
        {
            try
            {
                string[] nomes = { "Ana", "Carlos", "Mariana", "Pedro", "Lúcia", "João", "Isabela", "Rafael", "Sofia", "Gustavo" };
                bool parar = false;
                while (parar == false)
                {
                    for (int i = 0; i < nomes.Length; i++)
                    {
                        Console.WriteLine(i + " = "+nomes[i]);
                    }
                    Console.WriteLine("Digite qual vc deseja remover (o numero né bobão)");
                    var input = Convert.ToInt32(Console.ReadLine());

                    nomes[input] = null;

                    Console.WriteLine("Deseja parar ou continuar? Digite:\n[parar]\n[qualquer letra]");
                    var input2 = Console.ReadLine();

                    if (input2.Trim().ToLower() == "parar")
                    {
                        parar = true;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio7() // Crie uma classe `Pessoa` e faça uma lista de pessoas. Adicione 3 pessoas e imprima seus nomes
        {
            try
            {
                int i = 0;
                List<Pessoas> ListPessoas = new List<Pessoas>();
                while (i < 3)
                {
                    Console.WriteLine("digite um nome");
                    var input = Console.ReadLine();
                    ListPessoas.Add(new Pessoas() { NomePessoas = input });
                    i++;
                }

                foreach (var pessoa in ListPessoas)
                {
                    Console.WriteLine(pessoa.NomePessoas);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio8() //Implemente a busca binária em um array ordenado
        {
            try
            {
                int[] array = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40 };
                int procurado = 32;

                int esquerda = 0;
                int direita = array.Count();

                while (esquerda <= direita)
                {
                    int middle = esquerda + (direita - esquerda) / 2;

                    if (array[middle] == procurado)
                    {
                        Console.WriteLine($"o numero procurado({procurado}) foi encontrado");
                        return;
                    }
                    else if (array[middle] < procurado)
                    {
                        esquerda = middle + 1; 
                    }
                    else
                    {
                        direita = middle - 1; 
                    }
                }
                Console.WriteLine("o numero nao existe nessa lista");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public static void Exercicio9() //Crie um método que clone uma lista de inteiros
        { 
            try
            {
                List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                List<int> numeros2 = new List<int>();
                numeros2.AddRange(numeros);

                foreach (var num in numeros2)
                {
                    Console.WriteLine(num);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}
