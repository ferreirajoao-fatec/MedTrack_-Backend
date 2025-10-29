# 🩺 MedTrack

O **MedTrack** é um sistema desenvolvido em **C# com ASP.NET Core** voltado ao **registro e gerenciamento de informações médicas**, com foco em facilitar o trabalho de **agentes de saúde** e melhorar o acompanhamento de pacientes. O sistema permite o cadastro de pacientes, profissionais da saúde e o registro de dados clínicos de forma organizada e segura.

---

## 🎯 Objetivo

O projeto tem como objetivo principal **centralizar informações médicas** em um ambiente digital, auxiliando profissionais da saúde no controle e acompanhamento dos atendimentos realizados.
Com o MedTrack, busca-se reduzir falhas no registro de dados e otimizar o processo de monitoramento da saúde de pacientes.

---

## 🧩 Funcionalidades

* Cadastro de **pacientes** com dados pessoais e clínicos.
* Registro de **agentes de saúde** responsáveis pelos atendimentos.
* Inserção, visualização e atualização de **informações médicas**.
* Controle de **usuários e permissões de acesso**.
* Interface amigável e de fácil navegação.

---

## 👨‍⚕️ Perfis de Usuário

* **Administrador:** gerencia os agentes de saúde e controla o acesso ao sistema.
* **Agente de Saúde:** cadastra e atualiza informações de pacientes, além de registrar dados médicos.
* **Paciente (futuro):** poderá visualizar seus dados e históricos de atendimento.

---

## 🧠 Tecnologias Utilizadas

* **Linguagem:** C#
* **Framework:** ASP.NET Core
* **Banco de Dados:** SQL Server
* **IDE:** Visual Studio / Visual Studio Code
* **Padrão de Arquitetura:** MVC (Model-View-Controller)

---

## ⚙️ Instalação e Execução

1. **Clone o repositório:**

   ```bash
   [git clone https://github.com/usuario/MedTrack.git](https://github.com/ferreirajoao-fatec/MedTrack_-Backend.git)
   ```

2. **Abra o projeto no Visual Studio.**

3. **Configure o banco de dados** no arquivo *appsettings.json*, ajustando a *connection string* conforme seu ambiente local.

4. **Execute as migrações:**

   ```bash
   Update-Database
   ```

5. **Inicie o servidor:**

   ```bash
   dotnet run
   ```

6. Acesse o sistema em:
   👉 `https://localhost:5001` ou `http://localhost:5000`

---

## 🗂️ Estrutura do Projeto

```
MedTrack/
├── Controllers/        # Lógica de controle das rotas e regras de negócio
├── Models/             # Modelos de dados (pacientes, agentes, registros)
├── Views/              # Páginas de interface do usuário
├── Data/               # Contexto do banco de dados e configuração do EF Core
├── Migrations/         # Arquivos de migração gerados pelo Entity Framework
├── wwwroot/            # Arquivos estáticos (CSS, JS, imagens)
└── appsettings.json    # Configurações da aplicação
```

---

## 🧾 Exemplo de Dados Registrados

* **Paciente:** João Silva
* **Agente de Saúde:** Maria Oliveira
* **Dados Médicos:** Pressão arterial, glicemia, medicamentos contínuos, observações clínicas.

---

## 🎓 Contexto Acadêmico

Projeto desenvolvido como parte das atividades do curso de **Desenvolvimento de Software Multiplataforma** da **FATEC Matão**.
---

## 👨‍💻 Autores

**Fernanda Garcia**
Aluna da FATEC Matão – Curso de Desenvolvimento de Software Multiplataforma

**João Gabriel Ferreira**
Aluno da FATEC Matão – Curso de Desenvolvimento de Software Multiplataforma

**José Henrique Bessa**
Aluno da FATEC Matão – Curso de Desenvolvimento de Software Multiplataforma

**Mariana Lourenço**
Aluna da FATEC Matão – Curso de Desenvolvimento de Software Multiplataforma

**Nicolas Henrique ALves**
Aluno da FATEC Matão – Curso de Desenvolvimento de Software Multiplataforma

**Sophia Cavallaro**
Aluna da FATEC Matão – Curso de Desenvolvimento de Software Multiplataforma
---

## 🪪 Licença

Este projeto é de uso acadêmico e livre para fins educacionais.
© 2025 MedTrack – Todos os direitos reservados.
