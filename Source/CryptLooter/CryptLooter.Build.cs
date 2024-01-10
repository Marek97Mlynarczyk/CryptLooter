// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CryptLooter : ModuleRules
{
	public CryptLooter(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
