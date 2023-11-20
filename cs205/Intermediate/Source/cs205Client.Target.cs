using UnrealBuildTool;

public class cs205ClientTarget : TargetRules
{
	public cs205ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("cs205");
	}
}
