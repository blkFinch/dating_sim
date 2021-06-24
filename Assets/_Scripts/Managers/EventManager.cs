using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EventManager : MonoBehaviour
{
    public static EventManager active;
    [SerializeField]
    private EventDatabase eventDatabase;
    private Dictionary<string, Event> eventDictionary;
    public Event currentEvent;

    private void Awake() {
        if(active == null){
            active = this;
            BuildDictionary();
        }else{
            Destroy(this.gameObject);
        }
    }

    private void BuildDictionary(){
        eventDictionary = eventDatabase.events.ToDictionary(Event => Event.Id, 
                                                            Event => Event);
    }
    // Start is called before the first frame update
    void Start()
    {
        Calender.onNewDayCalled += OnNewDay;
    }

    //TODO: should check for possible events, then determin event order for day, then fire events 
    private void OnNewDay(){
        // currentEvent = Schedule.GetCurrentEvent();
        // currentEvent.Execute();

        Event[] dailyEvents = LookupDailyEvents(Calender.active.GetCurrentWeekday());
        if(dailyEvents.Length > 0){
            foreach(Event evt in dailyEvents){
                InkManager.active.ReadScene(evt.payload);
            }
        }
    }

    private void OnDestroy() {
        Calender.onNewDayCalled -= OnNewDay;
    }

    //TODO: normalize this function to return a list etc...
    private void LookupRecurringEvents(){
        var matches = eventDictionary.Values.Where(evt => evt.isRecurring ).ToList();
        Debug.Log(matches[0].payload);
    }

    private Event[] LookupDailyEvents(Weekday weekday){
        Event[] events = eventDictionary.Values.Where(evt => evt.weekdays.Contains(weekday)).ToArray();
        return events;
    }
    
}
