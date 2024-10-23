def plecak_proceduralny(waga_max, przedmioty):
    n = len(przedmioty)
    dp = [[0 for _ in range(waga_max + 1)] for _ in range(n + 1)]

    for i in range(1, n + 1):
        for w in range(waga_max + 1):
            if przedmioty[i - 1]['waga'] <= w:
                dp[i][w] = max(dp[i - 1][w], dp[i - 1][w - przedmioty[i - 1]['waga']] + przedmioty[i - 1]['wartosc'])
            else:
                dp[i][w] = dp[i - 1][w]

    wynik = []
    w = waga_max
    for i in range(n, 0, -1):
        if dp[i][w] != dp[i - 1][w]:
            wynik.append(przedmioty[i - 1])
            w -= przedmioty[i - 1]['waga']

    return dp[n][waga_max], wynik


przedmioty = [
    {'waga': 2, 'wartosc': 3},
    {'waga': 3, 'wartosc': 4},
    {'waga': 4, 'wartosc': 5},
    {'waga': 5, 'wartosc': 8}
]
waga_max = 8

max_value, items = plecak_proceduralny(waga_max, przedmioty)
print("Maksymalna wartość:", max_value)
print("Wybrane przedmioty:", items)
