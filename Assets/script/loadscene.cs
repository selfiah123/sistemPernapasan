using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
    public void LoadScenee(string scene){
        SceneManager.LoadScene(scene);
    }
    public void KeluarAplikasi(){
        Application.Quit();
    }
}
