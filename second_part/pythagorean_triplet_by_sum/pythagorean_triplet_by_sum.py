import math


def pythagorean_triplet_by_sum(sum: int) -> None:
    a = 3
    b = 4
    c = 5
    while a + b + c <= sum:
        while (2 * b + a) < sum:
            c = math.sqrt(a * a + b * b)
            if a + b + c == sum and a < b < c:
                print(a, "<", b, "<", int(c))
            b = b + 1
        a = a + 1
        b = 8
        c = 10


pythagorean_triplet_by_sum(600)
