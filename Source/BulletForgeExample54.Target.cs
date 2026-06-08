// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BulletForgeExample54Target : TargetRules
{
	public BulletForgeExample54Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
<<<<<<< HEAD
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_7;
=======
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_6;
>>>>>>> origin/5.6
		ExtraModuleNames.Add("BulletForgeExample54");
	}
}
