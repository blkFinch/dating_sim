using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlayerStatEditor : EditorWindow
{
    string playerName;
    int _str;
    int _int;
    int _soc;
    int _cha;

    [MenuItem("CustomEditors/Stat Editor")]

    public static void ShowWindow(){
        EditorWindow.GetWindow(typeof(PlayerStatEditor));
    }
    private void OnGUI() {
        GUILayout.Label("Player Stats", EditorStyles.boldLabel);
        playerName = EditorGUILayout.TextField("Name", playerName);
        _str = EditorGUILayout.IntField("STR", _str);
        _int = EditorGUILayout.IntField("INT", _int);
        _soc = EditorGUILayout.IntField("SOC", _soc);
        _cha = EditorGUILayout.IntField("CHA", _cha);

        if(GUILayout.Button("Save Stats")){
            PlayerStats newStats = new PlayerStats(_int,_cha,_soc,_str, playerName);
            SaveLoad.SaveData(newStats);
        }
    }
}
