using Void;

Kisiler ks = new Kisiler();
string adsoyad,meslek;
int yas;
Console.WriteLine("Ad-Soyad Girin:");
adsoyad=Console.ReadLine();
Console.WriteLine("Yaş Girin:");
yas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Meslek Girin:");
meslek = Console.ReadLine();
ks.kisilerListesi(adsoyad,yas,meslek);
Console.Read();