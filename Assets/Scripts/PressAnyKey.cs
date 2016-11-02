using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PressAnyKey : MonoBehaviour {

    public string nextScene;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene(nextScene);
        }
	}
}
