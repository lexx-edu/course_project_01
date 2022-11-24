import re
import numpy as np


def random_strings_array():
    words_qty = np.random.randint(2, 10)
    words_array = []

    for i in range(words_qty):
        words_array.append(random_word())

    return words_array


def random_word():
    chars_qty = np.random.randint(1, 5)
    string = ''

    for i in range(chars_qty):
        symbol = np.random.randint(65, 91)
        string += chr(symbol)

    return string


def clean_arguments(lst):
    return lst[1:]


def request_console():
    string = input("Введите отдельные слова через пробел или запятую: ")
    if not string:
        string = random_strings_array()
    else:
        string = string.replace(',', ' ')
        string = re.split('\s{1,6}', string)
    return string
