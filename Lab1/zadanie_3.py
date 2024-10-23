def optymalizacja_proceduralna(tasks):
    tasks.sort(key=lambda x: (x['czas'], -x['nagroda']))

    calkowity_czas_oczekiwania = 0
    aktualny_czas = 0

    for task in tasks:
        aktualny_czas += task['czas']
        calkowity_czas_oczekiwania += aktualny_czas

    return tasks, calkowity_czas_oczekiwania

tasks = [
    {'czas': 3, 'nagroda': 5},
    {'czas': 1, 'nagroda': 10},
    {'czas': 2, 'nagroda': 7}
]

opt, total_wait_time = optymalizacja_proceduralna(tasks)
print("Optymalna kolejność zadań:", opt)
print("Całkowity czas oczekiwania:", total_wait_time)