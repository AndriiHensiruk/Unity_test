using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttom_Menedger : MonoBehaviour
{
   
    // Update is called once per frame
    public void Button_Pause() 
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
        }
        else {
            GetComponent<Panel_Menu>().pauseMenuUI.SetActive(false);
            Time.timeScale = 1; }
    }

    public void Button_Restart()
    {
        SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        Time.timeScale = 1;
    }
    public void Button_Quit()
    {
        Application.Quit();
    }
}
