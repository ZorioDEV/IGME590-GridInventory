// Fill out your copyright notice in the Description page of Project Settings.


#include "Public/Inventory/ItemDataAsset.h"

FIntPoint UItemDataAsset::GetDimensions(bool bRotated) const
{
	if (bRotated)
	{
		return FIntPoint(GridSize.Y, GridSize.X);
	}
	else return GridSize;
}
