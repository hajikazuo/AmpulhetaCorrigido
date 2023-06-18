using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpulhetaCorrigido
{
    public class Program
    {
        private static readonly List<Caixa> CaixaManager = new List<Caixa>();
        static void Main(string[] args)
        {
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

            var caixa2 = new Caixa
            {
                CodigoCaixa = 2,
                Ampulheta = new List<Ampulheta>
                {   
                new Ampulheta {Size = 1},
                new Ampulheta {Size = 3},
                new Ampulheta {Size = 2},
                new Ampulheta {Size = 3},
                new Ampulheta {Size = 1}
                }
            };

            CaixaManager.Add(caixa1);
            CaixaManager.Add(caixa2);

            var pequenas = CaixaAjustBySize("p", CaixaManager);
            var medias = CaixaAjustBySize("m", CaixaManager);
            var grandes = CaixaAjustBySize("g", CaixaManager);

            Console.WriteLine("Pequenas:");
            foreach (var amp in pequenas)
            {
                Console.WriteLine(amp.Size);
            }

            Console.WriteLine("Médias:");
            foreach (var amp in medias)
            {
                Console.WriteLine(amp.Size);
            }

            Console.WriteLine("Grandes:");
            foreach (var amp in grandes)
            {
                Console.WriteLine(amp.Size);
            }

            Console.ReadKey();
        }

        private static List<Ampulheta> CaixaAjustBySize(string tipoAjuste, List<Caixa> caixas)
        {
            var ampulhetas = new List<Ampulheta>();

            switch (tipoAjuste)
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
    

