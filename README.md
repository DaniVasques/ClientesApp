# ClientesApp

Projeto desenvolvido em **C# com .NET 9** para simular um **sistema de controle de clientes**, com interface web em **Blazor WebAssembly**, API em **ASP.NET Core Minimal API** e camada de dados separada.

O objetivo deste projeto é praticar a construção de uma aplicação organizada em camadas, trabalhando cadastro e consulta de clientes, integração entre front-end e back-end, validações de formulário e estruturação de uma solução web completa.

---

## Sobre o projeto

O **ClientesApp** foi criado como projeto de estudo prático para reforçar conhecimentos em:

- C#
- .NET 9
- Blazor WebAssembly
- ASP.NET Core Minimal API
- Entity Framework Core
- Validação com DataAnnotations
- Consumo de API com HttpClient
- Organização em múltiplos projetos

A aplicação foi dividida em três partes principais:

- **ClientesApp.UI** → interface web
- **ClientesApp.API** → API para cadastro e consulta de clientes
- **ClientesApp.Data** → camada de dados com entidade e contexto

---

## Funcionalidades atuais

- Página inicial do sistema
- Cadastro de clientes
- Consulta de clientes cadastrados
- Validação de campos no formulário
- Integração entre interface e API
- Estrutura em camadas separadas
- Documentação da API com Swagger / OpenAPI / Scalar

---

## Estrutura da solução

```bash
ClientesApp/
├── ClientesApp.API
├── ClientesApp.Data
├── ClientesApp.UI
└── ClientesApp.sln
