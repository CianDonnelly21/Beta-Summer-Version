using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FoodSpawnL1 : MonoBehaviour {

private GameManagerL1 gameManager;
public GameObject BananaOne;
public GameObject BananaTwo;
public GameObject BananaThree;
public GameObject BananaMan;
public GameObject CrouchMan;
public GameObject Cherry;

void Start()
    {        
        gameManager = GameObject.Find("BananaOne").GetComponent<GameManagerL1>();
        gameManager = GameObject.Find("BananaTwo").GetComponent<GameManagerL1>();
        gameManager = GameObject.Find("BananaThree").GetComponent<GameManagerL1>();

        BananaOne.gameObject.SetActive(true);
        BananaTwo.gameObject.SetActive(false);
        BananaThree.gameObject.SetActive(false);
        Cherry.gameObject.SetActive(false);
    }

void Update()
    {  

    }

void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("BananaOne"))
        {
            gameManager.UpdateGems(1);
            BananaOne.gameObject.SetActive(false);
            BananaTwo.gameObject.SetActive(true);
        }

        if(other.CompareTag("BananaTwo"))
        {
            gameManager.UpdateGems(1);
            BananaTwo.gameObject.SetActive(false);
            BananaThree.gameObject.SetActive(true);
        } 

        if(other.CompareTag("BananaThree"))
        {
            gameManager.UpdateGems(1);
            BananaThree.gameObject.SetActive(false);
            Cherry.gameObject.SetActive(true);
        }
 
        if(other.CompareTag("Cherry"))
        {
            Cherry.gameObject.SetActive(false);
            
            //How it loads next scene - Check
            int NextIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(NextIndex);
            
            BananaMan.gameObject.SetActive(false);
            CrouchMan.gameObject.SetActive(false);
            BananaOne.gameObject.SetActive(false);
            BananaTwo.gameObject.SetActive(false);
            BananaThree.gameObject.SetActive(false);
            Cherry.gameObject.SetActive(false);
        }
    }
}