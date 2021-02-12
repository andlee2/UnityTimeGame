
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{


    public GameObject[] inventory = new GameObject[5];
    public Image[] inventorySlots = new Image[5];
    //public Transform inventoryPanel;


    public void AddItem(GameObject item)
    {
        bool itemAdded = false;

        //Find the first open slot in inventory
        for (int i = 0; i < inventory.Length; i++){
            if (inventory[i] == null) {
                inventory[i] = item;

                inventorySlots[i].overrideSprite = item.GetComponent<SpriteRenderer>().sprite;
                inventorySlots[i].color = item.GetComponent<SpriteRenderer>().color;
                
                
                Debug.Log(item.name + " was collected");
                itemAdded = true;
                //Do something with object
                item.SendMessage("Collect");

                break;

            }
        }
        if(!itemAdded) {
            Debug.Log("Inventory Full - Item Not Added");
        }


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
