# **Итоговая проверочная работа для проверки знаний по первому блоку курса "Разработчик" oт GeekBrains**

## Задача : 

~~~bash
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 
~~~

## Для полноценного выполнения проверочной работы необходимо:

* 1 Создать репозиторий на GitHub
* 2 Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
* 3 Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
* 4 Написать программу, решающую поставленную задачу
* 5 Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)


## Общее описание алгоритма решения поставленной задачи:

* Заполнить строковый массив произвольной длинны случайными значениями с клавиатуры.
*  Создать метод который будет обращаться к каждой строке изначального массива с помощью цикла и проверять элементы этого массива на соответствие заданному условию(длинна строк меньше, либо равна 3 символам) ; в случае соответствия перебрасывать такие строки в новый массив "временного хранения") 
Поскольку длинна обоих массивов одинаковая - достаточно инициировать точку отсчёта для для массива "временного хранения" Мы говорим  что первый элемент удовлетворяющий условию имеет индекс 0 (resultPosition),  а все последующие элементы будем последовательно укладывать в следующие ячейки(resultPosition)++) В случае несоответствия условию в нашем массиве "временного хранения" появляются пустые ячейки и так пока не дойдём до конца изначального массива.
* Создать метод для вывода результата в консоль.
* Используем библиотеку Linq для помещения всех наших элементов удовлетворяющих условию в резултирующий строковый массив тем самым "отбрасывая пустые ячейки"
* Последовательно вызываем наши методы для получения итогового результата.

*Графическое представление решения задачи в виде блок-схемы в папке MyTask* [тык тут](MyDiagram/GetArrayAfterApplyingCondition.png)

*Реализация алгоритма на C# в папке MyDiagram*[тык тут](MyTask/Program.cs)