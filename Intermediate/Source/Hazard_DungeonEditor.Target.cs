using UnrealBuildTool;

public class Hazard_DungeonEditorTarget : TargetRules
{
	public Hazard_DungeonEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Hazard_Dungeon");
	}
}
