import math


def reverse_n_pi_digits(number: int) -> str:
    revers_pi = str(math.pi)[0: number + 1]
    revers_pi = revers_pi.replace('.', '')
    return revers_pi[::-1]


print(reverse_n_pi_digits(7))
