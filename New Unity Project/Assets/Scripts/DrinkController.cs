using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrinkController : MonoBehaviour
{
    [SerializeField]
    public GameObject imageGO;
    private int current = 0;
    public int count;

    public void Drink()
    {
        current++;
        if (current == count)
        {
            imageGO.SetActive(true);
            Drunk(5f, () =>
            {
                imageGO.SetActive(false);
            });
        }
    }

	public void Drunk(float time, System.Action nextEvent = null){
		StartCoroutine(CoDrunk(time, nextEvent));
	}

    IEnumerator CoDrunk(float time, System.Action nextEvent = null)
    {   
        float temp = 0f;
		while(temp < 1f){
            temp += (Time.deltaTime / time);
			yield return null;
		}

		if(nextEvent != null) nextEvent();
    }
}