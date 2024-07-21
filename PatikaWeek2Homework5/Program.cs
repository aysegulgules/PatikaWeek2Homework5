//bir şarkı sözü yazdırılıyor...
void MethodMusic()
{
    Console.WriteLine("Şarkı sözü...: Kupkuru bir ağacın dalıyım yapayalnız.");
}

//Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı hesaplama
int MethodNumber()
{
    Random numberRandom = new Random();
    int number = numberRandom.Next();
    Console.Write($"Random seçilen {number} sayısının 2 ile bölümünden kalan...:");
    return number %2;
}

//iki sayının çarpımını
int MethodMultiplication(int number1, int number2)
{
    
    return number1 * number2;
}

// İsim soyisim ekrana yazdırılıyor.
void MethodName(string firstName,string lastName)
{
    Console.Write($"Hoş Geldiniz {firstName} {lastName}\n");
}

MethodMusic();

Console.WriteLine(MethodNumber());

Console.WriteLine($"9 ve 6 sayılarının çarpımı...: {MethodMultiplication(9, 6)}");

MethodName("Beyza", "Yıldırım");