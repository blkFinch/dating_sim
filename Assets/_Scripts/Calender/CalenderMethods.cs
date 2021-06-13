public static class CalenderMethods{
    //6 for 2000
    //0 for 1900s
    private const int CENTURAY_CODE = 6;
    public static int DaysInMonth(Month month){
        if(month == Month.FEBRUARY){
            return 28;
        }
        //months with 30 days
        else if( month == Month.APRIL || month == Month.JUNE || 
                month == Month.SEPTEMBER || month == Month.NOVEMBER){
            return 30;
        }
        else{
            return 31;
        }
    }

    public static int CurrentWeek(int day){
        int week = (int) day / 7;
        return week;
    }

    //TODO: this could be optimized by only calling CurrentWeekday on date load and then
    //simply traking an index that increments mod7. This is fine for now
    //
    //I'm using this algorithm assuming year 2000 for ease until I implement year
    //Im also ignoring leap years
    // Take the last two digits of the year.
    // Divide by 4, discarding any fraction.
    // Add the day of the month.
    // Add the month's key value: JFM AMJ JAS OND 144 025 036 146
    // Subtract 1 for January or February of a leap year.
    // For a Gregorian date, add 0 for 1900's, 6 for 2000's, 4 for 1700's, 2 for 1800's; for other years, add or subtract multiples of 400.
    // For a Julian date, add 1 for 1700's, and 1 for every additional century you go back.
    // Add the last two digits of the year.
    // Divide by 7 and take the remainder.
    //-g. hutchison
    public static Weekday CurrentWeekday(int year, int day, int month){
        int _res = ((YearCode(year)+MonthCode(month)+day)%7);
        return (Weekday)_res;
    }

    //takes two digit year i.e 1994 = 94
    private static int YearCode(int year){
        return ((year +(year / 4))%7);
    }

    private static int MonthCode(int month){
        switch((Month)month){
            case Month.JANUARY:
                return 0;
            case Month.FEBRUARY:
                return 3;
            case Month.MARCH:
                return 3;
            case Month.APRIL:
                return 6;
            case Month.MAY:
                return 1;
            case Month.JUNE:
                return 4;
            case Month.JULY:
                return 6;
            case Month.AUGUST:
                return 2;
            case Month.SEPTEMBER:
                return 5;
            case Month.OCTOBER:
                return 0;
            case Month.NOVEMBER:
                return 3;
            case Month.DECEMBER:
                return 5;
            default:
                return 0;
        }
    }
}

public enum Weekday
{
    SUNDAY = 0,
    MONDAY,
    TUESDAY,
    WEDNESDAY,
    THURSDAY,
    FRIDAY,
    SATURDAY
}

public enum Month
{
    JANUARY = 1,
    FEBRUARY,
    MARCH,
    APRIL,
    MAY,
    JUNE,
    JULY,
    AUGUST,
    SEPTEMBER,
    OCTOBER,
    NOVEMBER,
    DECEMBER 
}
