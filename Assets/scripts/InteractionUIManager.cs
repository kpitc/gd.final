using UnityEngine;
using UnityEngine.UI;
using TMPro;
using StarterAssets;

public class InteractionUIManager : MonoBehaviour

{
    public GameObject uiPanel;              //pop-up for dialogue (toggle this)
    public TextMeshProUGUI dialogueText;     //actual text

    //player choices
    public Button optionButtonA;            
    public Button optionButtonB;

    //function pointers
    private System.Action onOptionA;
    private System.Action onOptionB;

    //hides UI at start
    private void Start() {
        uiPanel.SetActive(false);
    }

    //main function gets called when player interacts with something
    //takes in message, option strings, and functions for if player clicks either option
    public void displayInt(string message, string optionAText, string optionBText, System.Action onOptionA, System.Action onOptionB) {
        
        //show panel and message
        uiPanel.SetActive(true);        
        dialogueText.text = message;    

        //store functions or respective actions we want
        this.onOptionA = onOptionA;
        this.onOptionB = onOptionB;

        //sets respective text to button
        //optionButtonA.GetComponentInChildren<TextMeshProUGUI>().text = optionAText;
        //optionButtonB.GetComponentInChildren<TextMeshProUGUI>().text = optionBText;

        bool hasOptionA = !string.IsNullOrEmpty(optionAText);
        bool hasOptionB = !string.IsNullOrEmpty(optionBText);

        optionButtonA.gameObject.SetActive(hasOptionA);
        optionButtonA.gameObject.SetActive(hasOptionB);
            
        optionButtonA.onClick.RemoveAllListeners();
        optionButtonB.onClick.RemoveAllListeners();
        //resets button behavior
       

        if (hasOptionA) {
            this.onOptionA = onOptionA;
            optionButtonA.GetComponentInChildren<TextMeshProUGUI>().text = optionAText;
            optionButtonA.onClick.AddListener(() => {
                onOptionA?.Invoke();
            });
        }

        if (hasOptionB) {
            this.onOptionB = onOptionB;
            optionButtonB.GetComponentInChildren<TextMeshProUGUI>().text = optionBText;
            optionButtonB.onClick.AddListener(() => {
                onOptionB?.Invoke();
            });
        }
    

        if (GameState.Instance == null || GameState.Instance.currentPhase == GamePhase.InGame)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            FirstPersonController player = FindFirstObjectByType<FirstPersonController>();
            if (player != null)
                player.enabled = false;
        }
    }
 


    //simple hide pop-up
    public void hideInt()
    {

        uiPanel.SetActive(false);

        if (GameState.Instance == null || GameState.Instance.currentPhase == GamePhase.InGame)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            FirstPersonController player = FindFirstObjectByType<FirstPersonController>();
            if (player != null)
                player.enabled = true;
        }
    }

}