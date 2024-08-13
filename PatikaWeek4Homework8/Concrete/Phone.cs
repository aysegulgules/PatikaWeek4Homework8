using PatikaWeek4Homework8.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4Homework8.Concrete
{
    internal class Phone:BaseMachine //BaseMachine den Inheritance yapılıyor
    {
        public bool TrLicense { get; set; }

        public override void MachineInfo()//Polymorphism
        {
            base.MachineInfo();
            Console.WriteLine(" TR lisansı durumu ..:" + TrLicense) ;
        }

        public override void GetProductName()
        {
            Console.WriteLine($"\n Telefonunuzun adı ---> {Name}");
        }
    }
}
