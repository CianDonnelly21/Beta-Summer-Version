using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Food_SpawnL3 : MonoBehaviour {

private GameManagerL1 gameManager;
public GameObject BananaOne;
public GameObject BananaTwo;
public GameObject BananaThree;
public GameObject Cherry;
public GameObject Hotdog;
public GameObject BananaMan;
public GameObject CrouchMan;
public GameObject Olive;
public GameObject BoxMovable;
public GameObject Removal;

void Start()
    {
        gameManager = GameObject.Find("BananaOne").GetComponent<GameManagerL1>();
        gameManager = GameObject.Find("BananaTwo").GetComponent<GameManagerL1>();
        gameManager = GameObject.Find("BananaThree").GetComponent<GameManagerL1>();

        BananaOne.gameObject.SetActive(true);
        BananaTwo.gameObject.SetActive(false);
        BananaThree.gameObject.SetActive(false);
        Cherry.gameObject.SetActive(false);
        Hotdog.gameObject.SetActive(true);
        Olive.gameObject.SetActive(true);
        Removal.gameObject.SetActive(false);

        BananaOne.gameObject.transform.position = new Vector3(Random.Range(-5, 10), 6, -2);
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
            BananaTwo.gameObject.transform.position = new Vector3(Random.Range(-7, 10), 6, -2);
            BananaTwo.gameObject.SetActive(true);
        }

        if(other.CompareTag("BananaTwo"))
        {
            gameManager.UpdateGems(1);
            BananaTwo.gameObject.SetActive(false);
            BananaThree.gameObject.transform.position = new Vector3(Random.Range(-10, 10), 6, -2);
            BananaThree.gameObject.SetActive(true);
        } 

        if(other.CompareTag("BananaThree"))
        {
            gameManager.UpdateGems(1);
            BananaThree.gameObject.SetActive(false);
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
            Hotdog.gameObject.SetActive(false);
            Olive.gameObject.SetActive(false);
        }

        if(other.CompareTag("Death"))
        {
            gameManager.UpdateLives(1);
            BananaMan.gameObject.SetActive(false);
            CrouchMan.gameObject.SetActive(false);
            BananaOne.gameObject.SetActive(false);
            BananaTwo.gameObject.SetActive(false);
            BananaThree.gameObject.SetActive(false);
            Cherry.gameObject.SetActive(false);
            Hotdog.gameObject.SetActive(false);
            Olive.gameObject.SetActive(false);

            SceneManager.LoadScene(5);
        }

        if(other.CompareTag("Olive"))
        {
            Olive.gameObject.SetActive(false);
            Removal.gameObject.SetActive(true);
            BoxMovable.gameObject.SetActive(false);
        }

        if (other.CompareTag("Removal"))
        {
            Removal.gameObject.SetActive(false);
            Cherry.gameObject.SetActive(true);

        }
    }
}