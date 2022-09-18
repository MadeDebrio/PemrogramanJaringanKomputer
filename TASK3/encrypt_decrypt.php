<?php
  
// Input username
$username = readline('Username: ');
// Input password
$password = readline('Password: ');

// Store cipher method
$ciphering = "aes-128-cbc";
  
// Use OpenSSl encryption method to gets the cipher initialization vector (iv) length.
//return value is a length in bytes
$iv_length = openssl_cipher_iv_length($ciphering);
$options = 0;
  
// random_bytes() function gives randomly 16 digit values
$encryption_iv = random_bytes($iv_length);
  
//open ssl digest Computes a digest hash value for the given data using a given method, 
//and returns a raw or binhex encoded string.
// php uname returns information about the operating system PHP is running on
$encryption_key = openssl_digest(php_uname(), 'MD5', TRUE);
  
// Encryption of string process starts
$encryption = openssl_encrypt($password, $ciphering,
        $encryption_key, $options, $encryption_iv);
  
// Display the encrypted string
echo "username: " . $username. "\n";
echo "Encrypted String: " . $encryption . "\n";
  

// random_bytes() function gives randomly 16 digit values
$decryption_iv = random_bytes($iv_length);
  
// Store the decryption key
$decryption_key = openssl_digest(php_uname(), 'MD5', TRUE);
  
// Decryption of string process starts
$decryption = openssl_decrypt ($encryption, $ciphering,
            $decryption_key, $options, $encryption_iv);
  
// Display the decrypted password
echo "username: " . $username. "\n";
echo "Decrypted String: " . $decryption;
  
?>