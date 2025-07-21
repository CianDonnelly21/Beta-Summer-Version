using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerL1 : MonoBehaviour {

//Scene Changer

//Text in game eg. gems collected, health, and time
public Button HomeButton;

public int gems;
public TextMeshProUGUI Gems;

void Start() 
    {
        HomeButton.onClick.AddListener(MainMenu);
        gems = 3;
    }

void Update()
    {

    }

public void UpdateGems(int NumberOfGems)
    {
        gems -= NumberOfGems;
        Gems.text = "Bananas: " + gems;
    }
    
void MainMenu()
{
    SceneManager.LoadScene(0);
    }

void LevelOne()
    {
        SceneManager.LoadScene(1);
    }

    void LevelTwo()
    {
        SceneManager.LoadScene(2);
    }

    void LevelThree()
    {
        SceneManager.LoadScene(3);
    }

    void Win()
    {
        SceneManager.LoadScene(4);
    }

    void Lose()
    {
        SceneManager.LoadScene(5);
    }
}