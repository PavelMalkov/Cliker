using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveNumber : MonoBehaviour
{    // Start is called before the first frame update
    private IEnumerator coroutine;
    [SerializeField]
    float speed = 5;
    [SerializeField]
    Vector2 vector2;
    void Start()
    {
        vector2 = new Vector2(Random.Range(-3f, 3f), Random.Range(0f, 3f));
        coroutine = WaitAndPrint(0.02f);
        StartCoroutine(coroutine);
    }
    private void FixedUpdate()
    {
        transform.Translate(vector2 * Time.deltaTime / speed);
    }
    private IEnumerator WaitAndPrint(float waitTime)
    {
        float i = 255;
        while (i > 0)
        {
            i -= 3;
            this.gameObject.GetComponent<Text>().color  = new Color(0,0,0, i/255);
            yield return new WaitForSeconds(waitTime);
            //print("ќжидание  " + Time.time);
        }
        Destroy(gameObject);
    }
}
