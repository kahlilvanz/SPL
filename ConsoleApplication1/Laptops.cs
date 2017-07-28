using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Laptops
    {
        private string lenovobrand = "Lenovo";
        private string lenovoprice = "$1300";
        private string lenovoprocessor = "i3";
        private string lenovoram = "4GB";
        private string lenovohdd = "1TB";

        private string dellbrand = "Dell";
        private string dellprice = "$1400";
        private string dellprocessor = "i5";
        private string dellram = "8GB";
        private string dellhdd = "500GB";

        private string sonybrand = "Sony";
        private string sonyprice = "$1600";
        private string sonyprocessor = "i7";
        private string sonyram = "8GB";
        private string sonyhdd = "1TB";


        //Property
        public string lenovospces
        {
            get {
                return "Name: " + lenovobrand + "\n"
                    + "Price: " + lenovoprice + "\n"
                    + "Processor: " + lenovoprocessor + "\n"
                    + "RAM: " + lenovoram + "\n"
                    + "HDD: " + lenovohdd + "\n"
                    ;
            }
        }

        public string dellspecs
        {
            get
            {
                return "Name: " + dellbrand + "\n"
                    + "Price: " + dellprice + "\n"
                    + "Processor: " + dellprocessor + "\n"
                    + "RAM: " + dellram + "\n"
                    + "HDD: " + dellhdd + "\n"
                    ;
            }
        }

        public string sonyspecs
        {
            get
            {
                return "Name: " + sonybrand + "\n"
                    + "Price: " + sonyprice + "\n"
                    + "Processor: " + sonyprocessor + "\n"
                    + "RAM: " + sonyram + "\n"
                    + "HDD: " + sonyhdd + "\n"
                    ;
            }
        }

    }

    class LaptopModels : Laptops
    {
        // Constructor
        public LaptopModels() 
            : base()
        {

        }

        // Method
        public string getLaptops()
        {
            return "****************" + "\n" 
                 + this.lenovospces
                 + "****************" + "\n"
                 + this.dellspecs
                 + "****************" + "\n"
                  + this.sonyspecs
                 + "****************" + "\n"
                 ;
        }

    }

}
