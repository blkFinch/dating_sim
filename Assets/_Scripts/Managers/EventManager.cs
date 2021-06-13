using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EventManager : MonoBehaviour
{
    public static EventManager active;
    [SerializeField]
    private EventDatabase eventDatabase;
    private Dictionary<int, Event> eventDictionary;
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
        eventDictionary = eventDatabase.events.ToDictionary(EventDBEntry => EventDBEntry.id, 
                                                            EventDBEntry => EventDBEntry.Event);
        LookupRecurringEvents();
    }
    // Start is called before the first frame update
    void Start()
    {
        Calender.onNewDayCalled += OnNewDay;
    }

    private void OnNewDay(){
        // currentEvent = Schedule.GetCurrentEvent();
        // currentEvent.Execute();
    }

    private void OnDestroy() {
        Calender.onNewDayCalled -= OnNewDay;
    }

    private void LookupRecurringEvents(){
        var matches = eventDictionary.Values.Where(evt => evt.isRecurring ).ToList();
        Debug.Log(matches[0].payload);
    }
    
}
