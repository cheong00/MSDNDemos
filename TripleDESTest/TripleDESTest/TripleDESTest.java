import java.io.IOException;
import java.io.UnsupportedEncodingException;

import java.security.MessageDigest;

import java.util.Arrays;
import java.util.Base64;

import javax.crypto.Cipher;
import javax.crypto.BadPaddingException;
import javax.crypto.IllegalBlockSizeException;
import javax.crypto.SecretKey;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.SecretKeySpec;

public class TripleDESTest {

    public static void main(String[] args) {
        String text = "This is a test.";
		String myKey = "5137153cc611227c000bbd1bd8cd200";//Development Env Key.

        String codedtext = encrypt(text, myKey);
        System.out.print("Encrypted string = ");
        System.out.println(codedtext);
        //Target: oHX1DB5B0rvn6mlr9T7pkg==

        String decodedtext  = decrypt(codedtext, myKey);
        System.out.print("Decrypted string = ");
        System.out.println(decodedtext);
    }

    public static String encrypt(String value, String decryptionKey) {
        try {
            final MessageDigest md = MessageDigest.getInstance("md5");
            final byte[] digestOfPassword = md.digest(decryptionKey.getBytes("utf-8"));
            final byte[] keyBytes = Arrays.copyOf(digestOfPassword, 24);

            final SecretKey key = new SecretKeySpec(keyBytes, "DESede");
            //final IvParameterSpec iv = new IvParameterSpec(new byte[8]);
            final Cipher cipher = Cipher.getInstance("DESede/ECB/PKCS5Padding");
            cipher.init(Cipher.ENCRYPT_MODE, key);

            final byte[] plainTextBytes = value.getBytes("utf-8");
            final byte[] cipherText = cipher.doFinal(plainTextBytes);
            final String encodedCipherText = Base64.getEncoder().encodeToString(cipherText);

            return encodedCipherText;    
        }
        catch (javax.crypto.NoSuchPaddingException e) { System.out.println("No Such Padding"); }
        catch (java.security.NoSuchAlgorithmException e) { System.out.println("No Such Algorithm"); }
        catch (java.security.InvalidKeyException e) { System.out.println("Invalid Key"); }
        catch (BadPaddingException e) { System.out.println("Invalid Key");}
        catch (IllegalBlockSizeException e) { System.out.println("Invalid Key");}
        catch (UnsupportedEncodingException e) { System.out.println("Invalid Key");}
		catch (Exception e) {
            e.printStackTrace();
        }
        return null;
    }

    public static String decrypt(String value, String decryptionKey) {
        try
        {
            final MessageDigest md = MessageDigest.getInstance("md5");
            final byte[] digestOfPassword = md.digest(decryptionKey.getBytes("utf-8"));
            final byte[] keyBytes = Arrays.copyOf(digestOfPassword, 24);

            final SecretKey key = new SecretKeySpec(keyBytes, "DESede");
            //final IvParameterSpec iv = new IvParameterSpec(new byte[8]);
            final Cipher decipher = Cipher.getInstance("DESede/ECB/PKCS5Padding");
            decipher.init(Cipher.DECRYPT_MODE, key);

            final byte[] encData = Base64.getDecoder().decode(value);
            final byte[] plainText = decipher.doFinal(encData);

            return new String(plainText, "UTF-8");            
        }
        catch (javax.crypto.NoSuchPaddingException e) { System.out.println("No Such Padding"); }
        catch (java.security.NoSuchAlgorithmException e) { System.out.println("No Such Algorithm"); }
        catch (java.security.InvalidKeyException e) { System.out.println("Invalid Key"); }
        catch (BadPaddingException e) { System.out.println("Invalid Key");}
        catch (IllegalBlockSizeException e) { System.out.println("Invalid Key");}
        catch (UnsupportedEncodingException e) { System.out.println("Invalid Key");}     
		catch (Exception e) {
            e.printStackTrace();
        }

        return null;
    }
	
}