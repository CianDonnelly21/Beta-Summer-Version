using UnityEngine;

public class BananMan_Movement : MonoBehaviour {

public float speed = 0.1f;
public GameObject CrouchMan;
public GameObject BananaMan;
public GameObject BackMan;

void Start() 
    {
        BananaMan.gameObject.SetActive(true);
        CrouchMan.gameObject.SetActive(false);
        BackMan.gameObject.SetActive(false);
    }

void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.back * speed);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * 1);
        }
        //Double Jump
        if (Input.GetKey(KeyCode.R))
        {
            transform.Translate(Vector3.up * 7);
        }

        //Crouch 
        if (Input.GetKey(KeyCode.S))
        {
            BananaMan.transform.position = transform.position;

            CrouchMan.gameObject.SetActive(true);
            BananaMan.gameObject.SetActive(false);
        }
        else 
        {
            CrouchMan.transform.position = transform.position;

            CrouchMan.gameObject.SetActive(false);
            BananaMan.gameObject.SetActive(true);
        }
    }
}