using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aline.API.Models
{
    public class Cliente
    {
        [JsonPropertyName("id")]
        public int IdCliente { get; set; }

        [JsonPropertyName("nomeCompleto")]
        public string NomeCompleto { get; set; }


        [JsonPropertyName("telefone")]
        public long Telefone { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}