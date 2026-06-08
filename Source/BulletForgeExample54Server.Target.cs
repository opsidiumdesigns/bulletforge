// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BulletForgeExample54ServerTarget : TargetRules
{
	public BulletForgeExample54ServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
<<<<<<< HEAD
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_7;
=======
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_6;
>>>>>>> origin/5.6
		BuildEnvironment = TargetBuildEnvironment.Shared;
		ExtraModuleNames.Add("BulletForgeExample54");
	}
}
