using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //untuk pindah scene
    public void changeScene() {
        SceneManager.LoadScene("game");
    }

    public void exitGame() {
        Application.Quit();
    }
}
