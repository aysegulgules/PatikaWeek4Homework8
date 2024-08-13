using PatikaWeek4Homework8.Abstract;


namespace PatikaWeek4Homework8.Concrete
{
    internal class Computer: BaseMachine //BaseMachine den Inheritance yapılıyor
    {
        private int _numberUSBPorts;//Encapsulation işlemi için Field alan tanımlandı.
        public int NumberUSBPorts  {
            get
            {
                return _numberUSBPorts;
            }

            set
            { 
                if(value==2 || value==3) //Encapsulation 
                { 
                    _numberUSBPorts = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz USB giriş sayısı. Usb girişi 2 veya 4 olmalıdır. -1 olarak atanıyor.");

                    _numberUSBPorts = -1;
                }

            } 
        }
        public bool Bluetooth { get; set; }

        public override void MachineInfo() //Polymorphism
        {
            
            base.MachineInfo();
            Console.WriteLine(" USB Giriş Sayısı..:" + _numberUSBPorts + "\n Bluetooth durumu..:" + Bluetooth );
        }
        public override void GetProductName()
        {
            Console.WriteLine($" Bilgisayarınızın adı ---> {Name}");
        }
    }
}
