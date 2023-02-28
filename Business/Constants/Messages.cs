using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constant
{
    public static class Messages
    {
        //Rental
        public static string RentIsSucceed = "Araç kiralama başarıyla gerçekleşti";
        public static string TheCarCanNotBeRented = "Araç teslim edilmemiş,kiralama için uygun değil";


        //CarImage
        public static string AddedNewImage = "Yeni resim eklendi";
        public static string ImageLimitExceded = "Bir araca en fazla 5 resim eklenebilir";
        public static string DeletedImage = "Resim başarıyla silindi";
        public static string CarImageUpdated = "Araba başarıyla güncellendi";
        public static string ThereIsNoImageOfThisCar = "Bu arabaya ait resim bulunmamakta";

        //Auth
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullancı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}