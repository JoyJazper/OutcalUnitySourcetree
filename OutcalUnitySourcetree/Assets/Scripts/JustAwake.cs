using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JustAwake : MonoBehaviour
{
    public Text awake_Text;
    public Text start_Text;
    public Text eventUpdate_Text;

    void Awake()
    {
        Debug.Log( this.name + " Object is Initialized.");
        awake_Text.text = this.name + "Object is Initialized.";
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("from Start func object of name : " + this.name + " , now you can press f.");
        start_Text.text = "from Start func object of name : " + this.name + " , now you can press f.";
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) || Input.GetMouseButtonDown(0))
        {
            eventUpdate_Text.text = "Either F or Left Mouse button is pressed";
        }

        if(Input.GetKey(KeyCode.F))
        {
            Debug.Log("F is pressed.");
        }

        if(Input.GetKeyUp(KeyCode.F))
        {
            eventUpdate_Text.text = "Either F is released";
        }
    }

    private void OnDestroy()
    {
        awake_Text.text = this.name + "Object is destroyed, Please restart";
        start_Text.text = "";
        eventUpdate_Text.text = "";
    }
}
