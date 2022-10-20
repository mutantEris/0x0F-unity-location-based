using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDataUpdater : MonoBehaviour
{
    private Text textfield;
    public LData datatype;

    // Start is called before the first frame update
    void Start()
    {
        textfield = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        switch(datatype)
        {
            case LData.longitude:
                textfield.text = Location_Grabinator.longitude.ToString();
                break;
            case LData.latitude:
                textfield.text = "" + Location_Grabinator.latitude;
                break;
            case LData.altitude:
                textfield.text = "" + Location_Grabinator.altitude;
                break;
    }
}

public enum LData
{
    longitude = 0, latitude = 1, altitude = 2
}
}
