using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{
   public class BitData
    {
       private UInt32 _bd;
       public UInt32 Data { get { return _bd; } }

        //public byte pracstats { get; set; }
        public byte coderversion { get; set; }
        public byte treater_spec_interest { get; set; }
        public byte referer_spec_interest { get; set; }
        public byte treater_qualif { get; set; }
        public byte referer_qualif { get; set; }
        public byte treater_work_condit { get; set; }
        public byte referer_work_condit { get; set; }
        public byte race { get; set; }
        public byte age { get; set; }
        public byte gender { get; set; }
        public byte visittype{ get; set; }
        public byte facilitytype { get; set; }

public BitData()
        {
            _bd = 0;
            FillProperties(_bd);   
        }
        public BitData(UInt32 _bd)
        {
            FillProperties(_bd);   
        }

        public BitData(string bdstr) 
        {
            FillProperties(Convert.ToUInt32(bdstr));
        }

       private void FillProperties(UInt32 _bd)
       {
        //pracstats = (byte)((_bd >> 30) & (UInt32)0x03); //remove
            coderversion =          (byte)((_bd >> 30) & (UInt32)0x03); //2bits
            treater_spec_interest = (byte)((_bd >> 25) & (UInt32)0x1F); //5bits                                                               //5 bit special interest
            referer_spec_interest = (byte)((_bd >> 20) & (UInt32)0x1F); //5bits
            treater_qualif =        (byte)((_bd >> 17) & (UInt32)0x07);//3 bit qualificatopns
            referer_qualif =        (byte)((_bd >> 14) & (UInt32)0x07);//3 bits
            treater_work_condit =   (byte)((_bd >> 11) & (UInt32)0x07);//3bits  //3 bit work conditions
            referer_work_condit =   (byte)((_bd >> 8) & (UInt32)0x07); //3bits
            age =                   (byte)((_bd >> 5) & (UInt32)0x07); //3bits   
            race =                  (byte)((_bd >> 3) & (UInt32)0x03);//2bits           
            gender =                (byte)((_bd >> 2)& (UInt32)0x01);//1bit      
            visittype =             (byte)((_bd >> 1) & (UInt32)0x01); //1 bit inpatient outpatient 
            facilitytype  =         (byte)(_bd & (UInt32)0x01);         //1 bit private public //total 32bits             
       }

     
       public override string ToString()
      {
          UInt32 x =
         ((uint)(facilitytype & 0x01) |
         ((uint)(visittype & 0x01) << 1) |
         ((uint)(gender & 0x01) << 2) |
         ((uint)(race & 0x03) << 3) |
         ((uint)(age & 0x07) << 5) |
         ((uint)(referer_work_condit & 0x07) << 8) |
         ((uint)(treater_work_condit & 0x07) << 11) |
         ((uint)(referer_qualif & 0x07) << 14) |
         ((uint)(treater_qualif & 0x07) << 17) |
         ((uint)(referer_spec_interest & 0x1F) << 20) |
         ((uint)(treater_spec_interest & 0x1F) << 25) |
         ((uint)(coderversion & 0x03) << 30));
          return x.ToString("X8");        
       }
    }
}
