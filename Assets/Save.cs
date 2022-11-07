using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Save : MonoBehaviour
{
    [SerializeField]
    GameObject Couner;
    private void Awake()
    {
        LoadGame();
    }
    private void OnApplicationQuit()
    {
        SaveGame();
    }
    void SaveGame()
    {
        PlayerPrefs.SetInt("SavedInteger", Couner.GetComponent<Click>().count);
        PlayerPrefs.SetInt("SavedInCome", Couner.GetComponent<Click>().income);
        PlayerPrefs.Save();
        Debug.Log("Game data saved!");
    }
    void LoadGame()
    {
        if (PlayerPrefs.HasKey("SavedInteger"))
        {
            Couner.GetComponent<Click>().count = PlayerPrefs.GetInt("SavedInteger");
            Couner.GetComponent<Click>().income = PlayerPrefs.GetInt("SavedInCome");
            Debug.Log("Game data loaded!");
        }
        else
            Debug.LogError("There is no save data!");
    }
}
