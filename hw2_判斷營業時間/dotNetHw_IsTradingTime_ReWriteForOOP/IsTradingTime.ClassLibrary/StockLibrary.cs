using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTradingTime.ClassLibrary
{
    public static class StockLibrary
    {   
        public static bool IsTrading(DateTime dt)
            => (
            (int)dt.DayOfWeek >= (int)DayOfWeek.Monday &&
            (int)dt.DayOfWeek <= (int)DayOfWeek.Friday &&
            dt.IsTimeMoreThan(09,00) &&
            dt.IsTimeLessThan(13,30)
            );
        /// <summary>
        /// 確定輸入是否大於當日的某個時間點
        /// </summary>
        /// <param name="inputTime"></param>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        /// <returns></returns>
        public static bool IsTimeMoreThan(this DateTime inputTime, int hour, int minute) {

            System.DateTime openTime = new System.DateTime(inputTime.Year, 
                inputTime.Month, inputTime.Day, hour, minute, 0);
            return openTime <= inputTime;
        }
        /// <summary>
        /// 確定輸入是否小於當日的某個時間點
        /// </summary>
        /// <param name="inputTime"></param>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        /// <returns></returns>
        public static bool IsTimeLessThan(this DateTime inputTime, int hour, int minute)
        {
            DateTime closeTime = new DateTime(inputTime.Year,
                inputTime.Month, inputTime.Day, hour, minute, 0);
            return closeTime >= inputTime;

        }

    }
}
