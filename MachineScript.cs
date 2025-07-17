using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MachineScript : MonoBehaviour
{
    [Header("SEVÝYE VE KAZANMA AYARLARI")]
    public int level = 1; //Unitenin levelnr
    public float earnInterval = 5f; //Para kazanma süresi
    public float k = 0.25f; //Üstel azalma oraný
    public TextMeshProUGUI LvText;
    public TextMeshProUGUI CoingainvalueText;
    

    private float timer = 0f;

    CollectControlScript collectControlScript;

    public GameObject MacCanvas;

    


    void Start()
    {
        MacCanvas.gameObject.SetActive(false);
        collectControlScript = FindObjectOfType<CollectControlScript>();
    }

    
    void Update()
    {
        //Level numarasýna göre kazanma süresi hesaplanýr
        earnInterval = 5f * Mathf.Exp(-k * level); // x=5*e^(-k*level)

        //Sayaç artar
        timer += Time.deltaTime;

        //Süre dolunca coin kazan
        if(timer >= earnInterval)
        {
            timer = 0f;
            collectControlScript.ShowCoin();
            //totalCoins++; // Bu kýsýmda metod çaðýrýlacak
            Debug.Log("Coin Kazanýldý");
            
        }

        CoingainvalueText.text = 5 / earnInterval + " " + "per/s";
       
    }
    //L tuþu ile test metodu
    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            level++;
            Debug.Log("Seviye Arttý");
            LvText.text = "Lv: " + level.ToString();
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            MacCanvas.gameObject.SetActive(true);
        }

       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            MacCanvas.gameObject.SetActive(false);
        }
    }
}
