import string

chars = string.ascii_uppercase + string.ascii_lowercase

def encrypt(text, key):

    textCharAtPos = [chars.find(i) for i in text]
    keyCharAtPos = [chars.find(i) for i in key]

    keyLength = len(key)
    textLength = len(text)

    cipher = ""

    for n in range(textLength):
        letter = (textCharAtPos[n] + keyCharAtPos[n % keyLength]) % len(chars)
        cipher += chars[letter]

    return cipher


def decrypt(cipher, key):
    
    cipherCharAtPos = [chars.find(i) for i in cipher]
    keyCharAtPos = [chars.find(i) for i in key]

    keyLength = len(key)
    cipherLength = len(cipher)

    plainText = ""

    for n in range(cipherLength):
        letter = (cipherCharAtPos[n] - keyCharAtPos[n % keyLength]) % len(chars)
        plainText += chars[letter]

    return plainText


if __name__ == "__main__":
    
    text = input('Text: ')
    key = input('Key: ')

    cipher = encrypt(text, key)
    plainText = decrypt(cipher, key)

    print('=======================')
    print('Text: ', text)
    print('Key: ', key)
    print('Cipher: ', cipher)
    print('Plain Text: ', plainText)