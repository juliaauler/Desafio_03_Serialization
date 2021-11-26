using System.IO;
using UnityEngine;
using System.Collections.Generic;
using UnityEditor;


[RequireComponent(typeof(GameData))]
public class SaveScript : MonoBehaviour{
    private GameData gameData;
    private string savePath;

    void Start(){
        gameData = GetComponent<GameData>();
    }

    public void SaveData(){
        var save = new Save(){
            // Character info
            SavedLevel = gameData.CharacterLevel,
            SavedName = gameData.CharacterName[gameData.Name],
            SavedFamilyName = gameData.CharacterFamilyName[gameData.FamilyName],
            SavedHP = gameData.CharacterHP,
            SavedMP = gameData.CharacterMP,
            SavedWeight = gameData.CharacterWeight,

            // Life skills info
            SavedGathering = gameData.LevelGathering,
            SavedFishing = gameData.LevelFishing,
            SavedHunting = gameData.LevelHunting,
            SavedCooking = gameData.LevelCooking,
            SavedAlchemy = gameData.LevelAlchemy,
            SavedProcess = gameData.LevelProcess,
            SavedHorse = gameData.LevelHorse,
            SavedTrade = gameData.LevelTrade,
            SavedFarming = gameData.LevelFarming,
            SavedSailing = gameData.LevelSailing
        };

        string json = JsonUtility.ToJson(save,true);
        Debug.Log(json);
        savePath = Application.dataPath + "/Resources/Saves/SaveGame.json";
        Debug.Log(savePath);
        File.WriteAllText(savePath,json);

        AssetDatabase.Refresh();

        Debug.Log("Data Saved");
    }

    public void LoadData(){
        if (File.Exists(savePath)){

            TextAsset jsonString = Resources.Load<TextAsset>("Saves/SaveGame");
            Save save = JsonUtility.FromJson<Save>(jsonString.text);

            // Character info
            gameData.CharacterLevel = save.SavedLevel; 
            gameData.Name = System.Array.IndexOf(gameData.CharacterName, save.SavedName);
            gameData.FamilyName = System.Array.IndexOf(gameData.CharacterFamilyName, save.SavedFamilyName);
            gameData.CharacterHP = save.SavedHP; 
            gameData.CharacterMP = save.SavedMP; 

            // Life skills info
            gameData.CharacterWeight = save.SavedWeight; 
            gameData.LevelGathering = save.SavedGathering; 
            gameData.LevelFishing = save.SavedFishing; 
            gameData.LevelHunting = save.SavedHunting; 
            gameData.LevelCooking = save.SavedCooking; 
            gameData.LevelAlchemy = save.SavedAlchemy; 
            gameData.LevelProcess = save.SavedProcess; 
            gameData.LevelHorse = save.SavedHorse;
            gameData.LevelTrade = save.SavedTrade; 
            gameData.LevelFarming = save.SavedFarming;
            gameData.LevelSailing = save.SavedSailing; 

            gameData.ShowData();

            Debug.Log("Data Loaded");
        }

        else{
            Debug.LogWarning("Save file doesn't exist!");
        }
    }
}