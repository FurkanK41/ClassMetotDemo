 class MusteriManager
{
    public  void Add(Musteri musteri)
    {
        System.Console.WriteLine(musteri.Id+ ". Müşteri eklendi.");
    }
    public  void Delete(Musteri musteri)
    {
        System.Console.WriteLine(musteri.Id+". Müşteri silindi.");
    }
    public  void Update(Musteri musteri)
    {
        System.Console.WriteLine(musteri.Id+ ". Müşteri güncellendi.");
    }
    public  void List(Musteri musteri)
    {
        System.Console.WriteLine(musteri.Id+". Müşteri listelendi.");
    }
}