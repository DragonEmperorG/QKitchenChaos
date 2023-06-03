using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKitchenObjectParent {
    public Transform GetKitchenObjectFollowTransform();

    public bool HasKitchenObject();

    public KitchenObject GetKitchenObject();

    public void SetKitchenObject(KitchenObject kitchenObject);

    public void ClearKitchenObject();

}
