using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Wybory2020
{
    public class Kandydat
    {
        [PrimaryKey]
        public int Nr { get; set; }
        public string Imiona { get; set; }
        public string Nazwiska { get; set; }
        public string Profesja { get; set; }
        public string Miejsce_opracy { get; set; }
        public string Zamieszkanie { get; set; }
        public string Wysztalcenie { get; set; }
        public int Wiek { get; set; }
        public int Partia { get; set; }
        public int Wynik { get; set; }
    }
}
