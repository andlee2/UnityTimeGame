using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManip : MonoBehaviour
{

    

    public Transform currentTimeManipObj = null;
    public Transform timeCanvas = null;
    public TimeBar timeBar;
    public int maxUses = 3;
    public int remainingUses;
    
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag ("timeManipObject")){
            Debug.Log(other.name + " can be time manipulated");
            currentTimeManipObj = other.transform;
            //currentTimeManipObjScript = currentTimeManipObj.GetComponent<TimeManipObj>();

        }
        if (other.CompareTag("TimeSnack")){
            if (remainingUses < maxUses)
            {
                addTimeJuice(other.transform.GetComponent<TimeSnack>().power);
                other.gameObject.SetActive(false);
            }
        }

    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag ("timeManipObject")){
            if (other.transform == currentTimeManipObj) {
                currentTimeManipObj = null;
                
            }
            
           
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        timeCanvas.GetChild(0).GetChild(0).gameObject.SetActive(false);
        remainingUses = maxUses;
        timeBar.SetMaxTimeJuice(maxUses);

    }
    //private bool showGui = false;
    // Update is called once per frame\
    private Sprite pastSprite;
    private Sprite futureSprite;
    void Update()
    {

        if (Input.GetButton("ChangeTime")){
            timeCanvas.GetChild(0).gameObject.SetActive(true);

            if (currentTimeManipObj) {
                
                timeCanvas.GetChild(0).GetChild(0).gameObject.SetActive(true);
                //timeCanvas.GetChild(0).GetChild(0).gameObject.GetComponent<Image>().overrideSprite = currentTimeManipObj.gameObject.GetComponent<SpriteRenderer>().sprite; //grabs current timeobject sprite
                

                if (Input.GetMouseButtonDown(0) && remainingUses > 0) {
                   
                    currentTimeManipObj.SendMessage("past");
                    pastSprite = currentTimeManipObj.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite;
                    timeCanvas.GetChild(0).GetChild(0).gameObject.GetComponent<Image>().overrideSprite = pastSprite;
                    //currentTimeManipObj.gameObject.GetComponent<SpriteRenderer>().sprite = pastSprite;
                    useTimeJuice(1);
                }
                if (Input.GetMouseButtonDown(1) && remainingUses > 0) {
                    
                    currentTimeManipObj.SendMessage("future");
                    futureSprite = currentTimeManipObj.GetChild(1).gameObject.GetComponent<SpriteRenderer>().sprite;
                    timeCanvas.GetChild(0).GetChild(0).gameObject.GetComponent<Image>().overrideSprite = futureSprite;
                    //currentTimeManipObj.gameObject.GetComponent<SpriteRenderer>().sprite = futureSprite;
                    useTimeJuice(1);
                }
                if (remainingUses == 0)
                {
                    Debug.Log("Not enough Time Juice");
                }

            } else {
                timeCanvas.GetChild(0).GetChild(0).gameObject.SetActive(false);
            }


        }
        else { //when letting go of r
            timeCanvas.GetChild(0).gameObject.SetActive(false);

        }



        
    }
    void useTimeJuice(int timeJuice)
    {
        remainingUses -= timeJuice;
        timeBar.SetTimeJuice(remainingUses);

    }
    void addTimeJuice(int timeJuice)
    {
        if (remainingUses + timeJuice < maxUses)
            remainingUses += timeJuice;
        else
            remainingUses = maxUses;
        
        timeBar.SetTimeJuice(remainingUses);

    }
}
