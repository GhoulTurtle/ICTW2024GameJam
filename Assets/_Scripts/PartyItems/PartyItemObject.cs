using System.Collections;
using UnityEngine;

public class PartyItemObject : MonoBehaviour, IGrabbable
{
	private PartyItemSO partyItemSO;
	private PartyItemSpawner parentSpawner;

	public virtual void SetupPartyObject(PartyItemSO _partyItemSO, PartyItemSpawner _parentSpawner){
		partyItemSO = _partyItemSO;
		parentSpawner = _parentSpawner;
	}

    public virtual bool AttemptGrabObject(){
		return partyItemSO.isGrabbable;
    }

    public virtual void StartPartyItemCoroutine(IEnumerator coroutineToRun){
		StartCoroutine(coroutineToRun);
	}

	public virtual void DeletePartyItem(){
		parentSpawner.RemovePartyItem(this);
		Destroy(gameObject);
	}
}
