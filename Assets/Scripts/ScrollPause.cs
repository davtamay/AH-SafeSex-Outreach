using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollPause : MonoBehaviour {


	[SerializeField]private float pauseTime;
	[SerializeField]private int numberOfImages;
	private float scrollIncrement;
	[SerializeField]private float scrollSpeed;

	private Scrollbar scrollBar;

	void Awake (){
		scrollBar = GetComponent<Scrollbar> ();

		scrollIncrement = 1 / (float)(numberOfImages -1);
		
	}
	private float timer, tempVal;
	private bool isReset;
	public IEnumerator Start(){
		//tempVal = scrollBar.value + scrollIncrement;

		yield return new WaitForSeconds (pauseTime);

		while (true) {

			yield return new WaitForSeconds (pauseTime);

			if(isReset){
				isReset = false;
				scrollBar.value = 0;
				yield return new WaitForSeconds (pauseTime);
			}

			tempVal = scrollBar.value + scrollIncrement;
	
			while(scrollBar.value < tempVal){

				yield return null;
				if (scrollBar.value >= 1f){
					isReset = true;
					break;
				}
					
					scrollBar.value += scrollSpeed * Time.deltaTime;
				}

		}
	}
}