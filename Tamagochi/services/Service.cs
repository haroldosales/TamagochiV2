namespace Tamagochi
{
    internal class Service
    {
        private readonly HttpClient _client;
        private readonly System.Text.Json.JsonSerializerOptions _jsonOptions = new System.Text.Json.JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public Service()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/")
            };
        }

        // Returns a formatted string with details about the Pokémon.
        public async Task<string> dadosPork(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("name", nameof(name));

            try
            {
                using var response = await _client.GetAsync(name.Trim().ToLowerInvariant()).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                await using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                var pok = await System.Text.Json.JsonSerializer.DeserializeAsync<Pokemon>(stream, _jsonOptions).ConfigureAwait(false);

                if (pok == null) return "Pokemon not found.";

                var abilityNames = pok.Abilities?.Select(a => a.Ability?.Name ?? string.Empty).Where(s => !string.IsNullOrEmpty(s));
                var abilitiesText = abilityNames != null ? string.Join(", ", abilityNames) : "N/A";

                return $"Nome do Pokemon: {pok.Name}\r\nAltura: {pok.Height}\r\nPeso: {pok.Weight}\r\nHabilidade(s): {abilitiesText}";
            }
            catch (HttpRequestException ex)
            {
                return $"Request error: {ex.Message}";
            }
            catch (System.Text.Json.JsonException ex)
            {
                return $"Deserialization error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        // Returns just the Pokémon name (or an error message).
        public async Task<string> OneOne(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("name", nameof(name));

            try
            {
                using var response = await _client.GetAsync(name.Trim().ToLowerInvariant()).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                await using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                var pok = await System.Text.Json.JsonSerializer.DeserializeAsync<Pokemon>(stream, _jsonOptions).ConfigureAwait(false);

                return pok?.Name ?? "Pokemon not found.";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

       

        // Minimal models to map the JSON returned by pokeapi.co for the fields used.
        private class Pokemon
        {
            public string? Name { get; set; }
            public int Height { get; set; }
            public int Weight { get; set; }
            public List<PokemonAbility>? Abilities { get; set; }
        }

        private class PokemonAbility
        {
            public AbilityInfo? Ability { get; set; }
            public bool IsHidden { get; set; }
            public int Slot { get; set; }
        }

        private class AbilityInfo
        {
            public string? Name { get; set; }
            public string? Url { get; set; }
        }
    }
}
