def get_numbers() -> list[float]:
    num = float(input("Enter the first number: "))
    numbers = []
    while num != -1:
        numbers.append(num)
        num = float(input("Enter the next number. If you are done enter -1: "))
    return numbers


def numbers_average(numbers: list[float]) -> float:
    numbers_sum = 0
    for number in numbers:
        numbers_sum = numbers_sum + number
    return numbers_sum / len(numbers)


def positive_numbers_count(numbers: list[float]) -> int:
    count_positive_numbers = 0
    for number in numbers:
        if number >= 0:
            count_positive_numbers = count_positive_numbers + 1
    return count_positive_numbers


def print_sorted_numbers(numbers: list[float]) -> None:
    print("\n The numbers by going up order: ")
    numbers.sort()
    for number in numbers:
        print(number)


def numbers_qualities() -> None:
    numbers = get_numbers()
    print("\n The average is: ", numbers_average(numbers))
    print("\n The number of positive numbers is: ", positive_numbers_count(numbers))
    print_sorted_numbers(numbers)


numbers_qualities()
