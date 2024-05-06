import matplotlib.pyplot as plt
import math


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
    numbers_copy = []
    for number in numbers:
        numbers_copy.append(number)
    numbers_copy.sort()
    for number in numbers_copy:
        print(number)


def show_numbers_diagram(numbers: list[float]) -> None:
    number_count = []
    number_placement = 1
    for number in numbers:
        number_count.append(number_placement)
        number_placement = number_placement + 1

    plt.scatter(number_count, numbers)
    plt.ylabel("The numbers: ")
    plt.xlabel("The order: ")
    plt.show()


def calculate_pearson(numbers: list[float]) -> float:
    number_of_numbers = len(numbers)
    number_of_numbers_sum = 0
    numbers_sum = 0
    number_placement = 1
    for number in numbers:
        number_of_numbers_sum = number_of_numbers_sum + number_placement
        numbers_sum = numbers_sum + number
        number_placement = number_placement + 1
    average_number_placement = number_of_numbers_sum / number_of_numbers
    average_number = numbers_sum / number_of_numbers

    number_placement = 1
    placement_number_delta_sum = 0
    placement_delta_times_itself_sum = 0
    number_delta_times_itself_sum = 0
    for number in numbers:
        placement_minus_average_placement = number_placement - average_number_placement
        number_minus_average_number = number - average_number
        placement_delta_times_number_delta = placement_minus_average_placement * number_minus_average_number
        placement_number_delta_sum = placement_number_delta_sum + placement_delta_times_number_delta
        placement_delta_times_itself_sum = (placement_delta_times_itself_sum + placement_minus_average_placement
                                            * placement_minus_average_placement)
        number_delta_times_itself_sum = (number_delta_times_itself_sum + number_minus_average_number
                                         * number_minus_average_number)
        number_placement = number_placement + 1
    pearson = placement_number_delta_sum / math.sqrt(placement_delta_times_itself_sum * number_delta_times_itself_sum)
    return pearson


def numbers_qualities() -> None:
    numbers = get_numbers()
    print("\n The average is: ", numbers_average(numbers))
    print("\n The number of positive numbers is: ", positive_numbers_count(numbers))
    print_sorted_numbers(numbers)
    show_numbers_diagram(numbers)
    print("\n The pearson correlation coefficient: ", calculate_pearson(numbers))


numbers_qualities()
