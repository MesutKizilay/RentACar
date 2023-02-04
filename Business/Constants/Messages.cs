using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constant
{
    public static class Messages
    {
        //Rental
        public static string RentIsSucceed = "Araç kiralama başarıyla gerçekleşti";
        public static string TheCarCanNotBeRented="Araç teslim edilmemiş,kiralama için uygun değil";
        
        
        //CarImage
        public static string AddedNewImage="Yeni resim eklendi";
        public static string ImageLimitExceded="Bir araca en fazla 5 resim eklenebilir";
        public static string DeletedImage="Resim başarıyla silindi";
        public static string CarImageUpdated="Araba başarıyla güncellendi";
        internal static string ThereIsNoImageOfThisCar="Bu arabaya ait resim bulunmamakta";
    }
}