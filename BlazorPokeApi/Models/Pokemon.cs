using System.Text.Json.Serialization;

namespace BlazorPokeApi.Models
{
    // Mapeia apenas os campos usados de GET https://pokeapi.co/api/v2/pokemon/{nome}.
    // O JSON completo tem centenas de campos; os não mapeados são ignorados na desserialização.
    public class Pokemon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Nome { get; set; }

        // A API envia a altura em decímetros (ex.: 4 = 0,4 m).
        [JsonPropertyName("height")]
        public int Altura { get; set; }

        // A API envia o peso em hectogramas (ex.: 60 = 6 kg).
        [JsonPropertyName("weight")]
        public int Peso { get; set; }

        [JsonPropertyName("sprites")]
        public Sprites? Sprites { get; set; }
    }

    public class Sprites
    {
        [JsonPropertyName("other")]
        public OutrosSprites? Outros { get; set; }
    }

    public class OutrosSprites
    {
        // O nome do campo no JSON tem hífen, por isso o JsonPropertyName é obrigatório aqui.
        [JsonPropertyName("official-artwork")]
        public ArteOficial? ArteOficial { get; set; }
    }

    public class ArteOficial
    {
        [JsonPropertyName("front_default")]
        public string? FrontDefault { get; set; }
    }
}
