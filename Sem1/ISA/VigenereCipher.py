def vigenere_encrypt(plaintext, keyword):
    encrypted_text = []
    keyword_repeated = (keyword * (len(plaintext) // len(keyword) + 1))[:len(plaintext)]
    
    for p_char, k_char in zip(plaintext, keyword_repeated):
        if p_char.isalpha():  # Only encrypt alphabetic characters
            shift = ord(k_char.lower()) - ord('a')
            if p_char.islower():
                encrypted_char = chr((ord(p_char) - ord('a') + shift) % 26 + ord('a'))
            else:
                encrypted_char = chr((ord(p_char) - ord('A') + shift) % 26 + ord('A'))
            encrypted_text.append(encrypted_char)
        else:
            encrypted_text.append(p_char)  # Non-alphabetic characters are unchanged

    return ''.join(encrypted_text)

def vigenere_decrypt(ciphertext, keyword):
    decrypted_text = []
    keyword_repeated = (keyword * (len(ciphertext) // len(keyword) + 1))[:len(ciphertext)]
    
    for c_char, k_char in zip(ciphertext, keyword_repeated):
        if c_char.isalpha():  # Only decrypt alphabetic characters
            shift = ord(k_char.lower()) - ord('a')
            if c_char.islower():
                decrypted_char = chr((ord(c_char) - ord('a') - shift) % 26 + ord('a'))
            else:
                decrypted_char = chr((ord(c_char) - ord('A') - shift) % 26 + ord('A'))
            decrypted_text.append(decrypted_char)
        else:
            decrypted_text.append(c_char)  # Non-alphabetic characters are unchanged

    return ''.join(decrypted_text)

# Example usage
if __name__ == "__main__":
    message = "Hello, World!"
    keyword = "KEY"
    print("Original word ::",message)
    encrypted = vigenere_encrypt(message, keyword)
    print("Encrypted:", encrypted)
    
    decrypted = vigenere_decrypt(encrypted, keyword)
    print("Decrypted:", decrypted)
