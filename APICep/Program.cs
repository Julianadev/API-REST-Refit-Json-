using APICep.Interfaces;
using Refit;

internal class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            var cepModels = RestService.For<ICep>("http://viacep.com.br");
            Console.WriteLine("Informe o CEP:");

            string cepInformado = Console.ReadLine().ToString();

            Console.WriteLine($"Consultando informações do CEP: {cepInformado}");

            var anddress = await cepModels.GetAddressAsync(cepInformado);

            Console.WriteLine($"\nLogradouro:{anddress.Logradouro} - \nBairro:{anddress.Bairro} - \nComplemento:{anddress.Complemento} - " +
                $"\nCEP:{anddress.Cep} - \nUF:{anddress.UF} - \nDDD:{anddress.DDD} - \nLocalidade:{anddress.Localidade}");

            Console.ReadKey();
        }

        catch (Exception e)
        {
            Console.WriteLine("Erro na consulta de CEP" + e.Message);
        }
    }
}