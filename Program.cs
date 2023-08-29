using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeticao = "r";
            while (repeticao == "r")
            {
                List<string> listdesafiosbasicos = new List<string>()
                {
"Descrição**: Crie um array de inteiros com 5 elementos e imprima todos os elementos.",
"Descrição**: Crie uma lista de strings e adicione 3 nomes a ela, depois imprima todos os nomes.",
"Descrição**: Crie um programa que encontre o maior número em um array de inteiros.",
"Descrição**: Crie um programa que some todos os elementos de uma lista de inteiros.",
"Descrição**: Crie um array 2D 3x3 e preencha com números. Imprima a diagonal principal.",
"Descrição**: Crie um programa que adicione elementos em uma lista até que o usuário diga 'parar'.",
"Descrição**: Crie um programa que remova um elemento específico de um array de strings.",
"Descrição**: Crie uma classe `Pessoa` e faça uma lista de pessoas. Adicione 3 pessoas e imprima seus nomes.",
"Descrição**: Implemente a busca binária em um array ordenado.",
"Descrição**: Crie um método que clone uma lista de inteiros."
                };
                List<string> listdesafiosintermediarios = new List<string>()
                {
"Descrição: Inverta os elementos de um array.",
"Descrição: Ordene uma lista de strings alfabeticamente.",
"Descrição: Encontre elementos comuns entre dois arrays de inteiros.",
"Descrição: Implemente uma lista ligada simples.",
"Descrição: Calcule a média dos elementos em uma lista de inteiros.",
"Descrição: Utilizando LINQ, filtre os números pares de uma lista.",
"Descrição: Converta uma lista de inteiros em um array.",
"Descrição: Encontre o valor mínimo e máximo em um array de inteiros.",
"Descrição: Concatene duas listas de inteiros.",
 "Descrição: Remova duplicatas de uma lista de inteiros.",

                };
                List<string> listdesafiosdificeis = new List<string>()
                {
"Descrição: Encontre o elemento mais frequente em uma lista.",
"Descrição: Converta um array de caracteres em uma string.",
"Descrição: Rotacione os elementos de uma lista (e.g., [1,2,3] torna-se [3,1,2]).",
"Descrição: Verifique se uma lista de inteiros está ordenada.",
"Descrição: Some dois arrays de inteiros.",
"Descrição: Utilize delegates para processar uma lista de inteiros.",
"Descrição: Encontre a interseção de duas listas usando LINQ.",
"Descrição: Encontre o subarray contínuo dentro de um array que tem a soma máxima.",
"Descrição: Implemente uma fila (queue) usando lista.",
"Descrição: Crie uma classe genérica que possa trabalhar com listas de diferentes tipos."
                };

                Console.WriteLine("----------------------\nbem vindo ao Desafio máximo do Nego!!!!\n---------------------- \ndigite o numero correspondente para escolher uma opção:\n\n");
                Console.WriteLine("Escolha o tipo de desafio\n--------------\n1 = facil\n2 = medio\n3 = dificil");

                string escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        while (repeticao == "r")
                        {
                            for (int i = 0; i < listdesafiosbasicos.Count; i++)
                            {
                                Console.WriteLine(i + " = " + listdesafiosbasicos[i]);
                            }
                            ExerciciosFacilEscolha();


                            Console.WriteLine("Digite [r] para repetir o metodo ou qualquer outra letra para voltar ao inicio");
                            repeticao = Console.ReadLine();
                        }
                        break;
                    case "2":
                        while (repeticao == "r")
                        {
                            for (int i = 0; i < listdesafiosintermediarios.Count; i++)
                            {
                                Console.WriteLine(i + " = " + listdesafiosintermediarios[i]);
                            }
                            ExerciciosIntermediarioEscolha();

                            Console.WriteLine("Digite [r] para repetir o metodo ou qualquer outra letra para voltar ao inicio");
                            repeticao = Console.ReadLine();
                        }
                        break;
                    case "3":
                        while (repeticao == "r")
                        {
                            for (int i = 0; i < listdesafiosdificeis.Count; i++)
                            {
                                Console.WriteLine(i + " = " + listdesafiosdificeis[i]);
                            }
                            ExerciciosAvancadosEscolha();


                            Console.WriteLine("Digite [r] para repetir o metodo ou qualquer outra letra para voltar ao inicio");
                            repeticao = Console.ReadLine();
                        }
                        break;
                    default:

                        break;
                }

                Console.WriteLine("Digite [r] para repetir a escolha do nivel ou qualquer outra letra para finalizar");
                repeticao = Console.ReadLine();
                Console.Clear();
            }
        }
        public static void ExerciciosFacilEscolha()
        {
            string escolha = Console.ReadLine();
            if (escolha == "0")
            {
                ExerciciosFacill.Exercicio0();
            }
            if (escolha == "1")
            {
                ExerciciosFacill.Exercicio1();
            }
            if (escolha == "2")
            {
                ExerciciosFacill.Exercicio2();
            }
            if (escolha == "3")
            {
                ExerciciosFacill.Exercicio3();
            }
            if (escolha == "4")
            {
                ExerciciosFacill.Exercicio4();
            }
            if (escolha == "5")
            {
                ExerciciosFacill.Exercicio5();
            }
            if (escolha == "6")
            {
                ExerciciosFacill.Exercicio6();
            }
            if (escolha == "7")
            {
                ExerciciosFacill.Exercicio7();
            }
            if (escolha == "8")
            {
                ExerciciosFacill.Exercicio8();
            }
            if (escolha == "9")
            {
                ExerciciosFacill.Exercicio9();
            }
        }
        public static void ExerciciosIntermediarioEscolha()
        {
            string escolha = Console.ReadLine();
            if (escolha == "0")
            {
                ExerciciosIntermediario.Exercicio0();
            }
            if (escolha == "1")
            {
                ExerciciosIntermediario.Exercicio1();
            }
            if (escolha == "2")
            {
                ExerciciosIntermediario.Exercicio2();
            }
            if (escolha == "3")
            {
                ExerciciosIntermediario.Exercicio3();
            }
            if (escolha == "4")
            {
                ExerciciosIntermediario.Exercicio4();
            }
            if (escolha == "5")
            {
                ExerciciosIntermediario.Exercicio5();
            }
            if (escolha == "6")
            {
                ExerciciosIntermediario.Exercicio6();
            }
            if (escolha == "7")
            {
                ExerciciosIntermediario.Exercicio7();
            }
            if (escolha == "8")
            {
                ExerciciosIntermediario.Exercicio8();
            }
            if (escolha == "9")
            {
                ExerciciosIntermediario.Exercicio9();
            }
        }
        public static void ExerciciosAvancadosEscolha()
        {
            string escolha = Console.ReadLine();
            if (escolha == "0")
            {
                ExerciciosAvancados.Exercicio0();
            }
            if (escolha == "1")
            {
                ExerciciosAvancados.Exercicio1();
            }
            if (escolha == "2")
            {
                ExerciciosAvancados.Exercicio2();
            }
            if (escolha == "3")
            {
                ExerciciosAvancados.Exercicio3();
            }
            if (escolha == "4")
            {
                ExerciciosAvancados.Exercicio4();
            }
            if (escolha == "5")
            {
                ExerciciosAvancados.Exercicio5();
            }
            if (escolha == "6")
            {
                ExerciciosAvancados.Exercicio6();
            }
            if (escolha == "7")
            {
                ExerciciosAvancados.Exercicio7();
            }
            if (escolha == "8")
            {
                ExerciciosAvancados.Exercicio8();
            }
            if (escolha == "9")
            {
                ExerciciosAvancados.Exercicio9();
            }
        }
    }
}
