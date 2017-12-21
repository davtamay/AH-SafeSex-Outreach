using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvaluateDropDownResponses : MonoBehaviour {

	public string correctResponse;

	public Dropdown dropDown;

	[SerializeField]private string response;

	private Text dropDownText;

	[SerializeField]GameObject correctGO;
	[SerializeField]GameObject inCorrectGO;

	[SerializeField]Button SubmitButton;
	public void Start(){

		response = GetComponentInChildren<Text> ().text;

		dropDown = GetComponent<Dropdown> ();
		//dropDown.onValueChanged.AddListener (delegate {CheckResponse();} );

		correctGO = transform.parent.Find("Correct").gameObject;
		inCorrectGO = transform.parent.Find("InCorrect").gameObject;

		correctGO.SetActive (false);
		inCorrectGO.SetActive (false);

		SubmitButton.onClick.AddListener (delegate {CheckResponse();});

	}

	public void CheckResponse(){

		correctGO.SetActive (false);
		inCorrectGO.SetActive (false);

		response = GetComponentInChildren<Text> ().text;

		if (response == correctResponse)
			correctGO.SetActive (true);
		else
			inCorrectGO.SetActive (true);


	}
}
