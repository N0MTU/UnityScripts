using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Web : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(GetText());
        // StartCoroutine(Login("testuser","1234"));
        StartCoroutine(CreateUser("CreateUserTest1", "password123"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GetText()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/UnityBackend/dateDisplay.php/"))
        {
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);

            }
        }
    }

    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginuser", username);
        form.AddField("loginpass", password);
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/UnityBackend/Login.php/", form))
            
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);

            }


        }
    }


    public IEnumerator CreateUser(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginuser", username);
        form.AddField("loginpass", password);
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/UnityBackend/CreateUser.php/", form))

        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);

            }


        }
    }
}
