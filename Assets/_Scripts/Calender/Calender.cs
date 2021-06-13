using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calender : MonoBehaviour
{
    public static Calender active;
    public GameDate date;
    public delegate void OnNewDay();
    public static OnNewDay onNewDayCalled;
    private void Awake() {
        if(active == null){
            active = this;
            date = new GameDate();
        }else{
            Destroy(this.gameObject);
        }

        Debug.Log(CurrentDateString());
    }

    public void NewDay(){
        date.IncrementDay();
        onNewDayCalled();
    }

    public string CurrentDateString(){
        return (Month)date.month + " " + date.day + " " + CalenderMethods.CurrentWeekday(00, date.day, date.month);
    }
}
