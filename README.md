🌍 Travel RPG System 🌍
📌 О проекте:
Travel RPG System — мой первый демонстрационно-обучающий проект, созданный для закрепления базовых принципов программирования на C#. Это текстовый RPG-симулятор путешественника, в котором персонаж перемещается по случайно сгенерированным биомам, сталкивается с препятствиями и принимает решения, влияющие на его судьбу.

🎯 Цели проекта:
Реализовать симулятор путешествий, используя:

Базовый синтаксис C#

Принципы ООП (инкапсуляция, наследование, полиморфизм)

Принципы SOLID (ну... по крайней мере, я старался 😉)

Работу с Git

Алгоритмы сортировки и поиска

⚙ Реализация:
Генерация биомов реализована через Stack

В каждом биоме есть список случайных событий

Выпадение событий зависит от нахождения случайного числа в массиве, который сортируется одним из 3 алгоритмов:

Пузырьковая сортировка

Быстрая сортировка

Сортировка вставками

После сортировки используется линейный или бинарный поиск для определения, сработает ли событие

💡 Что можно было бы улучшить?:
На ранних этапах разработки появились идеи, которые не были реализованы, но могут быть полезны в будущем:
✔ Писать Unit-тесты с самого начала
✔ Добавить throw new Exception конструкции для отлова ошибок
✔ Реализовать выпадение лута и наград через REST API, чтобы запуск игры зависел от наличия файлов на виртуальном сервере

🚀 Финал:
Готовность проекта: ~70%

MVP завершено: игра работает, демонстрирует задуманные механики

Нужна полировка и доработка, но главная цель — продемонстрировать знания и закрепить навыки — достигнута

📌 Итог:
Этот проект был не просто кодом, а полноценным опытом: от продумывания архитектуры до исправления багов и рефакторинга. Он показал, как важна практика, и дал мне уверенность в том, что следующий проект будет еще лучше. 🔥
