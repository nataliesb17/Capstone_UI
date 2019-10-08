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
	
	public Animator anime;
	public Animator animeFour;
	public Animator settings;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

	public void Settings() {
		settings.SetTrigger("ifPressed");
		
		buttonOne.SetActive(false);
		buttonTwo.SetActive(false);
		buttonThree.SetActive(false);
		buttonFour.SetActive(false);
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
		anime.SetTrigger("ifPressed");
		animeFour.SetTrigger("ifPressed");
		
		buttonOne.SetActive(true);
		buttonTwo.SetActive(true);
		buttonThree.SetActive(true);
		buttonFour.SetActive(true);
		
	}

}