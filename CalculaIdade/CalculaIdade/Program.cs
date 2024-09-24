using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome completo: ");
        string nome = Console.ReadLine();

        DateTime dataDeNascimento;

        while (true)
        {
            Console.Write($"Olá, {nome}! Digite sua data de nascimento (dd/MM/yyyy): ");
            string input = Console.ReadLine();

            if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataDeNascimento))
            {
                break;
            }
            else
            {
                Console.WriteLine("Data inválida. Por favor, insira a data no formato dd/MM/yyyy.");
            }
        }

        DateTime hoje = DateTime.Today;

        int idadeAnos = hoje.Year - dataDeNascimento.Year;

        if (dataDeNascimento.Date > hoje.AddYears(-idadeAnos))
        {
            idadeAnos--;
        }

        if (idadeAnos < 1)
        {
            int idadeMeses = (hoje.Year - dataDeNascimento.Year) * 12 + hoje.Month - dataDeNascimento.Month;

            if (dataDeNascimento.Day > hoje.Day)
            {
                idadeMeses--;
            }

            Console.WriteLine($"Olá, {nome}! Hoje {hoje.ToShortDateString()} sua idade é de: {idadeMeses} meses.");
        }
        else
        {
            Console.WriteLine($"Olá, {nome}! Hoje {hoje.ToShortDateString()} sua idade é de: {idadeAnos} anos.");
        }
    }
}