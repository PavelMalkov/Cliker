using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Click : MonoBehaviour
{
    private IEnumerator coroutine;
    Text text;
    public int count = 0;

    public int income = 0;

    public void bayInComeOne(int sum)
    {
        count -= sum;
        income += 1;
    }

    private void Start()
    {
        text = gameObject.GetComponent<Text>();
        text.text = count.ToString();
        text.color = ColorChanche(count);
        coroutine = WaitAndPrint(1f);
        StartCoroutine(coroutine);
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            count += income;
            text.text = count.ToString();
            text.color = ColorChanche(count);
            yield return new WaitForSeconds(waitTime);
        }
    }
    public void OnClickPlus()
    {
        count += 1;
        text.text = count.ToString();
        text.color = ColorChanche(count);
    }
    public void OnClickMinus()
    {
        count -= 1;
        text.text = count.ToString();
        text.color = ColorChanche(count);
    }
    public void OnClickZiro()
    {
        count = 0;
        text.text = count.ToString();
        text.color = ColorChanche(count);
    }
    private Color ColorChanche(int x)
    {
        Color color = new Color(255,255,255);
        if (x > 0) color = Color.green;
        if (x < 0) color = Color.red; 
        return color;
    }
    private string Formate(int count)
    {
        // условие и по условии присваивате ту или иную цифру значение
        return 1 + "K";
    }
}
