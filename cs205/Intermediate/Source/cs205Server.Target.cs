using UnrealBuildTool;

public class cs205ServerTarget : TargetRules
{
	public cs205ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("cs205");
	}
}
