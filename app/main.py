import numpy as np
from sys import argv
from module import *


def select_strings(raw_array: np.array, word_size=3):
    new_array = np.empty(shape=0, dtype='object')
    for i in raw_array:
        if len(i) <= word_size:
            new_array = union_arr(new_array, i)
    return new_array


def union_arr(array, value):
    new_array = np.concatenate((array, np.array([value, ])))
    return new_array


if __name__ == '__main__':
    args = clean_arguments(argv)

    if not args:
        args = request_console()

    strings = select_strings(np.array(args))
    pass

