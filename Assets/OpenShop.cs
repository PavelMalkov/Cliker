using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShop: MonoBehaviour
{
    Click click;
    private IEnumerator coroutine;
    [SerializeField]
    GameObject buttonShop;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("OpenShop"))
        {
            if (PlayerPrefs.GetInt("OpenShop") != 1) offOpenShope();
            else onOpenShope();
        }
        else offOpenShope();
    }
    private void onOpenShope()
    {
        buttonShop.SetActive(true);
    }
    private void offOpenShope()
    {
        click = gameObject.GetComponent<Click>();
        coroutine = WaitAndPrint(1f);
        StartCoroutine(coroutine);
        buttonShop.SetActive(false);
    }
    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (click.count < 50)
        {
            print("Пока денег не хватает  " + Time.time);
            yield return new WaitForSeconds(waitTime);
        }
        PlayerPrefs.SetInt("OpenShop", 1);
        buttonShop.SetActive(true);
    }
}
