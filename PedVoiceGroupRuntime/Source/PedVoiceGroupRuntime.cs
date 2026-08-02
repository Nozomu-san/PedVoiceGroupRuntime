using Alloc8orStandardNatives.Source;
using CommunityScriptHookVDotNetCore.Source;

namespace PedVoiceGroupRuntime.Source;

public sealed class PedVoiceGroupRuntimeScript : Script4
{
    protected override void OnStart(ScriptStartContext context) =>
        StandardNatives.SET_AUDIO_FLAG(
            "LoadMPData",
            true);
}