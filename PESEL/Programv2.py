def check(pesel):
    dlugosc = len(pesel)
    if (dlugosc != 11):
        print("N")
    
    suma = 0
    mnoznik = [1,3,7,9,1,3,7,9,1,3,1]
    for i in range(dlugosc):
        tmp = int(pesel[i]) * mnoznik[i]
        suma = suma + tmp
    if suma % 10 == 0:
        print("D")
    else:
        print("N")

if __name__=="__main__":
    # wczytaj pierwszą linie (liczbe peseli)
    n = input()
    m = int(n)
    # powtorz m razy
    for i  in range(0,m):
        # wczytaj pesel
        pesel = input()
        # sprawdz pesel
        check(pesel)

