using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName = "Scriptable Objects/Event Database")]
public class EventDatabase : ScriptableObject
{
    public EventDBEntry[] events;
}

[System.Serializable]
public struct EventDBEntry{
    public int id;
    public Event Event;
}
