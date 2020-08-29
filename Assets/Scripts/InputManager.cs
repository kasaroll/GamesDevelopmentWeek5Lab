using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Transform[] transArray;

    // Start is called before the first frame update
    void Start()
    {
        transArray = new Transform[2];
        transArray[0] = GameObject.FindWithTag("Red").transform;
        transArray[1] = GameObject.FindWithTag("Blue").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            GameObject.FindWithTag("Red").transform.Rotate(0.0f, 0.0f, 45.0f);
            GameObject.FindWithTag("Blue").transform.Rotate(0.0f, 0.0f, -45.0f);
        }

        if(Input.GetButtonDown("Fire1"))
        {
            if (GameObject.FindWithTag("Red") != null)
            {
                GameObject.FindWithTag("Red").transform.position = new Vector3(transArray[0].position.x, transArray[0].position.y * -1, transArray[0].position.z);
            }
            if (GameObject.FindWithTag("Blue") != null)
            {
                GameObject.FindWithTag("Blue").transform.position = new Vector3(transArray[1].position.x, transArray[1].position.y * -1, transArray[1].position.z);
            }
        }

        if (Input.GetButtonUp("Fire1"))
        {
            if (GameObject.FindWithTag("Red") != null)
            {
                float redRandNum = Random.Range((51.0f / 255.0f), (255.0f / 255.0f));
                GameObject.FindWithTag("Red").GetComponent<PrintAndHide>().rend.material.color = new Color(redRandNum, 0.0f, 0.0f);
                Debug.Log("Red: " + redRandNum);
            }
            if (GameObject.FindWithTag("Blue") != null)
            {
                float blueRandNum = Random.Range((51.0f / 255.0f), (255.0f / 255.0f));
                GameObject.FindWithTag("Blue").GetComponent<PrintAndHide>().rend.material.color = new Color(0.0f, 0.0f, blueRandNum);
                Debug.Log("Blue: " + blueRandNum);
            }
        }
    }
}
