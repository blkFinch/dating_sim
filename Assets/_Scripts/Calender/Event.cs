using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName = "Scriptable Objects/Calender Event")]
public class Event : BaseScriptableObject
{
    
    public Month month;
    public int day;
    public Weekday[] weekdays;
    public bool isRecurring = false;
    public string payload = "default payload";
    
}
