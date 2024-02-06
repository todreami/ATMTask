using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Cash;
    public GameObject InputBar;
    public GameObject OutputBar;
    public GameObject InputMode;
    public GameObject OutputMode;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void enterInputMode()
    {
        if (Input.GetButtonDown("InputBar"))
        {
            InputMode.SetActive(true);
        }
    }
    public void enterOutputMode()
    {
        if (Input.GetButtonDown("OutputBar"))
        {
            OutputMode.SetActive(true);
        }
    }


}
