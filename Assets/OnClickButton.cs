using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickButton : MonoBehaviour
{
    [SerializeField]
    GameObject popup;
    public void newPopup()
    {
        Instantiate(popup, transform.position, Quaternion.identity, transform);
    }
}
