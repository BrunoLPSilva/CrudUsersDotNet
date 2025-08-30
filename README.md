# API de Usuários - .NET 8 Web API

Esta é uma **Web API** desenvolvida em **.NET 8**, utilizando **Entity Framework Core** com **SQL Server**, estruturada para operações CRUD de usuários, incluindo suporte a Swagger para documentação e testes.

---

## 🛠 Tecnologias utilizadas

- .NET 8 Web API
- Entity Framework Core
- SQL Server
- Swagger (Swashbuckle)
- JSON para envio/recebimento de dados
- Visual Studio / VS Code

---

## 📦 Estrutura do projeto

API_Usuarios/
│
├─ Controllers/
│ └─ UsersController.cs
│
├─ Data/
│ └─ ApplicationDbContext.cs
│
├─ DTOs/
│ └─ UserDTO.cs
│
├─ Models/
│ └─ User.cs
│
├─ Program.cs
└─ appsettings.json


---

## 🧩 Models

**User.cs**
```json
public class User
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Endereco { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Cargo { get; set; }
    public bool Ativo { get; set; }
}
```
---
⚡ Endpoints principais

Criar usuário
POST /api/users
```json
{
  "nome": "Bruno Silva",
  "email": "bruno@teste.com",
  "telefone": "11960892536",
  "endereco": "Rua das Orquídeas",
  "dataNascimento": "1995-12-04",
  "cargo": "TI",
  "ativo": true
}
```
Resposta: 201 Created com o usuário criado.
---

Listar usuário por ID
GET /api/users/{id}

Retorna JSON do usuário:
```json

{
  "id": 1,
  "nome": "Bruno Silva",
  "email": "bruno@teste.com",
  "telefone": "11960892536",
  "endereco": "Rua das Orquídeas",
  "dataNascimento": "1995-12-04",
  "cargo": "TI",
  "ativo": true
}
```

---
Atualizar usuário
PUT /api/users/{id}

Body JSON (com campos atualizados):
```json

{
  "id": 1,
  "nome": "Bruno S. Silva",
  "email": "bruno.silva@teste.com",
  "telefone": "11960892536",
  "endereco": "Rua das Orquídeas, 123",
  "dataNascimento": "1995-12-04",
  "cargo": "TI",
  "ativo": true
}
```
Resposta: 204 No Content (ou 200 OK com JSON atualizado).

---

Deletar usuário (DELETE)

DELETE /api/users/{id}

Resposta: 204 No Content

Erro se não encontrado: 404 Not Found

---
##  🛠 Configuração do banco de dados 
No appsettings.json, String de conexão:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=UsuariosDb;Trusted_Connection=True;"
}

Comandos EF Core para criar banco e migrations:

- dotnet ef migrations add NOME-MIGRATION
- dotnet ef database update

---

## 📌 Observações importantes
Todos os campos devem ser preenchidos corretamente para evitar erros de validação.

Datas devem ser enviadas em formato ISO (YYYY-MM-DD).

Campo ativo é do tipo booleano (true/false), não string.

A API possui Swagger para testar todos os endpoints:
Acesse: https://localhost:{porta}/swagger/index.html

---
