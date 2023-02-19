Musteri musteri1 = new Musteri();
musteri1.Id = 1;
musteri1.Name = "Furkan Karagöz";
musteri1.Age = 18;
musteri1.CreditPoint= 10;


MusteriManager musteriManager1 = new MusteriManager();
System.Console.WriteLine("1.Müşteri İşlemleri:");
musteriManager1.Add(musteri1);
musteriManager1.Delete(musteri1);
musteriManager1.List(musteri1);
musteriManager1.Update(musteri1);

System.Console.WriteLine();


Musteri musteri2 = new Musteri();
musteri2.Id = 2;
musteri2.Name = "Murat Ak";
musteri2.Age = 52;
musteri2.CreditPoint= 5;

MusteriManager musteriManager2 = new MusteriManager();
System.Console.WriteLine("2.Müşteri İşlemleri:");
musteriManager2.Add(musteri2);
musteriManager2.Delete(musteri2);
musteriManager2.List(musteri2);
musteriManager2.Update(musteri2);
System.Console.WriteLine();

Musteri musteri3 = new Musteri();
musteri3.Id = 3;
musteri3.Name = "Esma Akkaya";
musteri3.Age = 28;
musteri3.CreditPoint= 3;

MusteriManager musteriManager3 = new MusteriManager();
System.Console.WriteLine("3.Müşteri İşlemleri:");
musteriManager1.Add(musteri3);
musteriManager1.Delete(musteri3);
musteriManager1.List(musteri3);
musteriManager1.Update(musteri3);
System.Console.WriteLine();

Musteri musteri4 = new Musteri();
musteri4.Id = 4;
musteri4.Name = "Kevser Gün";
musteri4.Age = 36;
musteri4.CreditPoint= 8;

MusteriManager musteriManager4 = new MusteriManager();
System.Console.WriteLine("4.Müşteri İşlemleri:");
musteriManager4.Add(musteri4);
musteriManager4.Delete(musteri4);
musteriManager4.List(musteri4);
musteriManager4.Update(musteri4);
System.Console.WriteLine();


Musteri[] musteriler = new Musteri[]{musteri1,musteri2,musteri3,musteri4};

for (int i = 0; i < musteriler.Length; i++)
{
    System.Console.WriteLine(musteriler[i].Id); 
    System.Console.WriteLine(musteriler[i].Name); 
    System.Console.WriteLine(musteriler[i].Age); 
    System.Console.WriteLine(musteriler[i].CreditPoint); 
    System.Console.WriteLine();

}