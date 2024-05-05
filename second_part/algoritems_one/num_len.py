import math


def num_len(number: int) -> int:
    return round(math.log(number, 10))


print(num_len(8198))
