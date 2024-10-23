import re

tekst = """
Wikipedia – wielojęzyczna encyklopedia internetowa działająca zgodnie z zasadą otwartej treści.
Wykorzystuje oprogramowanie MediaWiki (haw. wiki – „szybko”, „prędko”), wywodzące się z koncepcji WikiWikiWeb,
umożliwiające edycję każdemu użytkownikowi odwiedzającemu stronę i aktualizację jej treści w czasie rzeczywistym.
"""

countWords = len(tekst.split())
print("Liczba słów:", countWords)


def zadanie1(tekst):

    paragraf = len(list(filter(lambda x: x == "\n", tekst)))


    paragraf1 = [p for p in tekst.strip().split('\n') if p]
    iloscParagrafow = len(paragraf1)


    zdanie1 = len(list(filter(lambda x: x == "." or x == "?" or x == "!", tekst)))


    zdanie2 = re.split(r'[.!?]+', tekst)
    zdanie2 = [t.strip() for t in zdanie2 if t.strip()]
    ilosczdanie2 = len(zdanie2)

    return paragraf, iloscParagrafow, zdanie1, ilosczdanie2

p1, p2, zdanie1, ilosczdanie2 = zadanie1(tekst)


print("Liczba znaków kończących paragrafy:", p1)
print("Liczba paragrafów:", p2)
print("Liczba zdań na podstawie znaków kończących zdania:", zdanie1)
print("Liczba zdań (alternatywnie):", ilosczdanie2)
