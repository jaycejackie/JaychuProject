using UnityEngine;
using System.Collections;

public class LoginView : MonoBehaviour {
	public UIInput name, pass;
	public UILabel Notifi;
	public UIButton LoginButton, BackButton;

	public UIWidget LoginContainer, MainMenuContainer;

	void Awake()
	{
		EventDelegate.Add (LoginButton.onClick, LoginButtonClick);
		EventDelegate.Add (BackButton.onClick, BackButtonClick);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void LoginButtonClick()
	{
		bool is_ok = true;
		if(name.value == "" || name.value == name.defaultText || pass.value == "" || pass.value == pass.defaultText)
			is_ok = false;

		if(is_ok)
		{
			Notifi.text = "LOGIN SUCCESS";
		}
		else
		{
			Notifi.text = "LOGIN FAILED";
		}

		TweenPosition.Begin(LoginContainer.gameObject, 0.3f, new Vector3(0, -640, 0));
		TweenPosition.Begin(MainMenuContainer.gameObject, 0.3f, Vector3.one);
	}
	private void BackButtonClick()
	{
		TweenPosition.Begin(LoginContainer.gameObject, 0.3f, Vector3.one);
		TweenPosition.Begin(MainMenuContainer.gameObject, 0.3f, new Vector3(0, 640, 0));
	}
}
