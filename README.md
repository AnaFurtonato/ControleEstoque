# 🛒 Controle de Estoque - Console App (.NET / C#)

Projeto desenvolvido para praticar conceitos de **backend com C# e .NET**, simulando um sistema simples de **controle de estoque** executado no console.

O sistema permite cadastrar produtos, listar itens e realizar compras com controle de quantidade em memória.

---

# 🎯 Objetivo do Projeto

Praticar:

* Programação orientada a objetos (OO)
* Classes e objetos
* Métodos e propriedades
* Listas em memória (`List<T>`)
* Estrutura de menu (console)
* Regras de negócio
* Separação de responsabilidades
* Lógica de backend

---

# 🧠 Arquitetura do Projeto

O sistema foi separado em três classes principais:

## 📦 Produtos

Responsável por representar o produto.

Propriedades:

* Nome
* Quantidade
* Preço

Métodos:

* ExibirProduto()
* ConfirmaCadastro()

Função:
Armazena os dados e comportamento de um produto.

---

## 🏪 Loja

Responsável pelas regras de negócio.

Funcionalidades:

* Cadastrar produto
* Listar produtos
* Comprar produto
* Controlar estoque em memória

A classe Loja mantém uma lista:

List<Produtos>

Essa lista funciona como um "banco de dados" em memória.

---

## 🖥 MenuPrincipal

Responsável pela interface com o usuário.

Exibe o menu:

1 - Cadastrar produto
2 - Listar produtos
3 - Comprar produto
4 - Sair

O menu chama os métodos da classe Loja.

---

# ⚙️ Funcionalidades

## ✅ Cadastrar Produto

Permite cadastrar:

* Nome
* Quantidade
* Preço

Antes de salvar, o sistema pede confirmação.

---

## 📋 Listar Produtos

Exibe todos os produtos cadastrados:

Exemplo:

Arroz - 10 - R$ 20
Feijão - 5 - R$ 8

---

## 🛒 Comprar Produto

Permite comprar um produto pelo nome.

O sistema:

* verifica se existe
* verifica estoque
* diminui quantidade
* confirma compra

Exemplo:

Compra realizada com sucesso!

---

## 📉 Controle de Estoque

Ao comprar:

Quantidade--

O estoque é atualizado automaticamente.

---

# 🧪 Tecnologias utilizadas

* C#
* .NET
* Console Application
* Programação Orientada a Objetos
* List<T> (memória)

---

# 🚀 Próximas melhorias

* Editar produto
* Remover produto
* Buscar produto
* Comprar múltiplas unidades
* Carrinho de compras
* Valor total do estoque
* API ASP.NET Core
* Frontend Angular

---

# 👩‍💻 Autora

Ana Clara Furtonato
Estudos de Backend com C# / .NET
