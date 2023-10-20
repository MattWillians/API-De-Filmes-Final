# API-De-Filmes-Final
Versão Final da API de filmes, dessa vez com relacionamento de entidades. 

<h1>Sistema de Arquivos</h1>

- /Controllers:  Como o prórpio nome sugere, os controllers são responsáveis pela interação direta com o banco de dados, os controladores tem acesso direto ao banco de dados e fazem contato direto com as requisições HTTP

- /Data/Dtos: DTOS ou Data Transfer Objects são os arquivos cujo definem como criar objetos dos modelos baseados no CRUD (CREATE, READ UPDATE, DELETE)

Ou seja, vamos definir quais atributos são necessarios para fazer cada uma das operações no banco.

- /Data/ApiContext.cs: aqui definimos quais dos modelos nossos faram parte de uma tabela do banco de dados. O EntityFramework usa eles para criar as migrações posteriormente, e usamos a função "OnModelCreating" para definir algumas regras do banco de dados.

- /Models: Os models são "a forma do bolo" das nossas entidades do banco de dados, os modelos contem algumas regras de cada uma das entidades.

- /Profiles: Aqui, armazenamos e definimos os relacionamentos dados nos Dtos. Criando com AutoMapper, fazemos a relção entre DTOS e Models.

<h1>Como funciona a API</h1>
## POST /FilmesApi

Este método é usado para adicionar um novo filme ao banco de dados.

**Exemplo de Requisição:**

```http
POST /FilmesApi
Content-Type: application/json

{
  "titulo": "Nome do Filme",
  "diretor": "Nome do Diretor",
  "ano": 2023,
  "genero": "Ação"
}
```

## GET /FilmesApi

Este método é responsável por recuperar todos os filmes da lista de filmes dentro do banco de dados.

## GET /FilmesApi/{id}
Este método busca um filme com base na sua chave de acesso única.

**Exemplo de Requisição:**

```http
GET /FilmesApi/1
```

## PUT /FilmesApi/{id}

O método PUT é usado para atualizar TODAS as informações de um filme com base no seu ID único.

**Exemplo de Requisição:**

```http
PUT /FilmesApi/1
Content-Type: application/json

{
  "titulo": "Novo Título do Filme",
  "diretor": "Novo Diretor do Filme",
  "ano": 2024,
  "genero": "Comédia",
}
```

## PATCH /FilmesApi/{id}

O método PATCH é usado para atualizar UMA ou mais informações do filme em questão com base no seu ID único.

**Exemplo de Requisição:**

```http
PATCH /FilmesApi/1
Content-Type: application/json
[
	{
  		"genero": "Drama"
	}
]
```

DELETE /FilmesApi/{id}
Este método é usado para deletar um filme com base no seu ID.

**Exemplo de Requisição:**

```http
DELETE /FilmesApi/1
```


# Para mais informações, use a documentação do SWAGGER
