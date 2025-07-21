using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Food_SpawnL2 : MonoBehaviour {

private GameManager gameManager;
public GameObject BananaOne;
public GameObject BananaTwo;
public GameObject BananaThree;
public GameObject Cherry;
public GameObject Hotdog;
public GameObject BananaMan;
public GameObject CrouchMan;

void Start()
    {
        gameManager = GameObject.Find("BananaOne").GetComponent<GameManager>();
        gameManager = GameObject.Find("BananaTwo").GetComponent<GameManager>();
        gameManager = GameObject.Find("BananaThree").GetComponent<GameManager>();

        BananaOne.gameObject.SetActive(true);
        BananaTwo.gameObject.SetActive(false);
        BananaThree.gameObject.SetActive(false);
        Cherry.gameObject.SetActive(false);
        Hotdog.gameObject.SetActive(true);

        BananaOne.gameObject.transform.position = new Vector3(Random.Range(-5, 10), 5, -2);
    }

void Update()
    {  

    }

void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("BananaOne"))
        {
            BananaOne.gameObject.SetActive(false);
            BananaTwo.gameObject.transform.position = new Vector3(Random.Range(-7, 10), 5, -2);
            BananaTwo.gameObject.SetActive(true);
        }

        if(other.CompareTag("BananaTwo"))
        {
            BananaTwo.gameObject.SetActive(false);
            BananaThree.gameObject.transform.position = new Vector3(Random.Range(-10, 10), 5, -2);
            BananaThree.gameObject.SetActive(true);
        } 

        if(other.CompareTag("BananaThree"))
        {
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
            Hotdog.gameObject.SetActive(false);
        }

        if(other.CompareTag("Death"))
        {
            BananaMan.gameObject.SetActive(false);
            CrouchMan.gameObject.SetActive(false);
            BananaOne.gameObject.SetActive(false);
            BananaTwo.gameObject.SetActive(false);
            BananaThree.gameObject.SetActive(false);
            Cherry.gameObject.SetActive(false);
            Hotdog.gameObject.SetActive(false);

            SceneManager.LoadScene(5);
        }
    }
}