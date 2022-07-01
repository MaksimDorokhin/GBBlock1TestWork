# Контрольная работа по результатам 1-го блока обучения в GeekBrains по программе "Разработчик"
## Содержание репозитория:

В данном репозитории содержатся все файлы контрольной работы.

* **Папка ArrayOf0to3Chars** содержит код программы на языке C#.
* **BD_###.drawio** - файлы DRAW IO с редактируемыми блок-схемами для каждого метода проекта.
* **BD_###.PNG** - готовые блок-схемы в PNG-формате основной программы и всех созданных методов.
* **README.md** - текстовый файлс описанием проекта.
* **Task (October 2021).md** - текстовый файл с описанием задания.

### Описание методов программы:

```sh 
bool StringCanBeParsedToInt(string text)
```
Метод для проверки, может ли строка, введенная с клавиатуры пользователем, быть преобразована в переменную длины массива типа integer. Используется для исключения крашей программы при некорректном вводе длины массива с клавиатуры.
 ```sh 
string[] InputStringArray(int length)
```
Метод для ввода с клавиатуры элементов массива строк произвольной длины.
 ```sh 
string[] ArrayWith0to3Chars(string[] initialArray)
```
Метод для формирования нового массива, который будет содержать только те элементы указанного начального массива, длина которых меньше либо равна 3 символа. 
 ```sh 
string PrintStringArray(string[] array)
```
Метод для записи в строку с форматированием всех элементов указанного массива строк. Форматирование используется для того, чтобы при печати в консоль различать элементы с пробелами или отсутствие элементов.