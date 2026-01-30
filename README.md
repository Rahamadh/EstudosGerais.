# EstudosGerais


# 🚀 C# Learning Path: De Lógica a POO

Bem-vindo ao meu repositório de estudos centrais em **C#** e **.NET**.
Este repositório documenta minha evolução técnica, começando pelos fundamentos de algoritmos e lógica de programação até a aplicação prática de arquitetura de software com Orientação a Objetos.

## 🧠 Sobre o Repositório

O objetivo deste projeto é centralizar exercícios, desafios e pequenos projetos que demonstram o domínio da linguagem C#. O código é separado em módulos que representam diferentes estágios do aprendizado.

## 📚 Tópicos e Estrutura

### 1. Fundamentos e Lógica
Exercícios focados em sintaxe, controle de fluxo e manipulação de dados.
* **Estruturas de Controle:** Loops (`for`, `while`) e condicionais (`if/else`) para gerenciamento de fluxo.
* **Interação via Console:** Entrada e saída de dados, parsing de tipos (`int.Parse`) e exibição formatada.
* **Coleções:** Uso inicial de Arrays e Listas para manipulação de conjuntos de dados.

### 2. Programação Orientada a Objetos (POO)
A aplicação prática dos quatro pilares da POO, demonstrada através de um **Sistema de Batalha RPG**.

#### Destaque: RPG Battle Engine
Um sistema modular para simulação de combate e gerenciamento de fichas de personagens.

* **Classes e Objetos:** Modelagem de entidades complexas como `Personagem`, encapsulando atributos vitais (Vida, Mana) e comportamentos.
* **Herança e Polimorfismo:**
    * Classe base abstrata `Oficio` que define a estrutura para classes especializadas como `Mago`.
    * Especialização de comportamento onde cada classe gerencia sua própria evolução de nível e magias.
* **Interfaces e Contratos:**
    * Implementação de `IAtaqueMagico`, `IAtaqueCorpoACorpo` e `IAtaqueADistancia` para desacoplar as ações de combate da classe do personagem.
    * Isso permite que diferentes classes implementem formas distintas de atacar mantendo uma assinatura comum.
* **Composição e Associações:**
    * Sistema de `Magia` associado às classes, permitindo listas de feitiços (ex: `BolaDeFogo`) com atributos próprios de dano e elemento.
    * Uso de `Dictionary` e `List` para gerenciar atributos e inventário de magias dinamicamente.
* **Tratamento de Dados:** Criação de Enums (`TipoAtributo`) para padronizar tipos de dados e evitar "números mágicos" no código.

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C# (foco em versões modernas .NET 8/9)
* **Framework:** .NET Console Applications
* **Conceitos:** SOLID, Clean Code, POO.

## 🚀 Como Executar

Para rodar os exemplos deste repositório:

1. Certifique-se de ter o [SDK do .NET](https://dotnet.microsoft.com/) instalado.
2. Clone o repositório:
   ```bash
   git clone [https://github.com/Rahamadh/EstudosGeraisCSharp.git](https://github.com/Rahamadh/EstudosGerais.git)

