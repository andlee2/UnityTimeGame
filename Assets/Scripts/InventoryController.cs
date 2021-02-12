using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public GameObject currentInterObj = null;
    //public Interactable currentInterObjScript = null; //Interactable object script
    public Transform InventoryCanvas;
    public Inventory inventory;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag ("Collectable")){
            Debug.Log(other.name);
            currentInterObj = other.gameObject;
            //currentInterObjScript = currentInterObj.GetComponent <Interactable> (); //grabs items script


        }
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag ("Collectable")){
            if (other.gameObject == currentInterObj) {
                currentInterObj = null;
            }
            

        }
    }
    void Start()
    {
        InventoryCanvas.GetChild(0).gameObject.SetActive(false);
    }

    private bool inventoryOpened = false;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("OpenInventory")){
            if (!inventoryOpened) {
                InventoryCanvas.GetChild(0).gameObject.SetActive(true);
                
                inventoryOpened = true;
            } else {
                InventoryCanvas.GetChild(0).gameObject.SetActive(false);
                
                inventoryOpened = false;
            }

        }
      
            
        
        if (Input.GetButtonDown("Collect") && currentInterObj) {

                inventory.AddItem(currentInterObj);

            
            

            //sprite.sortingOrder = 0; //Change sorting order of character

        }
       


    }
}
