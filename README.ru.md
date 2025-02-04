# LeetCode.AlgorithmicProblems

Структурированный и масштабируемый проект для решения алгоритмических задач на **C#**.
Все решения являются моей личной реализацией задач с платформы LeetCode.

---

## Структура проекта

```
LeetCode.AlgorithmicProblems/
├── Problems/                          # Определения задач и решения
└── Services/                          # Основные сервисы (например, ProblemRunner)
LeetCode.AlgorithmicProblems.Tests/    # Тесты и входные данные
└── TestData/                          # Данные для тестов
```

---

## Навигация по задачам

<details>
  <summary>Нажмите для отображения всех задач</summary>

|  #  |    Задача    | Ссылка на решение  |
|-----|--------------|------------|
|9    | [**Palindrome Number**](https://leetcode.com/problems/palindrome-number) | [Решения](LeetCode.AlgorithmicProblems/Problems/PalindromeNumber/) |
|13   | [**Roman to Integer**](https://leetcode.com/problems/roman-to-integer) | [Решения](LeetCode.AlgorithmicProblems/Problems/RomanToInteger/) |
|14   | [**Longest Common Prefix**](https://leetcode.com/problems/longest-common-prefix) | [Решения](LeetCode.AlgorithmicProblems/Problems/LongestCommonPrefix/) |

</details>

---

## Возможности

- **Несколько вариантов решений задач:** Легкое переключение между реализациями решений  
- **Модульное тестирование:** Тестирование решений через разные наборы входных данных 
- **Модульная архитектура:** Четкое разделение компонентов  

---

## Запуск проекта

1. Склонируйте репозиторий:
   ```bash
   git clone https://github.com/0x3l4/LeetCode.AlgorithmicProblems.git
   ```

2. Перейдите в папку проекта и выполните сборку:
   ```bash
   cd LeetCode.AlgorithmicProblems
   dotnet build
   ```

3. Запустите приложение:
   ```bash
   dotnet run
   ```

4. Запустите тесты:
   ```bash
   dotnet test
   ```

---

## Примеры задач

### Проверка числа на палиндром
Определяет, является ли заданное число палиндромом.

- **Решение A:** Простой реверс строки  
- **Решение B:** Через остаток

---

## Вклад

Я рад любым предложениям и доработкам! Форкните репозиторий и создайте PR.

---