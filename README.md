# 📦 PedidosApp

Sistema backend desenvolvido em **C# com .NET**, com foco em boas práticas de arquitetura, separação de responsabilidades e organização em camadas.

---

## 🚀 Objetivo

Este projeto foi criado com o objetivo de praticar e consolidar conhecimentos em:

* Desenvolvimento backend com C#
* Arquitetura em camadas (Domain, Infra, Application)
* Padrão Repository
* Organização de código limpa e escalável

---

## 🧠 Arquitetura do Projeto

O sistema foi estruturado seguindo uma separação clara de responsabilidades:

```
PedidosApp/
├── PedidosAppDomain
│   ├── Entidades
│   ├── Interfaces
│   ├── Serviços
│   └── DTOs
│
├── PedidosApp.Infra.Data
│   ├── Repositórios
│   └── Contexto de Dados
│
├── PedidosApp (API / Aplicação)
```

### 🔹 Camadas

* **Domain** → Regras de negócio e entidades
* **Infra** → Acesso a dados (Repository / Banco)
* **Application** → Entrada de requisições (Controllers)

---

## ⚙️ Tecnologias utilizadas

* C#
* .NET
* ASP.NET Core
* Docker (em configuração)
* Git & GitHub

---

## 🔄 Fluxo da aplicação

```
Cliente → Controller → Service → Repository → Banco de Dados
```

* A **Controller** recebe a requisição
* O **Service** aplica as regras de negócio
* O **Repository** realiza operações no banco
* A resposta retorna ao cliente

---

## 📌 Funcionalidades (em desenvolvimento)

* [ ] Cadastro de pedidos
* [ ] Listagem de pedidos
* [ ] Atualização de pedidos
* [ ] Remoção de pedidos

---

## 🐳 Docker

O projeto possui configuração inicial com Docker:

```
docker-compose.yml
```

(Em evolução)

---

## 📈 Evolução do Projeto

Este projeto está sendo desenvolvido de forma incremental, com foco em evolução contínua e aprendizado prático.

---

## 👨‍💻 Autor

**Edgard Pimenta**
Desenvolvedor em formação focado em backend com C#, .NET e arquitetura de software.

---

## 💡 Observação

Este projeto faz parte do meu processo de aprendizado e será continuamente melhorado com novas funcionalidades e boas práticas do mercado.
