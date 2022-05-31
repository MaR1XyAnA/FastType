using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Keybord_Trening.AppData
{   /// <summary>
    /// Предстовляет статические свойства и методы для расчёта скорости и точности
    /// </summary>

    public class TypeQuality
    {
        public static decimal Speed { get; set; } //Возвращает или задаёт скорость печати
        
        
        /// <summary>
        /// Расчитывает скорость печати
        /// </summary>
        /// <param name="input">Длина исходного текста</param>
        /// <param name="temp">Темп печати</param>
        /// <returns>Строка, скорость печати</returns>
        

        public static string CalculaterSpeed(TextBox input, int temp )
        {
            return (input.Text.Length/temp*60).ToString();
        }
    }
}
