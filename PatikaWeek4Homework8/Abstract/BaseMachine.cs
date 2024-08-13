using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4Homework8.Abstract
{
    abstract class BaseMachine
    {
        //Property'ler tanımlanıyor
        public DateTime ProductionDate { get;  }//Kullanıcıdan değer alınmadığı için "set"  yok
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string OperatingSystem { get; set; }

        public BaseMachine()
        {
            ProductionDate = DateTime.Now;
        }

        public virtual void MachineInfo()
        {
            Console.WriteLine("\nÜrün başarı ile üretildi. Üretilen ürün bilgileri..: ");
            Console.WriteLine($"\n Üretim Tarihi..:{ProductionDate.ToShortDateString()} \n Seri numarası..:{SerialNumber} " +
                $"\n Adı...:{Name} \n Açıklama..:{Description} \n İşletim Sistemi..:{OperatingSystem}");
        }
        public abstract void GetProductName();
       
    }
}
