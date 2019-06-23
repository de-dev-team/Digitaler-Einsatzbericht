using System;

namespace Digitaler_Einsatzbericht.Data
{
    public class FormA : IEntity
    {
        public int Id { get; set; }

        public DateTime Alarmierung { get; set; }

        /// <summary>
        /// We do not accept leading zeors.
        /// </summary>
        public int Einsatznummer { get; set; }

        public string EinsatzortStadtteil { get; set; }

        public string  EinsatzortStraße { get; set; }

        public string EinsatzortHausnummer { get; set; }
    }
}
