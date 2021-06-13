[System.Serializable]
public class GameDate
{
   public int month;
   public int day;

   public GameDate()
   {
      month = day = 1;
   }

   public GameDate(int month, int day)
   {
      this.month = month;
      this.day = day;
   }

   public void SetDate(int month, int day){
      this.month = month;
      this.day = day;
   }

   public void IncrementDay(){
      if(this.day < CalenderMethods.DaysInMonth((Month)month)){
         this.day++;
      }else{
         day = 1;
         month = (month + 1)%12;
         if(month == 0){ month = 1;}
      }
   }
}


