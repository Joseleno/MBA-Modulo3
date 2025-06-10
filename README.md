# **[Título do Projeto] - Plataforma De Educação Online**

## **1. Apresentação**

Bem-vindo ao repositório do projeto **Plataforma De Educação Online**. Este projeto é uma entrega dedicado ao aprofundamento nas práticas de arquitetura, modelagem e qualidade de software, essenciais para o desenvolvimento de sistemas robustos e escaláveis.

### **Autor**
- **Joseleno Moreira**

## **2. Proposta do Projeto**

O projeto consiste em:

O sistema será dividido em duas grandes responsabilidades: 
1. Backend (API RESTful): Desenvolvido com ASP.NET Core WebAPI, 
responsável pelo processamento de dados e lógica de negócios e 
exposição de todos os endpoints do negócio em uma única API. 
2. Bounded Contexts (BC): Cada BC deve possuir as camadas necessárias 
para implementar as soluções de cada problema de negócio. 
    • Os BC’s não precisam ser iguais (mesma complexidade, precisar 
    usar CQRS, aplicar mesmos padrões) use conforme seus critérios. 
    • TDD para modelagem e ações de negócios 
    • Testes de integração para validar os casos de uso 
    • Banco de Dados: SQL Server com EF Core para persistência e 
    gerenciamento de dados,  
    • Deve haver suporte para SQLite para validação sem dependência de 
    infra. 
    • O usuário logado (interativo) deve corresponder a persona do 
    negócio (Aluno, Administrador)

## **3. Tecnologias Utilizadas**

- **Linguagem de Programação:** C#
- **Backend:**
  - ASP.NET Core Web API
  - Entity Framework Core
- **Banco de Dados:** 
  - SQL Server e SQLite com EF Core (o uso de SQLite deve 
estar sempre configurado com o Seed para que qualquer avaliador do 
projeto possa executar sem a infra do BD). 
- **Autenticação e Autorização:**
  - ASP.NET Core Identity
  - JWT (JSON Web Token) para autenticação na API
- **Testes:**
  - Testes de unidades (via TDD) com cobertura mínima de 80% 
  - Testes de integração completos simulando todos processos críticos 
(casos de uso).
- **Documentação da API:** Swagger

## **4. Estrutura do Projeto**

A estrutura do projeto é organizada da seguinte forma:

- src/
- README.md - Arquivo de Documentação do Projeto
- FEEDBACK.md - Arquivo para Consolidação dos Feedbacks
- .gitignore - Arquivo de Ignoração do Git

## **5. Funcionalidades Implementadas**

- **Autenticação e Autorização:** Diferenciação entre Alunos e administradores.
- **API RESTful:** Exposição de endpoints para operações via API.
- **Documentação da API:** Documentação automática dos endpoints da API utilizando Swagger.

## **6. Como Executar o Projeto**

### **Pré-requisitos**

- .NET SDK 8.0 ou superior
- SQL Server
- Visual Studio 2022 ou superior (ou qualquer IDE de sua preferência)
- Git

### **Passos para Execução**

1. **Clone o Repositório:**
   - `git clone https://github.com/Joseleno/MBA-Modulo3.git`
   - `cd MBA-Modulo3`

2. **Configuração do Banco de Dados:**
   - No arquivo `appsettings.json`, configure a string de conexão do SQL Server.
   - Rode o projeto para que a configuração do Seed crie o banco e popule com os dados básicos

3. **Executar a API:**
   - `cd src/PlataformaDeEducacaoOnline`
   - `dotnet run`
   - Acesse a documentação da API em: http://localhost:5001/swagger

## **7. Instruções de Configuração**

- **JWT para API:** As chaves de configuração do JWT estão no `appsettings.json`.
- **Migrações do Banco de Dados:** As migrações são gerenciadas pelo Entity Framework Core. Não é necessário aplicar devido a configuração do Seed de dados.

## **8. Documentação da API**

A documentação da API está disponível através do Swagger. Após iniciar a API, acesse a documentação em:

http://localhost:5001/swagger

## **9. Avaliação**

- Este projeto é parte de um curso acadêmico e não aceita contribuições externas. 
- Para feedbacks ou dúvidas utilize o recurso de Issues
- O arquivo `FEEDBACK.md` é um resumo das avaliações do instrutor e deverá ser modificado apenas por ele.
