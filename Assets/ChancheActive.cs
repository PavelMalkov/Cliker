using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChancheActive : MonoBehaviour
{
    public void ChancheActiveFun(GameObject gameObject)
    {
        if (gameObject.activeSelf) gameObject.SetActive(false);
        else gameObject.SetActive(true);
    }
}
