using PatikaWeek4Homework8.Abstract;
using PatikaWeek4Homework8.Concrete;
using static System.Net.Mime.MediaTypeNames;

while (true)
 {
               Console.Write("\n Telefon üretmek için 1 \n Bilgisayar üretmek için 2'ye basınız:"); //Ürün seçimi
    machineGo:if(int.TryParse(Console.ReadLine(), out int machineChoose) && (machineChoose == 1 || machineChoose == 2))
             {
                Machines(machineChoose);               
             }
             else
             {
                Console.WriteLine("Geçersiz seçim. Lütfen 1 veya 2 seçiniz.");
                goto machineGo;

             }

productGo:  Console.WriteLine("\nBaşka bir ürün üretmek ister misiniz? (EVET/HAYIR)");
            string producingProducts = (Console.ReadLine()).ToUpper();

            if (producingProducts == "HAYIR")
            {
                Console.WriteLine("\n İyi günler dileriz.");
                break;
            }
            else if (producingProducts != "EVET")
            {
                Console.WriteLine("Geçersiz giriş.");
                goto productGo;
            }

 }

void Machines(int machineChoose)
{

    //Telefon nesnesi oluşturuluyor
    if (machineChoose == 1)
    {
        Console.WriteLine("-----Telefon-----");

        Phone phone = new Phone();
        Console.Write("Seri Numarası..: ");
        phone.SerialNumber = Console.ReadLine();
        Console.Write("Ad..: ");
        phone.Name = Console.ReadLine();
        Console.Write("Açıklama..: ");
        phone.Description = Console.ReadLine();
        Console.Write("İşletim Sistemi..: ");
        phone.OperatingSystem = Console.ReadLine();
        Console.Write("TR Lisanslı (true/false)..: ");
        phone.TrLicense = ControlBool(Console.ReadLine());

        phone.MachineInfo();
        phone.GetProductName();
    }
    else //Bilgisayar nesnesi oluştururluyor.
    {
        Console.WriteLine("-----Bilgisayar-----");

        Computer computer = new Computer();
        Console.Write("Seri Numarası..: ");
        computer.SerialNumber = Console.ReadLine();
        Console.Write("Ad..: ");
        computer.Name = Console.ReadLine();
        Console.Write("Açıklama..: ");
        computer.Description = Console.ReadLine();
        Console.Write("İşletim Sistemi..: ");
        computer.OperatingSystem = Console.ReadLine();
        Console.Write("USB Giriş Sayısı..: ");
        computer.NumberUSBPorts = ControlInt(Console.ReadLine());
        Console.Write("Bluetooth (true/false)..: ");
        computer.Bluetooth = ControlBool(Console.ReadLine());

        computer.MachineInfo();
        computer.GetProductName();

    }
}

    //Boolean kontrolü

     Boolean ControlBool(string text)
    {
        while(true)
        { 
            if(Boolean.TryParse(text, out Boolean result)) 
            { 
                 if (result)
                    {
                        return true;
                    }
                 else 
                    { 
                        return false; 
                    }
                
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen true veya false yazınız.");
                text= Console.ReadLine();
            }
        }
   
       
    }

    //integer değer kontrolü

    int ControlInt(string text)
    {
        while (true) 
        {
            if(int.TryParse(text, out int number) )
            {
                return number;
                
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen sayı giriniz");
                text= Console.ReadLine();
            }
        
        }

    }
