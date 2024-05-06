from mpmath import mp


def reverse_n_pi_digits(number: int) -> str:
    mp.dps = 1000
    revers_pi = str(mp.pi)[0:number+1].replace(".","")
    return revers_pi[::-1]


print(reverse_n_pi_digits(999))



