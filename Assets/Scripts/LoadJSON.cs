using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;
using UnityEngine.Networking;

public class LoadJSON : MonoBehaviour
{
	public InputField inputTxt;
	public Text countryTxt;
	public Text nameTxt;
	public Text genderTxt;
	public Text birthTxt;

	public void GetJsonData()
	{
		StartCoroutine(RequestWebService());
	}

	IEnumerator RequestWebService()
	{
		string getDataUrl = "http://localhost:5000/api/Patient/" + inputTxt.text;
		print(getDataUrl);

		using (UnityWebRequest webData = UnityWebRequest.Get(getDataUrl))
		{
			yield return webData.SendWebRequest();
			if (webData.isNetworkError || webData.isHttpError)
			{
				print("------------ERROR------------");
				print(webData.error);
			}
			else
			{
				if (webData.isDone)
				{
					JSONNode jsonData = JSON.Parse(System.Text.Encoding.UTF8.GetString(webData.downloadHandler.data));

					if (jsonData == null)
					{
						print("-------------NO DATA-------------");
					}
					else
					{
						print("-------------JSON DATA-------------");
						print("jsonData.Count:" + jsonData.Count);
						nameTxt.text = jsonData["name"][0]["given"][0] + jsonData["name"][0]["family"];
						genderTxt.text = jsonData["gender"];
						birthTxt.text = jsonData["birthDate"];
						countryTxt.text = jsonData["address"][0]["country"];
					}
				}
			}
		}
	}
}