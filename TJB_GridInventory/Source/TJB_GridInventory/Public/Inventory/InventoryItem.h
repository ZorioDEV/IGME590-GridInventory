// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "ItemDataAsset.h"
#include "InventoryItem.generated.h"

/**
 * 
 */
USTRUCT(BlueprintType)
struct FInventoryItem
{
	GENERATED_BODY()
	
	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Inventory")
	TObjectPtr<UItemDataAsset> ItemData = nullptr;
 
	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Inventory")
	FIntPoint TopLeftSlot = FIntPoint(0, 0);
 
	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Inventory")
	bool bRotated = false;
 
	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Inventory")
	int32 CurrentStackCount = 1;
 
	FIntPoint GetDimensions() const
	{
		if (ItemData)
		{
			return ItemData->GetDimensions(bRotated);
		}
		else return FIntPoint(0, 0);
	}
};
