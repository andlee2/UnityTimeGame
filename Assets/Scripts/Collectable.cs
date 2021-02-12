
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public bool collectable;

    public void Collect()
    {
        gameObject.SetActive(false);
    }
}
