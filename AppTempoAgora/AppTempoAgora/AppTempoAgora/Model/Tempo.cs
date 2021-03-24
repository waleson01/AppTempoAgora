using System;
using System.Collections.Generic;
using System.Text;

namespace AppTempoAgora.Model
{
    class Tempo
    {
        public string Title { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Humidity { get; set; }
        public string Visibility { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }

        public Tempo()
        {
            this.Title = " Exemplo Wale aqui";
            this.Temperature = " ";
            this.Wind = " ";
            this.Visibility = " ";
            this.Sunrise = " ";
            this.Sunset = " ";
        }

    }
}
