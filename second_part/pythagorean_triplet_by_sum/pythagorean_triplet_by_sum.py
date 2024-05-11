import math


def pythagorean_triplet_by_sum(sum: int) -> None:
    if is_input_type_int(str(sum)):
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
    else:
        print("Wrong input type. Change to int")


def is_input_type_int(received_input: str) -> bool:
    try:
        int(received_input)
    except ValueError:
        return False
    return True


pythagorean_triplet_by_sum(90)
