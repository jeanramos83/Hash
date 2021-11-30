using System;
using System.Collections;

namespace TDE2_Hashing
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Tabela de Hash
            // Classificação primeira edição Brasileirao 
            // por pontos corridos (Ano 2003) 
            // Fonte: wikipedia.org/

            Hashtable hashtable = new Hashtable();
            hashtable.Add(1,  "Cruzeiro.......100pts");
            hashtable.Add(2,  "Santos..........87pts");
            hashtable.Add(3,  "São Paulo.......78pts");
            hashtable.Add(4,  "São Caetano.....74pts");
            hashtable.Add(5,  "Coritiba........73pts");
            hashtable.Add(6,  "Internacional...72pts");
            hashtable.Add(7,  "Atl.Mineiro.....72pts");
            hashtable.Add(8,  "Flamengo........66pts");
            hashtable.Add(9,  "Goiás...........65pts");
            hashtable.Add(10, "Paraná..........65pts");
            hashtable.Add(11, "Figueirense.....65pts");
            hashtable.Add(12, "Atl.Paranaense..61pts");
            hashtable.Add(13, "Guarani.........61pts");
            hashtable.Add(14, "Criciúma........60pts");
            hashtable.Add(15, "Corinthians.....59pts");
            hashtable.Add(16, "Vitória.........56pts");
            hashtable.Add(17, "Vasco...........54pts");
            hashtable.Add(18, "Juventude.......53pts");
            hashtable.Add(19, "Fluminense......52pts");
            hashtable.Add(20, "Grêmio..........50pts");
            hashtable.Add(21, "Ponte Preta.....50pts");
            hashtable.Add(22, "Paysandu........49pts");
            hashtable.Add(23, "Fortaleza.......49pts");
            hashtable.Add(24, "Bahia...........46pts");

            foreach (string value in hashtable.Values)
            {
                Console.WriteLine("Posição : " + value);
            }
            Console.ReadKey();
        }
    }
}
