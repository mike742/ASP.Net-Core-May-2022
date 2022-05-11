using System;

namespace ASP.Net_Core_May_2022.Models
{
    public class Product
    {
        public string P_code { get; set; }
        public string P_descript { get; set; }
        public DateTime P_InDate { get; set; }
        public int P_QOH { get; set; }
        public int P_Min { get; set; }
        public double P_Price { get; set; }
        public double P_Discount { get; set; }
        public int? V_code { get; set; }
    }
}
