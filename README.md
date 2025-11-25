# Todo API (.NET + Entity Framework)

Este projeto é uma API simples para gerenciamento de tarefas (*Todo List*), desenvolvida com **.NET** e **Entity Framework Core**, utilizando **SQLite** como banco de dados.

A API implementa operações essenciais de CRUD: **Create**, **GetAll**, **GetById**, **Patch** e **Delete**.

---

## 🚀 Tecnologias Utilizadas

- .NET 8  
- Entity Framework Core  
- ASP.NET Web API  
- SQLite  

---

## 📌 Endpoints

### **Criar tarefa**
**POST /todo**

Cria uma nova tarefa no banco.

**Exemplo de body:**
```json
{
  "title": "Ler um livro"
}
```

---

### **Listar todas as tarefas**
**GET /todo**

Retorna todas as tarefas cadastradas.

---

### **Buscar tarefa por ID**
**GET /todo/{id}**

Retorna uma tarefa específica.

---

### **Atualizar parcialmente uma tarefa**
**PATCH /todo/{id}**

Atualiza somente os campos enviados.

---

### **Deletar tarefa**
**DELETE /todo/{id}**

Remove a tarefa do banco.

---

## 🗂 Estrutura do Projeto

```
TodoAPI/
│── Controllers/
│   └── TodoController.cs
│── Data/
│   └── AppDbContext.cs
│── Models/
│   └── TodoModel.cs
│── Program.cs
│── todo.db
└── README.md
```

---

## 📦 Migrations e Banco de Dados

Gerar migration:
```bash
dotnet ef migrations add InitialCreate
```

Aplicar no banco:
```bash
dotnet ef database update
```

---

## ▶️ Executando o Projeto

```bash
dotnet run
```

A API fica disponível em:

```
http://localhost:5234
```

ou

```
https://localhost:7255
```

---

## 📄 Modelo da Entidade

```csharp
public class TodoModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public bool IsComplete { get; set; }
}
```

---

## 📘 Sobre

Este projeto serve como exemplo prático de uma API REST simples utilizando .NET e EF Core.  
