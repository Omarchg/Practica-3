using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class escena : MonoBehaviour
{
    UIDocument uid;
    Button myButton;

    void MyFunction()
    {
        SceneManager.LoadScene("Demo");
    }

    void Start()
    {
        uid = GetComponent<UIDocument>();


        myButton = uid.rootVisualElement.Q<Button>("play");


        myButton.clicked += MyFunction;
    }
}