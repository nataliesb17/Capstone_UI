using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonCommands : MonoBehaviour
{
	
	public GameObject mainButton;
	public GameObject buttonOne;
	public GameObject buttonTwo;
	public GameObject buttonThree;
	public GameObject buttonFour;
	
	public GameObject settingsCanvas;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

	public void Settings() {
		settingsCanvas.SetActive(true);
	}

	public void Exit() {
		Application.Quit();
	}
	
	public void startGame() {
		SceneManager.LoadScene("insert scene name here");
	}
	
	public void Credits() {
		SceneManager.LoadScene("insert scene name here");
	}
	
	public void pressMe() {
		mainButton.SetActive(false);
		
		buttonOne.SetActive(true);
		buttonTwo.SetActive(true);
		buttonThree.SetActive(true);
		buttonFour.SetActive(true);
		
	}

}