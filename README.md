# 🧮 Calculadora Básica (C# WinForms)

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Status](https://img.shields.io/badge/Status-Em%20Evolu%C3%A7%C3%A3o-blue?style=for-the-badge)

Este projeto faz parte do meu portfólio de estudos e documenta minha evolução como desenvolvedor Back-End/Desktop. Trata-se de uma calculadora funcional desenvolvida do zero utilizando **C#** e **Windows Forms**.

O objetivo principal deste repositório não é apenas ter uma calculadora, mas treinar lógica de programação, manipulação de interface gráfica (UI) e organização estrutural de código.

---

## 🚀 Funcionalidades Atuais (MVP)

- Operações matemáticas básicas: Soma (`+`), Subtração (`-`), Multiplicação (`×`) e Divisão (`÷`).
- Botões de limpar: `C` (Limpa visor) e `CE` (Limpa toda a memória).
- Controle de decimais: Tratamento lógico para impedir múltiplas vírgulas no mesmo número.
- Feedback visual: O operador escolhido aparece na tela (`lblConta`).

---

## 🧠 Arquitetura e Lógica Aplicada

Para manter o código limpo e de fácil manutenção, utilizei as seguintes práticas:
* **Uso de `#region`:** Separação visual do código (Métodos, Botões Numéricos, Botões Operadores).
* **Tipagem Segura:** Uso do tipo `decimal` em vez de `double` ou `float` para garantir precisão em cálculos financeiros/exatos.
* **Separação de Responsabilidades:** A lógica matemática está isolada no método `Calcular()`, enquanto os botões apenas capturam os eventos.

---

## 📈 Próximos Passos (Roadmap de Estudos)

Como este projeto é um registro do meu aprendizado, aqui estão as melhorias que pretendo implementar nas próximas versões:

- [ ] **Tratamento de Exceções (Try/Catch):** Evitar que o programa quebre ao tentar dividir por zero.
- [ ] **Validação de Input:** Adicionar uma verificação (`string.IsNullOrEmpty`) antes do `decimal.Parse` para evitar erro caso o usuário clique em um operador com o visor vazio.
- [ ] **Cálculos em Cadeia:** Permitir operações contínuas (ex: `5 + 5 + 5` ser calculado dinamicamente).
- [ ] **Suporte ao Teclado:** Fazer os botões responderem às teclas físicas do teclado numérico (Eventos `KeyPress`).

---

## 📂 Como testar o projeto

1. Clone este repositório em sua máquina local:
   ```bash
   git clone [https://github.com/SEU_USUARIO/NOME_DO_REPOSITORIO.git](https://github.com/SEU_USUARIO/NOME_DO_REPOSITORIO.git)
