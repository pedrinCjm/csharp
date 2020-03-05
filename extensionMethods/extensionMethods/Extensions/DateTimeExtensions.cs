using System.Globalization;

namespace System
{
    static class DateTimeExtensions
    {
        public static string tempoDecorrido(this DateTime dateObj, DateTime data)
        {
            TimeSpan tempo = DateTime.Now.Subtract(dateObj);

            if(tempo.TotalHours <= 24.0)
            {
                return tempo.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " horas se passaram.";
            }
            else
            {
                return tempo.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " dias se passaram.";
            }
        }
    }
}
