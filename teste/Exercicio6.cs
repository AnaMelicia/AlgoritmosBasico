
namespace teste
{
    public static class Exercicio_6
    {
        public static void Executar()
        {
            List<string> nomes = new List<string>();
            nomes.Add("joao");
            nomes.Add("Bruno");
            nomes.Add("Ana");

            var nomesComO = nomes.RemoveAll(nome => nome.Contains("o"));

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

        }
    }
}
