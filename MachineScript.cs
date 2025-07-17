using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MachineScript : MonoBehaviour
{
    [Header("SEV�YE VE KAZANMA AYARLARI")]
    public int level = 1; //Unitenin levelnr
    public float earnInterval = 5f; //Para kazanma s�resi
    public float k = 0.25f; //�stel azalma oran�
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
        //Level numaras�na g�re kazanma s�resi hesaplan�r
        earnInterval = 5f * Mathf.Exp(-k * level); // x=5*e^(-k*level)

        //Saya� artar
        timer += Time.deltaTime;

        //S�re dolunca coin kazan
        if(timer >= earnInterval)
        {
            timer = 0f;
            collectControlScript.ShowCoin();
            //totalCoins++; // Bu k�s�mda metod �a��r�lacak
            Debug.Log("Coin Kazan�ld�");
            
        }

        CoingainvalueText.text = 5 / earnInterval + " " + "per/s";
       
    }
    //L tu�u ile test metodu
    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            level++;
            Debug.Log("Seviye Artt�");
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
