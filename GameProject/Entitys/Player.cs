using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entitys
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name_Ad { get; set; }
        public string SurName_Soyad { get; set; }
        public string IdentityNumber_TcNo { get; set; }
        public DateTime DateOfBirth_DogumTarihi { get; set; }
    }
}
