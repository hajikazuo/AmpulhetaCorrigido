using System;
using System.Collections.Generic;

namespace AmpulhetaCorrigido
{
    public class Program
    {
        static void Main(string[] args)
        {
            var caixas = new List<Caixa>();

            var caixa1 = new Caixa
            {
                CodigoCaixa = 1,
                Ampulheta = new List<Ampulheta>
                {
                    new Ampulheta {Size = 1},
                    new Ampulheta {Size = 2},
                    new Ampulheta {Size = 2},
                    new Ampulheta {Size = 3},
                    new Ampulheta {Size = 1}
                }
            };

            caixas.Add(caixa1);

            Console.WriteLine("\nAmpulhetas da Caixa 1:");
            ImprimirAmpulhetas(caixa1.Ampulheta);

            var caixa2 = new Caixa
            {
                CodigoCaixa = 2,
                Ampulheta = new List<Ampulheta>
                {
                    new Ampulheta {Size = 1},
                    new Ampulheta {Size = 2},
                    new Ampulheta {Size = 2},
                    new Ampulheta {Size = 3},
                    new Ampulheta {Size = 1}
                }
            };

            caixas.Add(caixa2);

            Console.WriteLine("\nAmpulhetas da Caixa 2:");
            ImprimirAmpulhetas(caixa2.Ampulheta);

            // Separando as ampulhetas por tamanho usando o método SepararAmpulhetaPorTamanho
            var pequenas = SepararAmpulhetaPorTamanho("p", caixas);
            var medias = SepararAmpulhetaPorTamanho("m", caixas);
            var grandes = SepararAmpulhetaPorTamanho("g", caixas);

            // Imprimindo as ampulhetas separadas por tamanho
            Console.WriteLine("\n---------------------------------------------------------\nSeparação das ampulhetas por tamanho: ");

            Console.WriteLine("\nPequenas:");
            ImprimirAmpulhetas(pequenas);

            Console.WriteLine("\nMédias:");
            ImprimirAmpulhetas(medias);

            Console.WriteLine("\nGrandes:");
            ImprimirAmpulhetas(grandes);

            Console.ReadKey();
        }

        // Método para imprimir as ampulhetas
        private static void ImprimirAmpulhetas(List<Ampulheta> ampulhetas)
        {
            foreach (var ampulheta in ampulhetas)
            {
                Console.WriteLine($"Tamanho: {ampulheta.Size}");
            }
        }

        // Método para separar as ampulhetas por tamanho
        private static List<Ampulheta> SepararAmpulhetaPorTamanho(string tamanho, List<Caixa> caixas)
        {
            var ampulhetas = new List<Ampulheta>();

            switch (tamanho)
            {
                case "p":
                    foreach (var item in caixas)
                    {
                        foreach (var amp in item.Ampulheta)
                        {
                            if (amp.Size == 1)
                            {
                                ampulhetas.Add(amp);
                            }
                        }
                    }
                    break;
                case "m":
                    foreach (var item in caixas)
                    {
                        foreach (var amp in item.Ampulheta)
                        {
                            if (amp.Size == 2)
                            {
                                ampulhetas.Add(amp);
                            }
                        }
                    }
                    break;
                case "g":
                    foreach (var item in caixas)
                    {
                        foreach (var amp in item.Ampulheta)
                        {
                            if (amp.Size == 3)
                            {
                                ampulhetas.Add(amp);
                            }
                        }
                    }
                    break;
            }

            return ampulhetas;
        }
    }
}
