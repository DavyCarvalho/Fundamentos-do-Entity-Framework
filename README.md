# Fundamentos-do-Entity-Framework
Repositório para os códigos feitos durante o curso de Fundamentos do Entity Framework da balta.io

Descrição do curso:

Primeiramente, vamos aprender a como fazer um bom mapeamento de entidades de duas maneiras: via anotações e utilizando a API fluente. Seguiremos aprendendo como fazer o mapeamento de relacionamentos um-para-um (1:1), de um-para-muitos (1:N), e de muitos-para-muitos (N:N), que costumam gerar dúvidas.

Vamos implementar o básico de um CRUD (Create, Read, Update e Delete) e aprender como é o comportamento do Entity Framework com objetos aninhados e views.

Assim como uma aplicação, o banco de dados também evolui e sofre alterações, então vou te apresentar as Migrations que podem nos auxiliar tanto no processo de modificações do banco de dados, quanto na geração de scripts.

Por fim, não acredite em quem te diz que ORM não é performático! Durante as aulas e no último módulo, vou te dar as dicas para que você não caia nas armadilhas de performance do Entity Framework Core.

Neste curso de Entity Framework você vai...
Aprender o que é um ORM
Aprender a diferença entre o Dapper e o Entity Framework
Aprender sobre mapeamento no Entity Framework
Aprender sobre cenários de utilização do Entity Framework
Aprender quais são os benefícios e malefícios de utilizar o Entity Framework
Aprender sobre estratégias para modificações no banco de dados com migrações
Aprender sobre as abordagens Database First e Code First com o Entity Framework
Aprender o que é o DataContext e o DbSet para representar seu banco de dados
Aprender a criar modelos para uma entidade baseado no SQL DDL
Aprender a configurar a conexão com banco de dados no Entity Framework
Aprender como implementar um CRUD usando Entity Framework
Aprender a definir um nome da tabela diferente do nome do modelo no Entity Framework
Aprender a atualizar corretamente um objeto do banco de dados usando reidratação
Aprender sobre metadados e como o Entity Framework detecta mudanças nos modelos
Aprender como implementar a leitura de dados com Entity Framework da forma correta
Aprender a evitar problemas de performance usando ToList e Where no Entity Framework
Aprender a usar corretamente o AsNoTracking no Entity Framework
Aprender a usar o First, FirstOrDefault e Single para retornar objetos no Entity Framework
Aprender o que é mapeamento e formas de mapeamento no Entity Framework
Aprender a fazer o Fluent Mapping (Mapeamento Fluente) no Entity Framework
Aprender o que são e como fazer mapeamento usando DataAnnotations no Entity Framework
Aprender como melhorar o banco de dados gerado pelo Entity Framework
Aprender a gerar IDs automaticamente no Entity Framework
Aprender a definir restrições no campo de tamanho mínimo, máximo e nulo via Data Annotation
Aprender a definir o nome e o tipo de dados da coluna via Data Annotation
Aprender o que são Navigation Properties e como mapeá-las no Entity Framework
Aprender a criar e persistir objetos aninhados usando Entity Framework
Aprender a utilizar o Include no Entity Framework
Aprender como gerar um log das queries executadas pelo Entity Framework
Aprender a atualizar propriedades de um subconjunto a partir de Navigation Properties
Aprendendo a usar o Builder para configurar um mapeamento fluente no Entity Framework
Aprender a mapear uma chave primária com valor gerado no banco de dados
Aprender sobre mapeamento de relacionamentos no Entity Framework
Aprender como fazer a criação de índices mapeamento fluente no Entity Framework
Aprender a definir um valor padrão para uma propriedade no Entity Framework
Aprender sobre campos de data e cuidados com valores vazios e nulos
Aprender a mapear um relacionamento de um para um usando HasOne no Entity Framework
Aprender a mapear um relacionamento de um para muitos usando o HasMany no Entity Framework
Aprender a mapear um relacionamento de muitos para muitos usando HasMany no Entity Framework
Aprender a utilizar entidades virtuais no Entity Framework
Aprender os conceitos iniciais para trabalhar com Migrações (migrations) no Entity Framework
Aprender a gerar os arquivos de uma migração no Entity Framework
Aprender o que são os arquivos gerados na Migration
Aprender a atualizar o banco de dados utilizando Migrations do Entity Framework
Aprender a remover o uso de Migrations em um projeto
Aprender a gerar um script de migração para executar externamente
Aprender a como identificar situações que requerem melhoria de performance baseado em demandas do negócio
Aprender boas práticas na leitura de dados com Entity Framework
Aprender a paralelizar a execução de tarefas que consomem mais tempo
Aprender a utilizar os modos Eager Loading e Lazy Loading no Entity Framework
Aprender a reduzir o volume de dados retornado pelas consultas no Entity Framework
Aprender a implementar paginação de dados de uma consulta usando Entity Framework
Aprender sobre quando evitar o uso de Include e ThenInclude no Entity Framework
Para quem é recomendado este curso de Entity Framework
Para iniciantes que querem aprender sobre Entity Framework Core

Para pessoas que conhecem um pouco de SQL e querem descobrir uma nova abordagem de acesso à dados

Para pessoas que já conhecem Dapper e querem comparar com o EF

Para aqueles que não acreditam que o Entity Framework é performático

Para profissionais que querem aprender a ser produtivos com Entity Framework

Para profissionais com dúvidas no mapeamento de relacionamentos com EF Core

Para programadores em preparação para uma entrevista técnica

Para programadores buscando dicas básicas para melhorar a performance do EF no seu projeto

É importante ter alguma experiência com C# e SQL ou fazer estes cursos da nossa carreira Backend .NET antes de prosseguir

Tecnologias e versões utilizadas
.NET 5
Entity Framework Core 5.0.9
Azure Data Studio
Docker para executar SQL Server ou SQL Server Express
Visual Studio Code
Projetos do curso
Neste curso teremos o exemplo de um cenário de Blog, com posts, autores, usuários, categorias e tags. Faremos o mapeamento das entidades e dos relacionamentos, com anotações e via fluent API, e veremos o código básico implementar todo o comportamento de um CRUD, além de apresentar diversas dicas e detalhes sobre boa performance com o Entity Framework.
