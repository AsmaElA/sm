using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MeunManeger : MonoBehaviour
{
    public GameObject Menu_Panel;
    public GameObject Levls_Panel;


   





    public void showLevels()
    {
        Levls_Panel.SetActive(true);
        Menu_Panel.SetActive(false);
    }

    public void showMenu()
    {
        Levls_Panel.SetActive(false);
        Menu_Panel.SetActive(true);
    }

 




}
