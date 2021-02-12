
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TimeManipObj tree;
    private bool droppedApple = false;

    void Start()
    {
        tree.past();
    }

    // Update is called once per frame
    void Update()
    {
        if (tree.futureMode == true && !droppedApple)
        {
            Debug.Log("Drop apple");
            gameObject.transform.GetChild(2).gameObject.SetActive(true);
            droppedApple = true;
        }
    }
}
