using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    UIDocument uid;
    Button exitb;
    Button arbol;
    Button arbusto;
    Button elemento;
    [SerializeField] private GameObject menuarbol;
    [SerializeField] private GameObject menuarbusto;
    [SerializeField] private GameObject menuelemento;
    private bool isMenuMoved = false;
    private bool isMenuMoveda = false;
    private bool isMenuMovede = false;
    void MyFunction()
    {
        SceneManager.LoadScene("Menu");
    }


    void Menuarbol()
    {
        
        isMenuMoved = !isMenuMoved;

        if (isMenuMoved)
        {
            LeanTween.moveX(menuarbol.GetComponent<RectTransform>(), 0, 0.5f);
        }
        else
        {
            LeanTween.moveX(menuarbol.GetComponent<RectTransform>(), 721, 0.5f);
        }
    }

    void Menuarbusto()
    {
        
        isMenuMoveda = !isMenuMoveda;

        if (isMenuMoveda)
        {
            LeanTween.moveX(menuarbusto.GetComponent<RectTransform>(), 0, 0.5f);
        }
        else
        {
            LeanTween.moveX(menuarbusto.GetComponent<RectTransform>(), 721, 0.5f);
        }
    }

    void Menuelemento()
    {
        
        isMenuMovede = !isMenuMovede;

        if (isMenuMovede)
        {
            LeanTween.moveX(menuelemento.GetComponent<RectTransform>(), 0, 0.5f);
        }
        else
        {
            LeanTween.moveX(menuelemento.GetComponent<RectTransform>(), 721, 0.5f);
        }
    }

    void Start()
    {
        uid = GetComponent<UIDocument>();


        exitb = uid.rootVisualElement.Q<Button>("exit");
        arbol = uid.rootVisualElement.Q<Button>("arbol");
        arbusto = uid.rootVisualElement.Q<Button>("arbusto");
        elemento = uid.rootVisualElement.Q<Button>("elemento");


        exitb.clicked += MyFunction;
        arbol.clicked += Menuarbol;
        arbusto.clicked += Menuarbusto;
        elemento.clicked += Menuelemento;

    }
}