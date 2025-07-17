using UnityEngine;

public class UIControlScript : MonoBehaviour
{
    public GameObject Settingspanel;
    public GameObject newsPanel;
    public GameObject creditsPanel;

  
   
    void Start()
    {
        Settingspanel.SetActive(false);
        newsPanel.SetActive(false);
        creditsPanel.SetActive(false);

        
    }

    
    void Update()
    {
        
    }

    public void settingsButton()
    {
        Settingspanel.SetActive(true);
        newsPanel.SetActive(false);
        creditsPanel.SetActive(false);
        
       

    }
    public void newsButton()
    {
        newsPanel.SetActive(true);
        Settingspanel.SetActive(false);
        creditsPanel.SetActive(false);
        
       
    }
    public void creditsButton()
    {
        creditsPanel.SetActive(true);
        Settingspanel.SetActive(false);
        newsPanel.SetActive(false);
        
        
    }

    public void exitbuttonfunc()
    {
        creditsPanel.SetActive(false);
        Settingspanel.SetActive(false);
        newsPanel.SetActive(false);
        
       
    }

    public void BreakTimeButton()
    {
        Application.Quit();
    }
}
