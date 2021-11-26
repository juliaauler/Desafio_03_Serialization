using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour{
    // Character info
    public int CharacterLevel {get; set;}
    public string[] CharacterName = new string[50]{"Isabella","Manuela","Helena","Giovanna","Beatriz","Ana","Rafaela","Emanuelly","Maria","Amanda",
                                                    "Alice","Valentina","Laura","Manuela","Melissa","Bianca","Lorena","Clara","Gabriela","Yasmin","Leticia",
                                                    "Bruna","Eduarda","Laila","Rafaela","Jade","Ariela","Catarina","Clarisse","Marina","Ariana","Fernanda",
                                                    "Paloma","Isa","Sabrina","Milene","Dulce","Miguel","Arthur","Pedro","Gabriel","Lucas","Matheus","Heitor",
                                                    "Nicolas","Lorenzo","Gustavo","Henrique","Leonardo","Pietro"};
    public string[] CharacterFamilyName = new string[50]{"Valero","Tigersoul","Moonridge","Solomatine","Falconsflight","Amblecrown","Redraven","Chernin","Ordoe",
                                                        "Trannyth","Stayanoga","Ravenmar","Arroway","Hahpet","Serpenthelm","Dragonsbane","Doemenel","Kreel","Hindergrass",
                                                        "Windrivver","Helder","Stormchapel","Droverson","Vrye","Faral","Anskuld","Tallcrag","Seratolva","Einhorn","Smedley",
                                                        "Silverkin","Beordsen","Talandro","Sell","Hawklight","Rein","Zatchet","Ammin","Oakenheart","Shieldheart","Uuthrakt",
                                                        "Hyden","Mountainwound","Ramondo","Gilmore","Armorsmith","Furis","Webb","Starag","Selvarum"};
    public int CharacterHP {get; set;}
    public int CharacterMP {get; set;}
    public int CharacterWeight {get; set;}

    // Life skills info
    public int LevelGathering {get; set;}
    public int LevelFishing {get; set;}
    public int LevelHunting {get; set;}
    public int LevelCooking {get; set;}
    public int LevelAlchemy {get; set;}
    public int LevelProcess {get; set;}
    public int LevelHorse {get; set;}
    public int LevelTrade {get; set;}
    public int LevelFarming {get; set;}
    public int LevelSailing {get; set;}

    [SerializeField]
    private Text textLevel;
    [SerializeField]
    private Text textName;
    [SerializeField]
    private Text textFamilyName;
    [SerializeField]
    private Text textHP;
    [SerializeField]
    private Text textMP;
    [SerializeField]
    private Text textWeight;
    [SerializeField]
    private Text textGathering;
    [SerializeField]
    private Text textFishing;
    [SerializeField]
    private Text textHunting;
    [SerializeField]
    private Text textCooking;
    [SerializeField]
    private Text textAlchemy;
    [SerializeField]
    private Text textProcess;
    [SerializeField]
    private Text textHorse;
    [SerializeField]
    private Text textTrade;
    [SerializeField]
    private Text textFarming;
    [SerializeField]
    private Text textSailing;

    public int Name;
    public int FamilyName; 
    public void GenerateNewData(){
        // Character info
        CharacterLevel = Random.Range(1,61); 
        Name = Random.Range(0,49);
        FamilyName = Random.Range(0,49); 
        CharacterHP = Random.Range(1,5600);
        CharacterMP = Random.Range(1,3400);
        CharacterWeight = Random.Range(1,800);

        // Life skills info
        LevelGathering = Random.Range(1,100);
        LevelFishing = Random.Range(1,100);
        LevelHunting = Random.Range(1,100);
        LevelCooking = Random.Range(1,100);
        LevelAlchemy = Random.Range(1,100);
        LevelProcess = Random.Range(1,100);
        LevelHorse = Random.Range(1,100);
        LevelTrade = Random.Range(1,100);
        LevelFarming = Random.Range(1,100);
        LevelSailing = Random.Range(1,100);
        ShowData();
    }

    public void ShowData(){
        textLevel.text = CharacterLevel.ToString();
        textName.text = CharacterName[Name];
        textFamilyName.text = CharacterFamilyName[FamilyName];
        textHP.text = CharacterHP.ToString();
        textMP.text = CharacterMP.ToString();
        textWeight.text = CharacterWeight.ToString();
        textGathering.text = LevelGathering.ToString();
        textFishing.text = LevelFishing.ToString();
        textHunting.text = LevelHunting.ToString();
        textCooking.text = LevelCooking.ToString();
        textAlchemy.text = LevelAlchemy.ToString();
        textProcess.text = LevelProcess.ToString();
        textHorse.text = LevelHorse.ToString();
        textTrade.text = LevelTrade.ToString();
        textFarming.text = LevelFarming.ToString();
        textSailing.text = LevelSailing.ToString();
    }
}