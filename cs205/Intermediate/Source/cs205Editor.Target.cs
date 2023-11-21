using UnrealBuildTool;

public class cs205EditorTarget : TargetRules
{
	public cs205EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("cs205");
	}
}
