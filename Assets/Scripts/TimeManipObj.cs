using UnityEngine;

public class TimeManipObj : MonoBehaviour
{

    //public Sprite[] sprites = new Sprite[2];

    // Start is called before the first frame update
    public bool pastMode = false;
    public bool futureMode = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void past()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        //gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
        pastMode = true;
        futureMode = false;
    }
    public void future()
    {
        gameObject.transform.GetChild(1).gameObject.SetActive(true);
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        //gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
        pastMode = false;
        futureMode = true;
    }
}
