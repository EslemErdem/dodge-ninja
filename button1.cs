using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button1 : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        //ninja.panel.SetActive(false);
    }
}
