using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class API : MonoBehaviour
{
	private const string URL = "http://localhost:5000/api/Patient/pages/1";
	public Text responseText;

    public void Request()
	{
        WWW request = new WWW(URL);
		StartCoroutine(OnResponce(request));
	}

    private IEnumerator OnResponce(WWW req)
	{
		yield return req;

		responseText.text = req.text;
	}
}