using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Loss
    {
        public int KeyNo { get; set; }
        public string 晶片號碼 { get; set; }
        public string 寵物名 { get; set; }
        public string 寵物別 { get; set; }
        public string 性別 { get; set; }
        public string 品種 { get; set; }
        public string 毛色 { get; set; }
        public string 外觀 { get; set; }
        public string 特徵 { get; set; }
        public DateTime 遺失時間 { get; set; }
        public string 遺失地點 { get; set; }
        public string 飼主姓名 { get; set; }
        public string 連絡電話 { get; set; }
        public string Email { get; set; }
    }
}
