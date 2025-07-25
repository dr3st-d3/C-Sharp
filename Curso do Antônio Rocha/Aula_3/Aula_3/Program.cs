namespace Aula_3 
{
    public class Program 
    {
        public static void Main() 
        {
            // Este é um exemplo de código C# que demonstra o uso de constantes, variáveis e tipos dinâmicos.
            // Uma constante é um valor que não muda durante a execução do programa.
            // Uma constante não pode ser alterada após sua definição.
            const string Saldação = "Olá, Mundo!"
                Console.WriteLine(Saldação);

            // Variáveis são usadas para armazenar valores que podem mudar durante a execução do programa.
            // Variáveis podem ser alteradas após sua definição. Porém, elas não podem ser mudadas de tipo.
            // Por exemplo, uma variável do tipo inteiro não pode ser alterada para um tipo string.
            var nome = "André"
                Console.WriteLine($"Meu nome é {nome}.");

            // Já o tipo dinâmico permite que a variável mude de tipo durante a execução do programa.
            // Isso significa que você pode atribuir um valor de qualquer tipo a uma variável dinâmica.
            dynamic idade = 22;
                Console.WriteLine($"Eu tenho {idade} anos.");
        }
    }
}