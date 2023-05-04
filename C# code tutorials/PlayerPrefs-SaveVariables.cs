using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    [Header("Sandar")]
    public Text nums;

    [Header("Aripter")]
    public Text strings;

    [Header("String")]
    public string soz;

    [Header("Int")]
    public int san;

    void Start()
    {
        //ойын басталғанда орындалатын фунциялар!
        GetData();
    }

    void Awake()
    {
        //Бұл жерде ойын басталғанда орындалады, бірақ жоғарыдағы " Старт "- тан бұрын орындалады!
        /*Менен Кеңес!
         * Егер бірінші ойын үшін маңызды заттарды алу керек болса осы жерді пайдаланыңыз!*/
    }

    public void GetData()
    {
        if (PlayerPrefs.HasKey("soz"))  // <- барма жоқпа тексеру
        {
            soz = PlayerPrefs.GetString("soz"); // егер бар болса: АЛУ
        }
        else  //егер жоқ болса жасалатын функция
        {
            soz = "Ештеңе жоқ";
            strings.text = soz; //<- Сыртқа көрсету
        }


        //Бұл әдіспен тек 3 айнымалы түрі сақталады! : String, int, float!
        if (PlayerPrefs.HasKey("san"))
        {
            san = PlayerPrefs.GetInt("san");
        }


        nums.text = san + "";//<- Сыртқа көрсету
        strings.text = soz;  //<- Сыртқа көрсету
    }

    public void SaveButton()
    {
        PlayerPrefs.SetInt("san", san); // Базамен теңестіру
        PlayerPrefs.SetString("soz", soz);
        PlayerPrefs.Save(); //сақтау !!!Міндетті түрде болу керек
    }

    public void RandomSan()
    {
        san = Random.Range(100, 999);
        nums.text = san.ToString();
    }

}
