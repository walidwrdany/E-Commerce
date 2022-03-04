﻿using eCommerce.Common.Models;

namespace eCommerce.Entities.Localization
{
    public class Language : Auditable
    {
        public string Name { get; set; }
        public string LanguageCulture { get; set; }
        public string UniqueSeoCode { get; set; }
        public string FlagImageFileName { get; set; }
        public bool Rtl { get; set; }
        public int DisplayOrder { get; set; }
    }
}