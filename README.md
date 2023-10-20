# API-De-Filmes-Final
Versão Final da API de filmes, dessa vez com relacionamento de entidades. 

<h1>Sistema de Arquivos</h1>

- /Controllers:  Como o prórpio nome sugere, os controllers são responsáveis pela interação direta com o banco de dados, os controladores tem acesso direto ao banco de dados e fazem contato direto com as requisições HTTP

- /Data/Dtos: DTOS ou Data Transfer Objects são os arquivos cujo definem como criar objetos dos modelos baseados no CRUD (CREATE, READ UPDATE, DELETE)

Ou seja, vamos definir quais atributos são necessarios para fazer cada uma das operações no banco.

- /Data/ApiContext.cs: aqui definimos quais dos modelos nossos faram parte de uma tabela do banco de dados. O EntityFramework usa eles para criar as migrações posteriormente, e usamos a função "OnModelCreating" para definir algumas regras do banco de dados.

- /Models: Os models são "a forma do bolo" das nossas entidades do banco de dados, os modelos contem algumas regras de cada uma das entidades.

- /Profiles: Aqui, armazenamos e definimos os relacionamentos dados nos Dtos. Criando com AutoMapper, fazemos a relção entre DTOS e Models.

# Para mais informações use o Swagger!
