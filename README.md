# Итоговая работа по курсу "Введение в программирование"

## Задача
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

В решении, помимо кода, должны присутствовать:
- Блок-схема исполнительного алгоритма
- Описание работы алгоритма

## Описание работы.

*Т.к. требования и ограничения к инструменту разработки отсутствуют, модуль написан на **Python** c применением библиотеки NumPy (в качестве заменителя массивов)*

**Назначение модуля:** модуль принимает на вход массив любых строк и возвращает другой массив, содержащий строки, не превышающие заданного лимита длины.

Модуль может работать как самостоятельно, так и быть импортированным в сторонний проект. При самостоятельной работе массивы могут быть заданы несколькими способами:
1. Перечислены как аргументы вызова через пробел или запятую, непосредственно, при запуске модуля в терминале
```
$ python -m main.py слова, слова, три
```
2. Если аргументов запуска не последует, будет предложено задать массив в консоли, так же, перечисляя строки через запятую.
```
Введите отдельные слова через пробел или запятую: слова, слова, три
```

3. Если из консоли будет возвращена пустая строка (нажат ENTER без ввода символов) - массив будет заполнен строками случайной длины из случайных символов

Если импортировать модуль в проект и работать с ним как с библиотекой, при вызове функции **select_string** и передаче ей готового массива NumPy со строками, появляется возможность устанавливать лимит на максимальную длину строки. Для этого используется аргумент *word_size*.

## Как работает алгоритм отбора

Функция принимает на вход массив со строками и перебирает его элементы. При получение каждого элемента происходит сравнение его длины с заданным лимитом. Если строка укладывадывается в лимит, то она записывается в результирующий массив, который потом и возвращается пользователю.

Бллок-схема рабочего алгоритма выглядит так:

![БлокСхема](./BlockScheme.jpg)