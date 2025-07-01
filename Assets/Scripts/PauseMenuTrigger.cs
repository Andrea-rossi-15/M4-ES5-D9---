using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuTrigger : MonoBehaviour
{
    [SerializeField] GameObject Menu;
    bool IsPause = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        IsPaused();
    }
    void IsPaused()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && IsPause == false)
        {

            Menu.SetActive(true);
            IsPause = true;
            Time.timeScale = 0f;


        }
        else if (Input.GetKeyDown(KeyCode.Escape) && IsPause == true)
        {

            Menu.SetActive(false);
            IsPause = false;
            Time.timeScale = 1f;


        }
    }

    public void CloseMenu()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
    }
}
