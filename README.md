# Hypesoft Challenge

Este repositório contém a implementação de um desafio técnico, com foco principal no **back-end**, priorizando organização de código, clareza arquitetural e boas práticas de desenvolvimento.

O desenvolvimento concentrou-se na construção de uma base sólida de API, estruturada para permitir evolução futura, incluindo a integração com um front-end.

---

## Visão Geral

A proposta do projeto envolve uma aplicação dividida em duas camadas principais:

- **Back-end**: API responsável pela gestão de categorias, seguindo princípios de Clean Architecture e conceitos de DDD.
- **Front-end**: Camada de interface prevista para consumo da API (não implementada nesta entrega).

Estrutura do repositório:

/frontend
/backend

> A pasta de front-end foi mantida apenas como referência estrutural, sem implementação funcional nesta etapa.

---

## Funcionalidades Implementadas

### Back-end

- Estrutura baseada em **Clean Architecture**, separando Domain, Application, Infrastructure e API
- Modelagem da entidade de domínio `Category e Product`
- Criação de Categorias e Products via API
- Listagem de categorias e products
- Uso de **MediatR** para desacoplamento entre controllers e regras de negócio
- Validações utilizando **FluentValidation**
- Persistência de dados com **MongoDB**

---

## Funcionalidades Não Implementadas

- Front-end para consumo da API
- Testes automatizados
- Paginação e filtros
- Tratamento global de erros
- Melhorias de observabilidade (logs e métricas)
- Queries específicas
- Tratamento completo dos erros previstos

Esses pontos ficaram planejados para uma próxima etapa de desenvolvimento.

---

## Decisões Técnicas

- O foco foi direcionado ao **back-end** para garantir uma base arquitetural bem definida antes da construção da interface.
- **Clean Architecture** foi adotada para manter o domínio independente de frameworks e detalhes externos.
- **DDD (Domain-Driven Design)** auxiliou na organização do domínio e na definição clara de responsabilidades.
- **MediatR** foi utilizado para evitar lógica de negócio nos controllers e reduzir acoplamento.
- **FluentValidation** centraliza regras de validação de forma clara e reutilizável.

---

## Como Rodar o Projeto Localmente

### Back-end

1. Acesse a pasta do back-end:
   cd backend/src/Hypesoft.API
2. Rode a aplicação com:
   dotnet run
3. A API estará disponível em: localhost:5235
4. Antes de qualquer teste, abra outro terminal na pasta raiz desse repositório
5. Rode o mongodb com
   docker compose up mongo
