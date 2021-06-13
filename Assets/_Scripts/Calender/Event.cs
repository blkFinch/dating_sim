using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName = "Scriptable Objects/Calender Event")]
public class Event : ScriptableObject
{
    
    public Month month;
    public int day;
    public Weekday[] weekdays;
    public bool isRecurring = false;
    public string payload = "default payload";

    //TODO create tool for generating Calender Events that makes unique id
    [SerializeField]
    private int eventID;
    
}
