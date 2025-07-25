namespace Aula_4
{
    public class Program
    {
        public static void Main()
        {
            // Durante a aula 4, foi ensinado a criar um programa de login simples.
            // Mas, optei por usar if e else, já que o programa ensinado era bem simples.
            Console.WriteLine("-------LOGIN-------");

            Console.Write("Digite seu nome: "); string? nome = Console.ReadLine();
            Console.Write("Digite sua senha: "); string? senha = Console.ReadLine();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha))
            {
                Console.WriteLine("Nome ou senha inválidos.");
                return;
            }

            if (nome == "André" || senha == "Andre@135849")
            {
                Console.WriteLine("Login realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Nome ou senha inválidos.");
            }
        }
    }
}