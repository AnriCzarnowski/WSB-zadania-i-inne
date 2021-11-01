def dec_to_bin(x):
    b = 0
    i = 1
    while x != 0 :
        b = b + (x % 8) * i
        x = int(x / 8)
        i = i * 10
    
    return b + "b"

def dec_to_oct(x):
    o = 0
    i = 1
    while x != 0 :
        o = o + (x % 8) * i
        x = int(x / 8)
        i = i * 10;

    return o + "o"

def dec_to_hex(x):
     h = (x % 16)
     d = "0123456789ABCDEF"
     r = x / 16
     if (r == 0):
         return d[h]

     return dec_to_hex(r) + d[h] + "h"


def main():
    n = [0, 11, 16, 32, 33, 41, 45, 678, 574893]
    print(dec_to_bin(x) for x in n)
    print(dec_to_oct(x) for x in n)
    print(dec_to_hex(x) for x in n)

    if __name__=="__main__":
        main()
