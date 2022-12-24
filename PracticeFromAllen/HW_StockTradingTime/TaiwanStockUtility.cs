using System;

public class TaiwanStockUtility
{
    public TaiwanStockUtility()
    {
        public static bool IsWeekdays(DateTime dt)
        {
            return (dt.DayOfWeek >= DayOfWeek.Monday && dt.DayOfWeek <= DayOfWeek.Friday) ? true : false;
        }

        public static bool IsOpeningHours(DateTime dt)
        {
            DateTime timeOpen = new DateTime(dt.Year, dt.Month, dt.Day, 9, 0, 0);
            DateTime timeClose = new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0);
            return ((timeOpen <= dt) && (dt >= timeClose)) ? true : false;
        }
    }
}