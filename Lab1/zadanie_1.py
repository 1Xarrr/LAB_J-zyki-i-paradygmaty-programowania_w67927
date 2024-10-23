def podzielPaczki(wagi, max_wagi):
    for waga in wagi:
        if waga> max_wagi:
            raise ValueError(f"Paczka o wadze {waga} przekraca max doz wage kursu{max_wagi} kg.")
    wagi_sorted = sorted(wagi, reverse=True)
    kursy = []

    for waga in wagi_sorted:
        dodano = False
        for kurs in kursy:
            if sum(kurs) + waga <= max_wagi:
                kurs.append(waga)
                dodano = True
                break

        if not dodano:
            kursy.append([waga])

    return len(kursy), kursy

wagi = [5, 2,2, 7,5,5]
max_wagi = 15;

# print(podzielPaczki(wagi, max_wagi))

liczba_kursow, kursy = podzielPaczki(wagi, max_wagi)
for i, kurs in enumerate (kursy, 1):
    print(f"kirs{i} : {kurs} \t - suma wagi : {sum(kurs)} kg")
