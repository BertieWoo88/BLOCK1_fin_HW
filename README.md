# BLOCK1_fin_HW
# Описание решения задачи

Основной метод ArrStrLenLess4 выполнен следующим образом:
* Cоздаем пустую строку resString в которой будет собираться данные для итогового массива
* Через цикл for перебираем все элементы исходного массива
* Внутри цикла проверяем если длина элемента меньше или равна 3 то добавляем его в resString с разделителем пробел
* По завершению цикла создаем итоговый массив result и заполняем его через разбивку строки resString  встроенным методом Split.
