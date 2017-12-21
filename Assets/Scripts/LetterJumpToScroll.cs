using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LetterJumpToScroll : MonoBehaviour, IPointerClickHandler {

//	[SerializeField]private Scrollbar scrollbar;


//	[SerializeField]private RectTransform startBoundLetter;
//	[SerializeField]private RectTransform endBoundsLetter;
//
//	[SerializeField]private float fullBoundSpace;
//
//	[SerializeField]private float offSetValue;
//	[SerializeField]private float fullValue;

	[SerializeField]private RectTransform associatedLetter;

//	[SerializeField]private float letterBoundSpace;
//	[SerializeField]private float letterValue;



//	[SerializeField]private float yStartBound;
//	[SerializeField]private float yLastBound;

//	[SerializeField]private float jumpToLocation;


//	IEnumerator Start () {
//		yield return new WaitForSeconds (2f);
//
//		Vector3[] startPos = new Vector3[4];
//		Vector3[] endPos = new Vector3[4];
//		Vector3[] assLetterPos = new Vector3[4];
//		startBoundLetter.GetWorldCorners(startPos);
//		endBoundsLetter.GetWorldCorners(endPos);
//		associatedLetter.GetWorldCorners (assLetterPos);
//
//
//		fullBoundSpace = Vector3.Distance(startPos[3], endPos[3]);
//
//		letterBoundSpace = Vector3.Distance(startPos[3], assLetterPos[3]); //Mathf.Abs(assLetterPos [3].y);
//
//		Debug.Log (letterBoundSpace);
//
//		letterValue = Mathf.Clamp01( letterBoundSpace/fullBoundSpace );// + offSetValue;
//
////		fullBoundSpace = startBoundLetter.rect.center.y + (startBoundLetter.rect.height/2) - endBoundsLetter.rect.center.y + (endBoundsLetter.rect.height/2);
////
////		letterBoundSpace = startBoundLetter.rect.center.y + (startBoundLetter.rect.height/2) - associatedLetter.rect.center.y +  (associatedLetter.rect.height/2);
////
////		letterValue =  ( letterBoundSpace/ fullBoundSpace ) + offSetValue;
//
//	}


	public void OnPointerClick(PointerEventData eventData){
		
	//	scrollbar.value = 1 - letterValue; //+ offSetValue;
		SnapTo (associatedLetter);

	}

	public ScrollRect scrollRect;
	public RectTransform contentPanel;

	public void SnapTo(RectTransform target){

		Canvas.ForceUpdateCanvases ();

		contentPanel.anchoredPosition = (Vector2)scrollRect.transform.InverseTransformPoint(contentPanel.position) - 
		                                                                                    (Vector2)scrollRect.transform.InverseTransformPoint(target.position);
	
	
	
	}


	

}
