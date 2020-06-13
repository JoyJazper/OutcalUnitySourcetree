using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableButton : MonoBehaviour
{
    public GameObject awakeOnly_Object;

    public void EnableScript()
    {
        awakeOnly_Object.GetComponent<JustAwake>().enabled = true;
    }

    public void DestroyScript()
    {
        Destroy(awakeOnly_Object);
    }
}
