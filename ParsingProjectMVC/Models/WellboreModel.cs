﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParsingProjectMVC.Models
{
    public class WellboreModel
    {

        public int Id { get; set; }
        public string WellboreAdi { get; set; }

        public string Derinlik { get; set; }
        //[ForeignKey("KuyuId")]
        public int KuyuId { get; set; }
        public KuyuModel KuyuAdi { get; set; }
        public SahaModel SahaAdi { get; set; }
        public KuyuGrubuModel KuyuGrubuAdi { get; set; }
    }
}