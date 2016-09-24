using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum StateMachine{
	STARTGAME,
	MENU,
	INGAME,
	PAUSED,
	GAMEOVER,
	WIN
}

public class GameController : MonoBehaviour {

	private StateMachine stateMachine;
	private int score;
	public Text textScore ;

	// Use this for initialization
	void Start () {
		stateMachine = StateMachine.STARTGAME;
	}
	
	// Update is called once per frame
	void Update () {
		currentStateMachine ();
	}

	private void currentStateMachine(){

		switch (stateMachine) {
		case StateMachine.STARTGAME:{
				StartGame ();
				break;
			}

		case StateMachine.INGAME:{
				InGame ();
				break;
			}

		case StateMachine.PAUSED:{
				break;
			}

		case StateMachine.GAMEOVER:{
				GameOver ();
				break;
			}
		case StateMachine.MENU:{
				Menu ();
				break;
			}

		case StateMachine.WIN:{
				break;
			}
		}

	}

	public StateMachine getCurrentState(){
		return stateMachine;
	}

	public void setCurrentState(StateMachine value){
		stateMachine = value;
	}

	public void SubScore(){
		this.score -= 50;
	}

	public void AddScore(){
		this.score += 30;
	}

	public void Menu(){
		setCurrentState (StateMachine.MENU);
		SceneManager.LoadScene ("Menu");
	}

	private void InGame(){
		textScore.text = score.ToString ();
	}

	public void StartGame(){
		score = 0;
		setCurrentState (StateMachine.INGAME);
	}

	void GameOver(){
		/*
		PlayerPrefs.SetInt ("score", score);
		if (score > PlayerPrefs.GetInt ("bestScore")) {
			PlayerPrefs.SetInt("bestScore", score);
		}
		*/
		SceneManager.LoadScene ("GameOver");
	}
}
