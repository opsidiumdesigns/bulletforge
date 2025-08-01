// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BulletForgeExample54TargetServer : TargetRules
{
	public BulletForgeExample54TargetServer(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_6;
		BuildEnvironment = TargetBuildEnvironment.Shared;
		ExtraModuleNames.Add("BulletForgeExample54");
	}
}
