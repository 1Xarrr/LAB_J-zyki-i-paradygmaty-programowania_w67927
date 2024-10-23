def harmonogram_proceduralny(tasks):
    tasks.sort(key=lambda x: x['koniec'])  # Sortowanie po czasie zakończenia
    harmonogram = []
    aktualny_czas = 0
    nagroda_sum = 0

    for task in tasks:
        if task['start'] >= aktualny_czas:
            harmonogram.append(task)
            aktualny_czas = task['koniec']
            nagroda_sum += task['nagroda']

    return nagroda_sum, harmonogram

tasks = [
    {'start': 1, 'koniec': 3, 'nagroda': 5},
    {'start': 2, 'koniec': 5, 'nagroda': 6},
    {'start': 4, 'koniec': 6, 'nagroda': 5},
    {'start': 6, 'koniec': 7, 'nagroda': 4}
]

nagroda, harmonogram = harmonogram_proceduralny(tasks)
print("Maksymalna nagroda:", nagroda)
print("Wybrane zadania:", harmonogram)