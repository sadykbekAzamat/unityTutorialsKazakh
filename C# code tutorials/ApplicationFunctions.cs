using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Examples : MonoBehaviour
{
    [Header("Text Version")]
    public Text version;

    private void Awake()
    {
        Application.targetFrameRate = 90; //максималды ойын фпс-і
        //егер телефон бұл фпске дейін көтіреле алмаса, телефон шыдайтындай максималды фпске қойылады
    }

    void Start()
    {
        version.text = "Version: " + Application.version; // ойын версиясын көрсету



        //------- тіл
        if (Application.systemLanguage == SystemLanguage.Russian)
        {
            //телефон орыс тілінде
        }
    }

    public void ExitGame()
    {
        //ойыннан шығу
        Application.Quit();
    }

    public void OpenURL()
    {
        Application.OpenURL("https://www.youtube.com/@ibeta_unity");
    }

    public void IfEditor()
    {
        if (Application.isEditor)
        {
            //егер юнити платформасы болса
        }
    }



    public void IfPlayer()
    {
        if (Application.isMobilePlatform)
        {
            //телефон болса,  орындалатын жер
        }
        else
        {
            //пк или BlueStacks сияктылар болса
        }
    }

}
