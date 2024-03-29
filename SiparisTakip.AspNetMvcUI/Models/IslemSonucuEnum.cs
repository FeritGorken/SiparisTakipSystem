﻿using System.ComponentModel;
using static SiparisTakip.AspNetMvcUI.Models.IslemSonucuEnum;

namespace SiparisTakip.AspNetMvcUI.Models
{
    public class IslemSonucuEnum
    {
        public enum IslemSonucKodlari
        {
            [Description("BAŞARILI")]
            Basarili = 1,
            [Description("HATA")]
            Hata = 2,
            [Description("UYARI")]
            Uyari = 3,
            [Description("BİLGİLENDİRME")]
            Bilgilendirme = 4
        }

  
    }
    

    public static class ResultCodesExtensions
    {
        public static string ToDescriptionString(this IslemSonucKodlari val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}