// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TJB_GridInventory : ModuleRules
{
	public TJB_GridInventory(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"TJB_GridInventory",
			"TJB_GridInventory/Variant_Platforming",
			"TJB_GridInventory/Variant_Platforming/Animation",
			"TJB_GridInventory/Variant_Combat",
			"TJB_GridInventory/Variant_Combat/AI",
			"TJB_GridInventory/Variant_Combat/Animation",
			"TJB_GridInventory/Variant_Combat/Gameplay",
			"TJB_GridInventory/Variant_Combat/Interfaces",
			"TJB_GridInventory/Variant_Combat/UI",
			"TJB_GridInventory/Variant_SideScrolling",
			"TJB_GridInventory/Variant_SideScrolling/AI",
			"TJB_GridInventory/Variant_SideScrolling/Gameplay",
			"TJB_GridInventory/Variant_SideScrolling/Interfaces",
			"TJB_GridInventory/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
