using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuBtns : MonoBehaviour 
{

    public string FirstScene;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void ExitButton()
    {
        Application.Quit();
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(FirstScene);
    }
}
