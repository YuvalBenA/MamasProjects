import math


def is_sorted_polyndrom(polyndrom: str) -> bool:
    polyndrom_length = len(polyndrom)
    if check_if_polyndrom(polyndrom, polyndrom_length):
        return check_polyndrom_order(polyndrom, math.ceil(polyndrom_length / 2))
    print("This is not a polyndrom.")
    return False


def check_if_polyndrom(polyndrom: str, polyndrom_length: int) -> bool:
    char_placement = 0
    while char_placement <= math.ceil(polyndrom_length / 2):
        if polyndrom[char_placement] != polyndrom[polyndrom_length - 1]:
            return False
        char_placement = char_placement + 1
        polyndrom_length = polyndrom_length - 1
    return True


def check_polyndrom_order(polyndrom: str, half_polyndrom_length: int) -> bool:
    char_placement = 0
    while char_placement < half_polyndrom_length-1:
        if polyndrom[char_placement] > polyndrom[char_placement + 1]:
            return False
        char_placement = char_placement + 1
    return True


print(is_sorted_polyndrom("abcdcba"))
