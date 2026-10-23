# blazor-pokeapi

Lista de exercícios — Desenvolvimento Web (Prof. Daniel Henrique Matos de Paiva).

Aplicação **Blazor WebAssembly Standalone** (.NET 10) que pede o nome de um Pokémon, consome a
[PokéAPI](https://pokeapi.co) (`GET https://pokeapi.co/api/v2/pokemon/{nome}`) e exibe
**Imagem, Id, Nome, Altura e Peso**.

## Funcionalidades

- Busca pelo nome (ex.: `pikachu`, `ditto`, `mr-mime`), pelo botão ou com Enter.
- O nome é normalizado (minúsculas, espaços viram hífen) e validado antes da chamada.
- Imagem obtida de `sprites.other["official-artwork"].front_default`, conforme o enunciado.
- Altura convertida de decímetros para metros e peso de hectogramas para quilos (ex.: Pikachu: 0,4 m e 6 kg).
- Pokémon inexistente (404), falha de conexão ou timeout exibem alerta na tela.

## Estrutura

| Arquivo                             | Responsabilidade                                       |
|-------------------------------------|--------------------------------------------------------|
| `BlazorPokeApi/Models/Pokemon.cs`   | Classes que mapeiam o JSON da PokéAPI                  |
| `BlazorPokeApi/Pages/Home.razor`    | Formulário, validação, chamada à API e exibição        |

## Como rodar

Requer .NET SDK 10.0 e conexão com a internet.

```bash
cd BlazorPokeApi
dotnet watch run
```

Acesse `http://localhost:5065` e teste com `pikachu`.
