using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using DialogueEditor;

public class Neighbourtalk : MonoBehaviour
{
    public NPCConversation myConversation; 

    public void OnButtonClick()
     {
        ConversationManager.Instance.StartConversation(myConversation);
     }
}
