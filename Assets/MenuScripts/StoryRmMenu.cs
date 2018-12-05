using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoryRmMenu : MonoBehaviour {

    public void NextScene ()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
