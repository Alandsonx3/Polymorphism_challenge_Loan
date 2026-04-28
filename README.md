# 💻 Atividade Prática: Polimorfismo em C#

## 🎯 Objetivo

Aplicar na prática os conceitos de:

- Programação Orientada a Objetos (POO)
- Herança
- Polimorfismo
- Reutilização de código

---

## 🧠 Contexto

Uma das melhores formas de aprender programação é **simular problemas reais** e transformar isso em código.

Neste desafio, você irá modelar um sistema de empréstimos onde diferentes instituições aplicam **taxas de juros diferentes**, sem duplicar código.

---

## 📌 Desafio

Crie um sistema de empréstimos utilizando **polimorfismo**.

---

## 🧩 Estrutura esperada

### 🔹 Classe Base: `Emprestimo`

Deve conter:

- Nome do cliente  
- Valor do empréstimo  
- Valor dos juros  
- Taxa padrão de 20%  

### Método:

```csharp
public virtual void AplicarJuros()
