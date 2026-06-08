// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BulletForgeExample54EditorTarget : TargetRules
{
	public BulletForgeExample54EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
<<<<<<< HEAD
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_6;
=======
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
>>>>>>> origin/5.5
		ExtraModuleNames.Add("BulletForgeExample54");
	}
}
