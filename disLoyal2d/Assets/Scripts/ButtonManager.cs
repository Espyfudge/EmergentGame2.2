using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    // Function for loading scenes
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
