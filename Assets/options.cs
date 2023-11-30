using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class options : MonoBehaviour
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

    
    private Color originalColorArbol;
    private Color originalColorArbusto;
    private Color originalColorElemento;

    
    private Color blueColor = new Color(0, 0, 1);

   

    void MyFunction()
    {
        SceneManager.LoadScene("Menu");
    }

    void Menuarbol()
    {
        isMenuMoved = !isMenuMoved;

        
        if (originalColorArbol == default)
            originalColorArbol = arbol.resolvedStyle.backgroundColor;

        // Cambiar color del botón
        arbol.style.backgroundColor = isMenuMoved ? blueColor : (isMenuMoved ? originalColorArbol : new StyleColor(StyleKeyword.Null));

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

        
        if (originalColorArbusto == default)
            originalColorArbusto = arbusto.resolvedStyle.backgroundColor;

        // Cambiar color del botón
        arbusto.style.backgroundColor = isMenuMoveda ? blueColor : (isMenuMoveda ? originalColorArbusto : new StyleColor(StyleKeyword.Null));

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

        
        if (originalColorElemento == default)
            originalColorElemento = elemento.resolvedStyle.backgroundColor;

        // Cambiar color del botón
        elemento.style.backgroundColor = isMenuMovede ? blueColor : (isMenuMovede ? originalColorElemento : new StyleColor(StyleKeyword.Null));

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
