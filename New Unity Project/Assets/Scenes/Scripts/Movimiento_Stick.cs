using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class Movimiento_Stick : MonoBehaviour,IDragHandler,IPointerUpHandler,IPointerDownHandler {

	Image bgImg;
	public Image joyStickImg;
	public float speed;
   
    public Vector3 inputDirection { set; get; }
  
	Touch touch;
	Vector3 touchPosition, whereToMove;
	float previousDistanceToTouchPos, currentDistanceToTouchPos;
   public GameObject personajeActivo;

	void Start()
	{
   
		bgImg = GetComponent<Image> ();
       
        inputDirection = Vector3.zero;

	}
	Vector2 pos;

	public virtual void OnDrag(PointerEventData ped)
	{
		pos = Vector2.zero;
		if(RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImg.rectTransform,ped.position,ped.pressEventCamera,out pos))
		{
			pos.x = (pos.x / bgImg.rectTransform.sizeDelta.x);
			pos.y = (pos.y / bgImg.rectTransform.sizeDelta.y);

			float x = (bgImg.rectTransform.pivot.x == 1) ? pos.x * 2 + 1 : pos.x * 2 - 1;
			float y = (bgImg.rectTransform.pivot.y == 1) ? pos.y * 2 + 1 : pos.y * 2 - 1;
		
			inputDirection = new Vector3 (x, 0, y);

			inputDirection = (inputDirection.magnitude > 1) ? inputDirection.normalized : inputDirection;
			joyStickImg.rectTransform.anchoredPosition = new Vector3 (inputDirection.x * (bgImg.rectTransform.sizeDelta.x / 3), inputDirection.z * (bgImg.rectTransform.sizeDelta.y / 3));


		}
	}

               

	public virtual void OnPointerDown(PointerEventData ped)
	{
	//	OnDrag (ped);
	}

	public virtual void OnPointerUp(PointerEventData ped)
	{
        ResetJoystick();
      
    }


	
	// Update is called once per frame
	void Update ()
	{
   
        mov = new Vector2(inputDirection.x, inputDirection.z);
        personajeActivo.transform.Translate(mov.normalized * speed * Time.deltaTime);

    }
 

    Vector2 mov;
    
    public void ResetJoystick()
    {
        inputDirection = Vector3.zero;
        joyStickImg.rectTransform.anchoredPosition = Vector2.zero;
        mov = Vector2.zero;
      
     
    }
} 