using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePointer : MonoBehaviour
{
    public GameObject quotesObjectPrefab;
    public GameObject quotesObject;
    string quoteObjectName;

    // Start is called before the first frame update
    //TODO
    //will this be invoked everytime object is active?
    void Start()
    {
        quoteObjectName = "";
        //Instantiate(quotesObjectPrefab);
        //Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(quotesObject == null)
            {
                InstanstiateQuotesObject();
            }
            Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            transform.position = target;
        }
    }

    IEnumerator LoadYourAsyncScene()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Load", LoadSceneMode.Additive);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        quotesObject.SetActive(true);
        SceneManager.MoveGameObjectToScene(quotesObject, SceneManager.GetSceneByName("Load"));
      
        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);
    }

    void InstanstiateQuotesObject()
    {
        quotesObject = Instantiate(quotesObjectPrefab);
    }
}
