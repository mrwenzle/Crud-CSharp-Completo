# 🛒 Gerenciador de Produtos (Full Stack CRUD)

> Um sistema completo de gerenciamento de estoque com interface moderna (Dark Mode) e API robusta em .NET 8.

![Status do Projeto](https://img.shields.io/badge/Status-Concluído-brightgreen) ![License](https://img.shields.io/badge/License-MIT-blue)

## 🖥️ Sobre o Projeto

Este projeto é uma aplicação **Full Stack** desenvolvida para demonstrar a implementação das operações fundamentais de um sistema (CRUD: Create, Read, Update, Delete).

O objetivo foi conectar um **Back-end robusto** (C# e SQL Server) a um **Front-end moderno e responsivo**, garantindo persistência de dados e uma boa experiência de usuário.

### 📸 Screenshots

*<img width="1365" height="599" alt="Captura de tela 2026-01-15 180245" src="https://github.com/user-attachments/assets/81b9aad8-cb15-4784-9cea-a3a8253057b8" />
*

## 🚀 Tecnologias Utilizadas

### Back-end
* **C# / .NET 8**: Construção da API RESTful.
* **Entity Framework Core**: ORM para manipulação do banco de dados.
* **SQL Server**: Banco de dados relacional para persistência.
* **Swagger**: Documentação e testes da API.

### Front-end
* **HTML5 & CSS3**: Layout moderno com tema Dark Mode e design responsivo.
* **JavaScript (ES6+)**: Consumo da API via `fetch`, manipulação do DOM e lógica assíncrona.

## ✨ Funcionalidades

- [x] **Criar:** Cadastro de novos produtos com validação básica.
- [x] **Ler:** Listagem dinâmica de produtos vindos do banco de dados.
- [x] **Atualizar:** Edição de produtos existentes (reaproveitando o formulário).
- [x] **Deletar:** Remoção de produtos com confirmação de segurança.
- [x] **UI/UX:** Interface amigável com feedback visual e identidade visual personalizada.

## ⚙️ Como Rodar o Projeto

### Pré-requisitos
* .NET SDK instalado.
* SQL Server (ou LocalDB) instalado.

### Passo a Passo

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/SEU_USUARIO/Crud-CSharp-Completo.git](https://github.com/SEU_USUARIO/Crud-CSharp-Completo.git)
    ```

2.  **Configure o Banco de Dados (Back-end):**
    * Navegue até a pasta do projeto C#.
    * Atualize a string de conexão no `appsettings.json` se necessário.
    * Rode as migrations para criar o banco:
    ```bash
    dotnet ef database update
    ```
    * Inicie a API:
    ```bash
    dotnet run
    ```

3.  **Inicie o Front-end:**
    * Vá até a pasta `Frontend`.
    * Abra o arquivo `index.html` no seu navegador.

## 📬 Contato

[Meu LinkedIn](https://www.linkedin.com/in/gabriel-silva-wenzle/) | [Meu GitHub](https://github.com/mrwenzle)
