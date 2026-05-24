# 🛒 Controle de Estoque - Console App (.NET / C#)

Projeto desenvolvido para praticar conceitos de desenvolvimento backend com **C# e .NET**, simulando um sistema completo de controle de estoque executado no console.

O sistema permite cadastrar, listar, buscar, editar, remover e comprar produtos utilizando Programação Orientada a Objetos (OO) e armazenamento em memória com `List<T>`.

---

# 🎯 Objetivo do Projeto

Praticar conceitos fundamentais de backend:

* Programação Orientada a Objetos
* Classes e Objetos
* Métodos e propriedades
* Encapsulamento
* CRUD completo
* Listas em memória
* Estrutura de menus
* Regras de negócio
* Validação de entrada
* Manipulação de coleções

---

# 🧠 Estrutura do Projeto

O sistema foi separado em três responsabilidades principais:

## 🖥 Program / MenuPrincipal

Responsável pela interação com o usuário.

Funcionalidades:

* Exibir menu
* Ler opções
* Chamar regras da loja

Menu disponível:

1 - Cadastrar produto
2 - Listar produtos
3 - Comprar produto
4 - Editar produto
5 - Remover produto
6 - Sair

---

## 📦 Produtos

Representa um produto da loja.

Propriedades:

* Nome
* Quantidade
* Preço

Métodos:

* ExibirProduto()
* ConfirmaCadastro()

Responsabilidade:
Armazenar os dados e comportamento de um produto.

---

## 🏪 Loja

Responsável pelas regras de negócio do sistema.

A classe mantém os produtos em memória utilizando:

List<Produtos>

Essa lista funciona como um banco de dados temporário.

---

# ⚙️ Funcionalidades Implementadas

## ✅ Cadastro de Produtos

Permite:

* Nome
* Quantidade
* Preço

Antes de salvar:

* o sistema solicita confirmação do usuário.

Exemplo:

Você tem certeza que quer cadastrar Arroz a R$ 20 com 5 unidades?

---

## 📋 Listagem de Produtos

Exibe todos os produtos cadastrados.

Exemplo:

Arroz - R$ 20 - Quantidade: 5
Feijão - R$ 10 - Quantidade: 2

---

## 🛒 Compra de Produtos

Permite:

* selecionar produto
* validar estoque
* reduzir quantidade automaticamente

Regras:

* impede compra sem estoque
* informa produto não encontrado

---

## ✏️ Edição de Produtos

Permite editar:

* Nome
* Quantidade
* Preço
* Todos os dados

A busca do produto ignora:

* letras maiúsculas/minúsculas

Utilizando:

StringComparison.OrdinalIgnoreCase

---

## 🗑️ Remoção de Produtos

Permite:

* localizar produto
* confirmar remoção
* remover da lista

Antes de remover:

* o sistema pede confirmação do usuário.

---

# 🧪 Conceitos praticados

* CRUD (Create, Read, Update, Delete)
* foreach
* List<T>
* bool
* return
* switch
* while
* validação de dados
* int.Parse()
* double.Parse()
* string.IsNullOrEmpty()
* Equals()
* Contains()
* inferência de tipo
* referência de objetos
* manipulação de listas

---

# 🚀 Tecnologias Utilizadas

* C#
* .NET
* Console Application
* Programação Orientada a Objetos

---

# 🧠 Aprendizados do Projeto

Durante o desenvolvimento foram praticados conceitos importantes como:

* Separação de responsabilidades
* Estruturação de classes
* Regras de negócio
* Arquitetura orientada a objetos
* Manipulação de memória
* Fluxo de sistemas backend
  
---

# 👩‍💻 Autora

Ana Furtonato

Estudos focados em Backend com C# / .NET
