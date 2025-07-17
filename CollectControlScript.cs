using UnityEngine;
using UnityEngine.UI;


public class CollectControlScript : MonoBehaviour
{
    public Text coinText;
    public int totalCoins = 0;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void ShowCoin()
    {
        totalCoins += 5;
        coinText.text = totalCoins.ToString();
    }
}
