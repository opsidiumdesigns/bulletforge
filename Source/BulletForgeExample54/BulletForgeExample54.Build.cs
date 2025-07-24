// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class BulletForgeExample54 : ModuleRules
{
	public BulletForgeExample54(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
